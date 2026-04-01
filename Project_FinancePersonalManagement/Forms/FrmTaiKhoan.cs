using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmTaiKhoan : Form
    {
        private string currentUserID;
        private string selectedAccountID;

        private static readonly Color C_Green = Color.FromArgb(15, 110, 80);
        private static readonly Color C_Blue = Color.FromArgb(24, 95, 165);
        private static readonly Color C_Red = Color.FromArgb(163, 45, 45);
        private static readonly Color C_Amber = Color.FromArgb(180, 110, 20);
        private static readonly Color C_Border = Color.FromArgb(220, 220, 220);

        // Modern chart palette
        private static readonly Color[] ChartPalette = {
            Color.FromArgb(24,  95,  165),
            Color.FromArgb(15, 110,  80),
            Color.FromArgb(180,110,  20),
            Color.FromArgb(83,  74, 183),
            Color.FromArgb(163, 45,  45),
            Color.FromArgb(212, 85,  48),
        };

        public FrmTaiKhoan(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
        }

        //  PAINT HANDLERS
        private void TopBar_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
                e.Graphics.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
        }

        private void StatCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
            // Colored left accent bar
            Color accent = p == panel1 ? C_Green
                         : p == panel2 ? C_Blue
                         : p == panel3 ? C_Red
                         : C_Amber;
            using (var br = new SolidBrush(accent))
                e.Graphics.FillRectangle(br, 0, 0, 4, p.Height);
        }

        //  LOAD / RESIZE
        private void form_TaiKhoan_Load(object sender, EventArgs e)
        {
            PositionCloseButton();
            LoadThongKe();
            LoadData();
            LoadChart();
        }

        private void FrmTaiKhoan_Resize(object sender, EventArgs e)
        {
            PositionCloseButton();
            // Keep stat cards square-ish: each ~half the right panel width
            int halfW = (pnlStatStack.Width - 12) / 2;
            if (halfW > 80)
            {
                panel1.Width = halfW;
                panel3.Width = halfW;
            }
        }

        private void PositionCloseButton()
        {
            btn_Thoat.Location = new Point(pnlLeftHeader.Width - btn_Thoat.Width - 16, 12);
        }

        //  DATA LOADING
        public void LoadData()
        {
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
                    var dsTaiKhoan = db.Accounts
                        .Where(a => a.UserID == currentUserID)
                        .Select(a => new {
                            MaTK = a.AccountID,
                            TenTK = a.AccountName,
                            LoaiTK = a.AccountType,
                            SoDu = a.Balance,
                            NganHang = a.BankDetail
                        }).ToList();

                    dgvTaiKhoan.DataSource = dsTaiKhoan;

                    if (dgvTaiKhoan.Columns.Count > 0)
                    {
                        dgvTaiKhoan.Columns["MaTK"].HeaderText = "Mã tài khoản";
                        dgvTaiKhoan.Columns["TenTK"].HeaderText = "Tên tài khoản";
                        dgvTaiKhoan.Columns["LoaiTK"].HeaderText = "Loại";

                        dgvTaiKhoan.Columns["SoDu"].HeaderText = "Số dư (VNĐ)";
                        dgvTaiKhoan.Columns["SoDu"].DefaultCellStyle.Format = "N0"; // Định dạng phân cách hàng nghìn

                        dgvTaiKhoan.Columns["SoDu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvTaiKhoan.Columns["NganHang"].HeaderText = "Ngân hàng/Ví";
                        dgvTaiKhoan.Columns["TenTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    // Color rows by account type
                    foreach (DataGridViewRow row in dgvTaiKhoan.Rows)
                    {
                        if (row.Cells["LoaiTK"].Value == null) continue;
                        string loai = row.Cells["LoaiTK"].Value.ToString();
                        row.DefaultCellStyle.ForeColor = loai == "Bank" ? C_Blue
                                                        : loai == "E-Wallet" ? C_Green
                                                        : loai == "Creadit Card" ? C_Red
                                                        : Color.FromArgb(50, 50, 50);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách tài khoản: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadThongKe()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    var accs = db.Accounts.Where(a => a.UserID == currentUserID).ToList();
                    if (accs.Count > 0)
                    {
                        decimal tong = accs.Sum(a => (decimal)a.Balance);
                        decimal tb = accs.Average(a => (decimal)a.Balance);
                        decimal min = accs.Min(a => (decimal)a.Balance);
                        decimal max = accs.Max(a => (decimal)a.Balance);

                        lblTongSoDu.Text = tong.ToString("N0") + " VNĐ";
                        lblSoDuTB.Text = tb.ToString("N0") + " VNĐ";
                        lblSoDuMin.Text = min.ToString("N0") + " VNĐ";
                        lblSoDuMax.Text = max.ToString("N0") + " VNĐ";
                        lblSubTong.Text = accs.Count + " tai khoan";
                        lblSubTB.Text = "Mọi tài khoản";
                        lblSubMin.Text = "Tài khoản ít nhất";
                        lblSubMax.Text = "Tài khoản nhiều nhất";
                    }
                    else
                    {
                        lblTongSoDu.Text = lblSoDuTB.Text = lblSoDuMin.Text = lblSoDuMax.Text = "0 VNĐ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải thống kê: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadChart()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Chỉ lấy các tài khoản có số dư > 0 (Vì ví 0 đồng thì không thể vẽ lên miếng bánh được)
                    var chartData = db.Accounts
                        .Where(a => a.UserID == currentUserID && a.Balance > 0)
                        .Select(a => new { TenTK = a.AccountName, SoDu = a.Balance })
                        .ToList();

                    // Dọn dẹp dữ liệu cũ của biểu đồ
                    chartCoCau.Series.Clear();
                    chartCoCau.Titles.Clear();

                    chartCoCau.BackColor = Color.Transparent;
                    chartCoCau.ChartAreas[0].BackColor = Color.Transparent;
                    chartCoCau.ChartAreas[0].BorderWidth = 0;
                    chartCoCau.Legends[0].BackColor = Color.Transparent;
                    chartCoCau.Legends[0].Font = new Font("Segoe UI", 8.5f);
                    chartCoCau.Legends[0].Docking = Docking.Right;

                    if (chartData.Count == 0) return;

                    Series s = chartCoCau.Series.Add("SoDuSeries");
                    s.ChartType = SeriesChartType.Doughnut;
                    s.Label = "#PERCENT{P0}";
                    s["PieLabelStyle"] = "Inside";
                    s["DoughnutRadius"] = "55";
                    s.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                    s.LabelForeColor = Color.White;
                    s.LegendText = "#VALX";

                    int ci = 0;
                    foreach (var item in chartData)
                    {
                        int idx = s.Points.AddXY(item.TenTK, item.SoDu);
                        s.Points[idx].Color = ChartPalette[ci % ChartPalette.Length];
                        s.Points[idx].ToolTip = item.TenTK + ": " + item.SoDu.Value.ToString("N0") + " VNĐ";
                        ci++;
                    }

                    // Update chart card subtitle
                    lblChartTitle.Text = "Cơ cấu tài sản (" + chartData.Count + " ví)";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải biểu đồ: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //  GRID CELL CLICK
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
            selectedAccountID = row.Cells["MaTK"].Value.ToString();
            txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
            txt_SoDu.Text = row.Cells["SoDu"].Value?.ToString() ?? "0";

            object nganHang = row.Cells["NganHang"].Value;
            txt_TenNH.Text = (nganHang == null || nganHang == DBNull.Value) ? "" : nganHang.ToString();

            cbo_LoaiTK.SelectedItem = row.Cells["LoaiTK"].Value.ToString();
            txt_SoDu.Enabled = false;
        }

        //  CRUD
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenTK = txt_TenTK.Text.Trim();
            string loaiTK = cbo_LoaiTK.SelectedItem?.ToString() ?? "Cash";
            string nganHang = txt_TenNH.Text.Trim();

            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenTK.Focus();
                return;
            }

            if (!decimal.TryParse(txt_SoDu.Text.Trim(), out decimal soDu))
            {
                MessageBox.Show("Số dư phải là một con số hợp lệ!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoDu.Focus();
                return;
            }

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Kiểm tra xem User này đã có tài khoản nào trùng tên chưa (Không phân biệt hoa thường)
                    bool isDuplicate = db.Accounts.Any(a =>
                        a.UserID == currentUserID &&
                        a.AccountName.ToLower() == tenTK.ToLower());

                    if (isDuplicate)
                    {
                        MessageBox.Show("Tên tài khoản này đã tồn tại! Vui lòng đặt tên khác (VD: MB Bank 2, quỹ đen...)",
                                       "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_TenTK.Focus();
                        return;
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

                    Account newAcc = new Account
                    {
                        AccountID = newAccID,
                        UserID = currentUserID,
                        AccountName = tenTK,
                        AccountType = loaiTK,
                        Balance = soDu,

                        // Nếu là tiền mặt thì ép thành NULL cho chuẩn DB
                        BankDetail = (loaiTK == "Cash" || loaiTK == "Creadit Card") ? null : nganHang
                    };

                    db.Accounts.InsertOnSubmit(newAcc);
                    db.SubmitChanges();

                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearInputFields();
                    LoadData();
                    LoadThongKe();
                    LoadChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAccountID))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản từ danh sách để sửa!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTK = txt_TenTK.Text.Trim();
            string loaiTK = cbo_LoaiTK.SelectedItem?.ToString() ?? "Cash";
            string nganHang = txt_TenNH.Text.Trim();

            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!", "Cảnh báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    bool isDuplicate = db.Accounts.Any(a =>
                        a.UserID == currentUserID &&
                        a.AccountID != selectedAccountID &&
                        a.AccountName.ToLower() == tenTK.ToLower());

                    if (isDuplicate)
                    {
                        MessageBox.Show("Tên tài khoản này đã được sử dụng cho một ví khác! Vui lòng chọn tên khác.",
                                       "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_TenTK.Focus();
                        return;
                    }

                    var acc = db.Accounts.SingleOrDefault(a => a.AccountID == selectedAccountID);
                    if (acc != null)
                    {
                        acc.AccountName = tenTK;
                        acc.AccountType = loaiTK;
                        acc.BankDetail = (loaiTK == "Cash") ? null : nganHang;
                        db.SubmitChanges();

                        MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearInputFields();
                        LoadData();
                        LoadThongKe();
                        LoadChart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn tài khoản [" + txt_TenTK.Text + "] không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    try
                    {
                        var acc = db.Accounts.SingleOrDefault(a => a.AccountID == selectedAccountID);
                        if (acc != null)
                        {
                            db.Accounts.DeleteOnSubmit(acc);
                            db.SubmitChanges();

                            MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearInputFields();
                            LoadData();
                            LoadThongKe();
                            LoadChart();
                        }
                    }
                    catch (System.Data.SqlClient.SqlException sqlEx)
                    {
                        if (sqlEx.Number == 547)
                            MessageBox.Show("Không thể xóa tài khoản này vì nó đã có phát sinh Giao dịch (Thu/Chi)!\n\nNếu không dùng nữa, bạn nên giữ nguyên để đảm bảo lịch sử thống kê.",
                                           "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Lỗi SQL: " + sqlEx.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearInputFields();
            txt_TenTK.Focus();
        }

        private void clearInputFields()
        {
            selectedAccountID = null;
            txt_TenTK.Clear();
            txt_SoDu.Clear();
            txt_TenNH.Clear();
            txt_SoDu.Enabled = true;
            if (cbo_LoaiTK.Items.Count > 0)
                cbo_LoaiTK.SelectedIndex = 0;
        }

        //  COMBOBOX CHANGE
        private void cbo_LoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiTK.SelectedItem == null) return;
            string loai = cbo_LoaiTK.SelectedItem.ToString();
            bool needBank = (loai == "Bank" || loai == "E-Wallet");
            txt_TenNH.Enabled = needBank;
            if (!needBank) txt_TenNH.Text = "";
        }

        //  CLOSE / REFRESH
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMenu = Application.OpenForms.OfType<FrmMainMenu>().FirstOrDefault();
            if (frmMenu != null) frmMenu.RefreshMenu();

            FrmThongKe frmTK = Application.OpenForms.OfType<FrmThongKe>().FirstOrDefault();
            if (frmTK != null) frmTK.RefreshThongKe();

            this.Close();
        }

        public void RefreshTaiKhoan()
        {
            LoadChart();
            LoadData();
            LoadThongKe();
        }
    }
}