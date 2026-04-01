using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmTaiKhoan : Form
    {
        private string currentUserID;
        private string selectedAccountID; // Biến lưu ID tài khoản đang được chọn trong DataGridView
        public FrmTaiKhoan(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
        }

        public void LoadData()
        {
            // NẠP DỮ LIỆU CỐ ĐỊNH CHO COMBOBOX LOẠI TÀI KHOẢN
            // Chỉ thêm vào nếu ComboBox đang trống (tránh bị lặp lại khi gọi lại hàm LoadData)
            if (cbo_LoaiTK.Items.Count == 0)
            {
                cbo_LoaiTK.Items.Add("Cash");
                cbo_LoaiTK.Items.Add("Bank");
                cbo_LoaiTK.Items.Add("E-Wallet");
                cbo_LoaiTK.Items.Add("Creadit Card");
                cbo_LoaiTK.SelectedIndex = 0; // Chọn mặc định dòng đầu tiên
            }

            // NẠP DỮ LIỆU TỪ SQL VÀO DATAGRIDVIEW
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Dùng LINQ lấy danh sách tài khoản của User hiện tại
                    var dsTaiKhoan = db.Accounts
                                       .Where(a => a.UserID == currentUserID)
                                       .Select(a => new
                                       {
                                           MaTK = a.AccountID,
                                           TenTK = a.AccountName,
                                           LoaiTK = a.AccountType,
                                           SoDu = a.Balance,
                                           NganHang = a.BankDetail
                                       }).ToList();

                    // Đổ dữ liệu vào bảng
                    dgvTaiKhoan.DataSource = dsTaiKhoan;

                    if (dgvTaiKhoan.Columns.Count > 0)
                    {
                        dgvTaiKhoan.Columns["MaTK"].HeaderText = "Mã tài khoản";
                        dgvTaiKhoan.Columns["TenTK"].HeaderText = "Tên tài khoản";
                        dgvTaiKhoan.Columns["LoaiTK"].HeaderText = "Loại";

                        dgvTaiKhoan.Columns["SoDu"].HeaderText = "Số dư (VNĐ)";
                        dgvTaiKhoan.Columns["SoDu"].DefaultCellStyle.Format = "N0"; // Định dạng phân cách hàng nghìn

                        dgvTaiKhoan.Columns["NganHang"].HeaderText = "Ngân hàng/Ví";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadThongKe()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Kéo toàn bộ tài khoản của User này về RAM trước để xử lý cho an toàn
                    var userAccounts = db.Accounts.Where(a => a.UserID == currentUserID).ToList();

                    // Kiểm tra xem người này có tài khoản nào chưa (Tránh lỗi Crash App nếu list rỗng)
                    if (userAccounts.Count > 0)
                    {
                        // Dùng LINQ để tính toán trực tiếp trên List
                        decimal tongSoDu = userAccounts.Sum(a => (decimal)a.Balance);
                        decimal soDuTB = userAccounts.Average(a => (decimal)a.Balance);
                        decimal soDuMin = userAccounts.Min(a => (decimal)a.Balance);
                        decimal soDuMax = userAccounts.Max(a => (decimal)a.Balance);

                         // Đổ dữ liệu lên giao diện (Format N0 thêm dấu phẩy)
                        lblTongSoDu.Text = tongSoDu.ToString("N0") + " VNĐ";
                        lblSoDuTB.Text = soDuTB.ToString("N0") + " VNĐ";
                        lblSoDuMin.Text = soDuMin.ToString("N0") + " VNĐ";
                        lblSoDuMax.Text = soDuMax.ToString("N0") + " VNĐ";
                    }
                    else
                    {
                        // Nếu chưa có ví tiền nào thì hiển thị 0
                        lblTongSoDu.Text = "0 VNĐ";
                        lblSoDuTB.Text = "0 VNĐ";
                        lblSoDuMin.Text = "0 VNĐ";
                        lblSoDuMax.Text = "0 VNĐ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadChart()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Dùng LINQ lấy Tên tài khoản và Số dư. 
                    // Mẹo nhỏ: Chỉ lấy các tài khoản có số dư > 0 (Vì ví 0 đồng thì không thể vẽ lên miếng bánh được)
                    var chartData = db.Accounts
                                      .Where(a => a.UserID == currentUserID && a.Balance > 0)
                                      .Select(a => new
                                      {
                                          TenTK = a.AccountName,
                                          SoDu = a.Balance
                                      }).ToList();

                    // Dọn dẹp dữ liệu cũ của biểu đồ
                    chartCoCau.Series.Clear();
                    chartCoCau.Titles.Clear();

                    // Thêm tiêu đề cho biểu đồ
                    chartCoCau.Titles.Add("Cơ cấu tài sản");
                    chartCoCau.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

                    // Nếu user chưa có tiền trong bất kỳ ví nào thì thoát luôn, không vẽ
                    if (chartData.Count == 0) return;

                    //  Khởi tạo Series dạng Bánh Doughnut
                    Series series = chartCoCau.Series.Add("SoDuSeries");
                    series.ChartType = SeriesChartType.Doughnut;

                    series.Label = "#PERCENT{P0}"; // Chỉ hiện % trên miếng bánh
                    series["PieLabelStyle"] = "Inside"; // Ép chữ % nằm gọn bên trong
                    series.Font = new Font("Arial", 9, FontStyle.Bold);
                    series.LabelForeColor = Color.White;
                    series.LegendText = "#VALX"; // Hiện tên ví ở khung chú thích bên cạnh

                    // Đổ dữ liệu vào biểu đồ
                    foreach (var item in chartData)
                    {
                        int pIndex = series.Points.AddXY(item.TenTK, item.SoDu);

                        // Tooltip: Khi rê chuột vào sẽ hiện ra số tiền cụ thể
                        series.Points[pIndex].ToolTip = $"{item.TenTK}: {item.SoDu:N0} VNĐ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải biểu đồ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void form_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadData();
            LoadChart();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                selectedAccountID = row.Cells["MaTK"].Value.ToString();
                txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
                txt_SoDu.Text = row.Cells["SoDu"].Value.ToString() ?? "0";
                cbo_LoaiTK.SelectedItem = row.Cells["LoaiTK"].Value.ToString();

                object nganHang = row.Cells["NganHang"].Value;
                if (nganHang == null || nganHang == DBNull.Value)
                {
                    txt_TenNH.Text = "";
                }
                else
                {
                    txt_TenNH.Text = nganHang.ToString();
                }

                txt_SoDu.Enabled = false;
                btn_Them.Enabled = true;
            }    
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu (Validate)
            string tenTK = txt_TenTK.Text.Trim();
            string loaiTK = cbo_LoaiTK.SelectedItem?.ToString() ?? "Cash";
            string nganHang = txt_TenNH.Text.Trim();

            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenTK.Focus();
                return;
            }

            // Ép kiểu Số dư an toàn (Tránh người dùng gõ chữ "abc" vào ô số tiền)
            if (!decimal.TryParse(txt_SoDu.Text.Trim(), out decimal soDu))
            {
                MessageBox.Show("Số dư phải là một con số hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoDu.Focus();
                return;
            }

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {

                    // Kiểm tra xem User này đã có tài khoản nào trùng tên chưa (Không phân biệt hoa thường)
                    bool isDuplicate = db.Accounts.Any(a => a.UserID == currentUserID && a.AccountName.ToLower() == tenTK.ToLower());

                    if (isDuplicate)
                    {
                        MessageBox.Show("Tên tài khoản này đã tồn tại! Vui lòng đặt tên khác (VD: MB Bank 2, quỹ đen...)",
                                        "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_TenTK.Focus();
                        return; // Dừng lại không cho thêm
                    }

                    // Tự động sinh Mã Tài Khoản
                    string newAccID = "ACC001"; // Mặc định nếu bảng Accounts đang trống trơn

                    // Tìm mã ACC lớn nhất trong TOÀN BỘ hệ thống
                    var lastAcc = db.Accounts.OrderByDescending(a => a.AccountID).FirstOrDefault();
                    if (lastAcc != null)
                    {
                        // Cắt 3 chữ cái đầu "ACC", lấy phần số ("ACC005" -> 5), cộng 1 -> 6, rồi ghép lại
                        int lastNum = int.Parse(lastAcc.AccountID.Substring(3));
                        newAccID = "ACC" + (lastNum + 1).ToString("D3"); // D3 tự động chèn số 0 thành 006
                    }

                    // Tạo đối tượng Account mới và nhét dữ liệu vào
                    Account newAcc = new Account();
                    newAcc.AccountID = newAccID;
                    newAcc.UserID = currentUserID; // Gắn đúng chủ nhân của ví này
                    newAcc.AccountName = tenTK;
                    newAcc.AccountType = loaiTK;
                    newAcc.Balance = soDu;

                    // Nếu là tiền mặt thì ép thành NULL cho chuẩn DB
                    newAcc.BankDetail = (loaiTK == "Cash" || loaiTK == "Creadit Card") ? null : nganHang;

                    // Lưu vào cơ sở dữ liệu
                    db.Accounts.InsertOnSubmit(newAcc);
                    db.SubmitChanges();

                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại giao diện ngay lập tức
                    clearInputFields();   // Xóa trắng các ô gõ
                    LoadData();      // Load lại bảng DataGridView
                    LoadThongKe();   // Tính lại 4 ô Tổng số tiền
                    LoadChart();     // Vẽ lại biểu đồ cơ cấu tài sản
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã click chọn dòng nào trong bảng chưa
            if (string.IsNullOrEmpty(selectedAccountID))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate dữ liệu nhập vào (giống hệt nút Thêm)
            string tenTK = txt_TenTK.Text.Trim();
            string loaiTK = cbo_LoaiTK.SelectedItem?.ToString() ?? "Cash";
            string nganHang = txt_TenNH.Text.Trim();

            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Kiểm tra trùng tên, nhưng PHẢI BỎ QUA cái AccountID đang được chọn để sửa
                    bool isDuplicate = db.Accounts.Any(a => a.UserID == currentUserID
                                                         && a.AccountID != selectedAccountID
                                                         && a.AccountName.ToLower() == tenTK.ToLower());

                    if (isDuplicate)
                    {
                        MessageBox.Show("Tên tài khoản này đã được sử dụng cho một ví khác! Vui lòng chọn tên khác.",
                                        "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_TenTK.Focus();
                        return;
                    }
                    //  Dùng LINQ tìm đúng cái Ví tiền có mã ID đang được chọn
                    var accToUpdate = db.Accounts.SingleOrDefault(a => a.AccountID == selectedAccountID);

                    if (accToUpdate != null)
                    {
                        // Ghi đè dữ liệu mới vào
                        accToUpdate.AccountName = tenTK;
                        accToUpdate.AccountType = loaiTK;
                        accToUpdate.BankDetail = (loaiTK == "Cash") ? null : nganHang;

                        // Lưu cập nhật xuống SQL
                        db.SubmitChanges();

                        MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh lại toàn bộ màn hình
                        clearInputFields();
                        LoadData();
                        LoadThongKe();
                        LoadChart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAccountID))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi lại cho chắc ăn (Cực kỳ quan trọng với nghiệp vụ Xóa)
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa vĩnh viễn tài khoản [{txt_TenTK.Text}] không?",
                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    try
                    {
                        // Tìm tài khoản cần xóa
                        var accToDelete = db.Accounts.SingleOrDefault(a => a.AccountID == selectedAccountID);

                        if (accToDelete != null)
                        {
                            // Ra lệnh xóa
                            db.Accounts.DeleteOnSubmit(accToDelete);
                            db.SubmitChanges(); // Đẩy lệnh xuống SQL

                            MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh lại form
                            clearInputFields();
                            LoadData();
                            LoadThongKe();
                            LoadChart();
                        }
                    }
                    // BẮT BỆNH KHÓA NGOẠI: Nếu tài khoản này đã từng có giao dịch Thu/Chi
                    catch (System.Data.SqlClient.SqlException sqlEx)
                    {
                        // Mã lỗi 547 của SQL Server là lỗi vi phạm Ràng buộc Khóa ngoại (Foreign Key)
                        if (sqlEx.Number == 547)
                        {
                            MessageBox.Show("Không thể xóa tài khoản này vì nó đã có phát sinh Giao dịch (Thu/Chi)!\n\nNếu không dùng nữa, bạn nên giữ nguyên để đảm bảo lịch sử thống kê.",
                                            "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi SQL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void RefreshTaiKhoan()
        {
            LoadChart();
            LoadData();
            LoadThongKe();
        }

        private void clearInputFields()
        {
            txt_TenTK.Clear();
            txt_SoDu.Clear();
            cbo_LoaiTK.SelectedIndex = 0;
            txt_TenNH.Clear();
            txt_SoDu.Enabled = true;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearInputFields();
            txt_TenTK.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMenu = Application.OpenForms.OfType<FrmMainMenu>().FirstOrDefault();
            if (frmMenu != null)
            {
                frmMenu.RefreshMenu();
            }

            FrmThongKe frmThongKe = Application.OpenForms.OfType<FrmThongKe>().FirstOrDefault();
            if (frmThongKe != null)
            {
                frmThongKe.RefreshThongKe();
            }

            this.Close();
        }

        private void cbo_LoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_LoaiTK.SelectedItem.ToString() == "Cash" || cbo_LoaiTK.SelectedItem.ToString() == "Creadit Card")
            {
                txt_TenNH.Enabled = false;
                txt_TenNH.Text = "";
            }
            else
            {
                txt_TenNH.Enabled = true;
            }
        }
    }
}
