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

namespace Project_FinancePersonalManagement
{
    public partial class Form_Menu : Form
    {
        private string currentUserID;
        private string currentUserName;
        private bool isLoggedIn = false;

        public Form_Menu()
        {
            InitializeComponent();
        }

        // Bật/Tắt menu
        private void ToggleMenu(bool status)
        {
            thốngKêToolStripMenuItem.Enabled = status;
            tàiKhoànToolStripMenuItem.Enabled = status;
            giaoDịchToolStripMenuItem.Enabled = status;
            khoảnNợKhoànVayToolStripMenuItem.Enabled = status;
            danhMụcToolStripMenuItem.Enabled = status;
            ngânSáchToolStripMenuItem.Enabled = status;

            đăngXuấtToolStripMenuItem.Visible = status;

            đăngNhậpToolStripMenuItem.Visible = !status;
            đăngKíToolStripMenuItem.Visible = !status;
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            // Khi form mới mở lên: Tắt hết menu, hiện trạng thái chưa đăng nhập
            ToggleMenu(false);
            lblUser.Text = "Chưa đăng nhập";
            lblStatus.Text = "Cơ sở dữ liệu: Chưa kết nối";
            time_clock.Start();
        }

        private void LoadDashboard()
        {
            // Mở kết nối CSDL bằng LINQ
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    // Lấy tháng và năm hiện tại của hệ thống để lọc dữ liệu
                    int currentMonth = DateTime.Now.Month;
                    int currentYear = DateTime.Now.Year;

                    // TÍNH TỔNG SỐ DƯ (Tất cả các ví/tài khoản của user này)
                    // Dùng (decimal?) để ép kiểu, phòng trường hợp user chưa có tài khoản nào thì Sum trả về null -> sẽ đổi thành 0
                    decimal totalBalance = db.Accounts
                                             .Where(a => a.UserID == currentUserID)
                                             .Sum(a => (decimal?)a.Balance) ?? 0;

                    // TÍNH TỔNG THU
                    decimal totalIncome = db.Transactions
                                            .Where(t => t.UserID == currentUserID
                                                     && t.TransType == "Income"
                                                     && t.TransDate.Value.Month == currentMonth
                                                     && t.TransDate.Value.Year == currentYear)
                                            .Sum(t => (decimal?)t.Amount) ?? 0;

                    // TÍNH TỔNG CHI
                    decimal totalExpense = db.Transactions
                                             .Where(t => t.UserID == currentUserID
                                                      && t.TransType == "Expense"
                                                      && t.TransDate.Value.Month == currentMonth
                                                      && t.TransDate.Value.Year == currentYear)
                                             .Sum(t => (decimal?)t.Amount) ?? 0;

                    // load DỮ LIỆU LÊN GIAO DIỆN 
                    lblTotalBalance.Text = totalBalance.ToString("N0") + " VNĐ";
                    lblTotalIncome.Text = totalIncome.ToString("N0") + " VNĐ";
                    lblTotalExpense.Text = totalExpense.ToString("N0") + " VNĐ";

                    // Dùng phép "Select" và tạo ra một object ẩn danh (anonymous type) để tự động đặt tên cột tiếng Việt cho đẹp
                    var accountList = db.Accounts
                                        .Where(a => a.UserID == currentUserID)
                                        .Select(a => new
                                        {
                                            TenTaiKhoan = a.AccountName,
                                            Loai = a.AccountType,
                                            SoDu = a.Balance,
                                            ChiTiet = a.BankDetail
                                        })
                                        .ToList();

                    // Gán dữ liệu vào DataGridView
                    dgv_Accounts.DataSource = accountList;

                    // Trang trí lại DataGridView
                    if (dgv_Accounts.Columns.Count > 0)
                    {
                        dgv_Accounts.Columns["TenTaiKhoan"].HeaderText = "Tên tài khoản";
                        dgv_Accounts.Columns["Loai"].HeaderText = "Phân loại";

                        // Định dạng cột số dư có dấu phẩy tiền tệ
                        dgv_Accounts.Columns["SoDu"].HeaderText = "Số dư (VNĐ)";
                        dgv_Accounts.Columns["SoDu"].DefaultCellStyle.Format = "N0";

                        dgv_Accounts.Columns["ChiTiet"].HeaderText = "Chi tiết";

                        // Ép cột Tên tài khoản tự động giãn rộng lấp đầy khoảng trống
                        dgv_Accounts.Columns["TenTaiKhoan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        LoadChart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu Dashboard: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadChart()
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    int currentMonth = DateTime.Now.Month;
                    int currentYear = DateTime.Now.Year;

                    //  Dùng LINQ kết hợp (JOIN) bảng Transactions và Categories, sau đó Gom nhóm (GROUP BY)
                    var expenseData = (from t in db.Transactions
                                       join c in db.Categories on t.CategoryID equals c.CategoryID
                                       where t.UserID == currentUserID
                                          && t.TransType == "Expense"
                                          && t.TransDate.Value.Month == currentMonth
                                          && t.TransDate.Value.Year == currentYear
                                       group t by c.CategoryName into g
                                       select new
                                       {
                                           TenDanhMuc = g.Key,
                                           TongTien = g.Sum(x => x.Amount)
                                       }).ToList();

                    // Cấu hình xóa dữ liệu cũ của biểu đồ (nếu có)
                    chartChiTieu.Series.Clear();
                    chartChiTieu.Titles.Clear();

                    // Thêm tiêu đề cho biểu đồ
                    chartChiTieu.Titles.Add($"Cơ cấu chi tiêu tháng {currentMonth}/{currentYear}");
                    chartChiTieu.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

                    // Tạo luồng dữ liệu mới (Series)
                    Series series = chartChiTieu.Series.Add("ChiTieuSeries");
                    series.ChartType = SeriesChartType.Doughnut;

                    // hiển thị phần trăm trên biểu đồ
                    series.Label = "#PERCENT{P0}";

                    // Khi chỉ còn số %, đưa nó vào TRONG miếng bánh nhìn sẽ gọn và sang hơn
                    series["PieLabelStyle"] = "Inside";
                    series.Font = new Font("Arial", 9, FontStyle.Bold);
                    series.LabelForeColor = Color.White;

                    // CHỈ HIỆN TÊN DANH MỤC Ở CHÚ THÍCH (Legend)
                    // Khóa thuộc tính này lại để chú thích không bị ăn theo cái Label % ở trên
                    series.LegendText = "#VALX";

                    // Đổ dữ liệu từ LINQ vào biểu đồ
                    foreach (var item in expenseData)
                    {
                        // Thêm dữ liệu và lấy ra vị trí (index) của miếng bánh vừa thêm
                        int pointIndex = series.Points.AddXY(item.TenDanhMuc, item.TongTien);

                        DataPoint point = series.Points[pointIndex];
                        point.ToolTip = $"Tổng chi {item.TenDanhMuc}: {item.TongTien:N0} VNĐ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải biểu đồ: " + ex.Message);
                }
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formLogin = new form_Sign_In();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                // Nhận dữ liệu
                currentUserID = ((form_Sign_In)formLogin).LoggedInUserID;
                currentUserName = ((form_Sign_In)formLogin).LoggedInUserName;
                isLoggedIn = true;

                //  Cập nhật giao diện
                lblUser.Text = $"Xin chào: {currentUserID} - {currentUserName}";
                lblStatus.Text = "Cơ sở dữ liệu: Đã kết nối";

                // Mở khóa các menu
                ToggleMenu(true);

                // LOAD DỮ LIỆU LÊN DASHBOARD
                LoadDashboard(); 
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void time_clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSignUp = new form_Sign_Up();
            formSignUp.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi đăng xuất
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi tài khoản này?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa thông tin phiên làm việc
                currentUserID = null;
                currentUserName = null;
                isLoggedIn = false;

                // Tắt các menu tính năng
                ToggleMenu(false);

                // Reset lại thanh StatusStrip
                lblUser.Text = "Chưa đăng nhập";
                lblStatus.Text = "Cơ sở dữ liệu: Đã ngắt kết nối";

                // XÓA SẠCH DỮ LIỆU TRÊN DASHBOARD (Tránh người sau nhìn thấy)
                lblTotalBalance.Text = "0 VNĐ";
                lblTotalIncome.Text = "0 VNĐ";
                lblTotalExpense.Text = "0 VNĐ";

                dgv_Accounts.DataSource = null; // Xóa bảng
                chartChiTieu.Series.Clear();   // Xóa biểu đồ
                chartChiTieu.Titles.Clear();
            }
        }

        public void RefreshMenu()
        {
            LoadChart();
            LoadDashboard();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formThongKe = new form_ThongKe(currentUserID);
            formThongKe.ShowDialog();
        }

        private void tàiKhoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTaiKhoan = new form_TaiKhoan(currentUserID);
            formTaiKhoan.ShowDialog();
        }

        private void giaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formGiaoDich = new form_GiaoDich(currentUserID);
            formGiaoDich.ShowDialog();
        }

        private void khoảnNợKhoànVayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formVay = new form_KhoanVay_ChoVay(currentUserID);
            formVay.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formDanhMuc = new frm_danhMuc(currentUserID);
            formDanhMuc.ShowDialog();
        }

        private void ngânSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formNganSach = new frm_nganSach(currentUserID);
            formNganSach.ShowDialog();
        }
    }
}
