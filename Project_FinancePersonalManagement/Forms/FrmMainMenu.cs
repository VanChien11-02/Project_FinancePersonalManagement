using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project_FinancePersonalManagement.Data;
using Project_FinancePersonalManagement.Properties;

namespace Project_FinancePersonalManagement
{
    public partial class FrmMainMenu : Form
    {
        private string currentUserID;
        private string currentUserName;
        private bool isLoggedIn = false;
        private Button _activeNav;

        // NEW: giữ trạng thái tháng đang xem trên Dashboard
        private DateTime currentViewDate;

        public FrmMainMenu()
        {
            InitializeComponent();
            Image originalImage = Properties.Resources.ic_settings;

            Bitmap resizedImage = new Bitmap(originalImage, new Size(30, 30));
            btnNav_Settings.Image = resizedImage;

            btnNav_Settings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNav_Settings.TextAlign = ContentAlignment.MiddleLeft;
            btnNav_Settings.ImageAlign = ContentAlignment.MiddleLeft;

            //btnNav_Settings.Padding = new Padding(10, 0, 0, 0);
        }

        //  LOAD / RESIZE
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            ToggleSidebarFeatures(false);
            lblStatus.Text = "Sẵn sàng - chưa đăng nhập";
            time_clock.Start();
            _activeNav = btnNav_Overview;
            PositionUserChip();

            // KHỞI TẠO trạng thái xem: mặc định là tháng hiện tại
            currentViewDate = DateTime.Now;
            lblMonthYear.Text = "Tháng " + currentViewDate.ToString("MM/yyyy");
        }

        private void Form_Menu_Resize(object sender, EventArgs e)
        {
            PositionUserChip();
        }

        private void PositionUserChip()
        {
            pnlUserChip.Location = new Point(
                pnlTopbar.Width - pnlUserChip.Width - 4, 8);
        }

        //  PAINT – stat card border
        private void StatCard_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var panel = (Panel)sender;
            using (var pen = new Pen(Color.FromArgb(220, 220, 220), 1f))
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
        }

        //  SIDEBAR HELPERS
        private void ToggleSidebarFeatures(bool enabled)
        {
            btnNav_GiaoDich.Enabled = enabled;
            btnNav_TaiKhoan.Enabled = enabled;
            btnNav_ThongKe.Enabled = enabled;
            btnNav_NganSach.Enabled = enabled;
            btnNav_KhoanVay.Enabled = enabled;
            btnNav_DanhMuc.Enabled = enabled;
            btnNav_Overview.Enabled = enabled;

            btnNav_DangXuat.Visible = enabled;
            btnNav_DangNhap.Visible = !enabled;
            btnNav_DangKy.Visible = !enabled;

            Color disabledFg = Color.FromArgb(190, 190, 190);
            Color enabledFg = Color.FromArgb(70, 70, 70);
            foreach (Button btn in new[] {
                btnNav_GiaoDich, btnNav_TaiKhoan, btnNav_ThongKe,
                btnNav_NganSach, btnNav_KhoanVay, btnNav_DanhMuc, btnNav_Overview })
            {
                btn.ForeColor = enabled ? enabledFg : disabledFg;
            }
        }

        private void SetActiveNav(Button btn)
        {
            if (_activeNav != null)
            {
                _activeNav.BackColor = Color.White;
                _activeNav.ForeColor = Color.FromArgb(70, 70, 70);
                _activeNav.Font = new Font("Segoe UI", 9.5f);
            }
            _activeNav = btn;
            btn.BackColor = Color.FromArgb(232, 242, 253);
            btn.ForeColor = Color.FromArgb(24, 95, 165);
            btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        //  DASHBOARD
        // Wrapper để tương thích các chỗ gọi cũ
        private void LoadDashboard()
        {
            if (currentViewDate == default(DateTime))
                currentViewDate = DateTime.Now;
            LoadDashboardData(currentViewDate);
        }

        // NEW: Hàm tải dữ liệu Dashboard theo tháng/năm được truyền vào
        private void LoadDashboardData(DateTime date)
        {
            btn_MonthYear.Text = "Tháng " + date.ToString("MM/yyyy");

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    int m = date.Month, y = date.Year;

                    // TÍNH TỔNG SỐ DƯ (Tất cả các ví/tài khoản của user này)
                    decimal totalBalance = db.Accounts
                        .Where(a => a.UserID == currentUserID)
                        .Sum(a => (decimal?)a.Balance) ?? 0;

                    // TÍNH TỔNG THU trong tháng
                    decimal totalIncome = db.Transactions
                        .Where(t => t.UserID == currentUserID
                                 && t.TransType == "Income"
                                 && t.TransDate.HasValue
                                 && t.TransDate.Value.Month == m
                                 && t.TransDate.Value.Year == y)
                        .Sum(t => (decimal?)t.Amount) ?? 0;

                    // TÍNH TỔNG CHI trong tháng
                    decimal totalExpense = db.Transactions
                        .Where(t => t.UserID == currentUserID
                                 && t.TransType == "Expense"
                                 && t.TransDate.HasValue
                                 && t.TransDate.Value.Month == m
                                 && t.TransDate.Value.Year == y)
                        .Sum(t => (decimal?)t.Amount) ?? 0;

                    lblTotalBalance.Text = totalBalance.ToString("N0") + " VNĐ";
                    lblTotalIncome.Text = totalIncome.ToString("N0") + " VNĐ";
                    lblTotalExpense.Text = totalExpense.ToString("N0") + " VNĐ";

                    int incomeCount = db.Transactions.Count(t =>
                        t.UserID == currentUserID && t.TransType == "Income"
                        && t.TransDate.HasValue && t.TransDate.Value.Month == m && t.TransDate.Value.Year == y);

                    int expenseCount = db.Transactions.Count(t =>
                        t.UserID == currentUserID && t.TransType == "Expense"
                        && t.TransDate.HasValue && t.TransDate.Value.Month == m && t.TransDate.Value.Year == y);

                    // Hiển thị trạng thái và đổi màu nếu tháng đó bị âm (chi > thu)
                    decimal monthNet = totalIncome - totalExpense;
                    if (incomeCount == 0 && expenseCount == 0)
                    {
                        lblChangeBalance.Text = "Chưa có giao dịch trong tháng";
                        lblChangeBalance.ForeColor = Color.FromArgb(70, 70, 70);
                    }
                    else
                    {
                        lblChangeBalance.Text = (monthNet >= 0)
                            ? "Thặng dư tháng: " + monthNet.ToString("N0") + " VNĐ"
                            : "Thâm hụt tháng: " + Math.Abs(monthNet).ToString("N0") + " VNĐ";

                        lblChangeBalance.ForeColor = monthNet < 0 ? Color.Red : Color.FromArgb(70, 70, 70);
                    }

                    lblChangeIncome.Text = incomeCount > 0 ? incomeCount + " giao dịch thu tháng " + m : "Chưa có thu nhập";
                    lblChangeExpense.Text = expenseCount > 0 ? expenseCount + " giao dịch chi tháng " + m : "Chưa có chi tiêu";

                    var accountList = db.Accounts
                        .Where(a => a.UserID == currentUserID)
                        .Select(a => new {
                            TenTaiKhoan = a.AccountName,
                            Loai = a.AccountType,
                            SoDu = a.Balance,
                            ChiTiet = a.BankDetail
                        }).ToList();

                    dgv_Accounts.DataSource = accountList;

                    if (dgv_Accounts.Columns.Count > 0)
                    {
                        dgv_Accounts.Columns["TenTaiKhoan"].HeaderText = "Tên tài khoản";
                        dgv_Accounts.Columns["Loai"].HeaderText = "Phân loại";
                        dgv_Accounts.Columns["SoDu"].HeaderText = "Số dư (VNĐ)";
                        dgv_Accounts.Columns["SoDu"].DefaultCellStyle.Format = "N0";
                        dgv_Accounts.Columns["SoDu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv_Accounts.Columns["ChiTiet"].HeaderText = "Chi tiết";
                        dgv_Accounts.Columns["TenTaiKhoan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        // Tải lại biểu đồ theo tháng được chọn
                        LoadChart(date);
                    }

                    lblCardChartTitle.Text = "Cơ cấu chi tiêu - tháng " + m + "/" + y;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải Dashboard: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // MODIFIED: LoadChart nhận DateTime để lọc theo tháng/năm
        private void LoadChart(DateTime date)
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    int m = date.Month, y = date.Year;

                    var expenseData = (from t in db.Transactions
                                       join c in db.Categories on t.CategoryID equals c.CategoryID
                                       where t.UserID == currentUserID
                                          && t.TransType == "Expense"
                                          && t.TransDate.HasValue
                                          && t.TransDate.Value.Month == m
                                          && t.TransDate.Value.Year == y
                                       group t by c.CategoryName into g
                                       select new
                                       {
                                           TenDanhMuc = g.Key,
                                           TongTien = g.Sum(x => x.Amount)
                                       }).ToList();

                    chartChiTieu.Series.Clear();
                    chartChiTieu.Titles.Clear();
                    chartChiTieu.ChartAreas[0].BackColor = Color.Transparent;
                    chartChiTieu.BackColor = Color.Transparent;
                    chartChiTieu.Legends[0].BackColor = Color.Transparent;
                    chartChiTieu.Legends[0].BorderColor = Color.Transparent;


                    Series series = chartChiTieu.Series.Add("ChiTieuSeries");
                    series.ChartType = SeriesChartType.Doughnut;
                    series.Label = "#PERCENT{P0}";
                    series["PieLabelStyle"] = "Inside";
                    series["DoughnutRadius"] = "55";
                    series.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                    series.LabelForeColor = Color.White;
                    series.LegendText = "#VALX";

                    Color[] palette = {
                        Color.FromArgb(29, 158, 117),
                        Color.FromArgb(24, 95, 165),
                        Color.FromArgb(239, 159, 39),
                        Color.FromArgb(226, 75, 74),
                        Color.FromArgb(83, 74, 183),
                        Color.FromArgb(212, 85, 48)
                    };

                    int colorIdx = 0;
                    foreach (var item in expenseData)
                    {
                        int idx = series.Points.AddXY(item.TenDanhMuc, item.TongTien);
                        series.Points[idx].Color = palette[colorIdx % palette.Length];
                        series.Points[idx].ToolTip = item.TenDanhMuc + ": " + item.TongTien.ToString("N0") + " d";
                        colorIdx++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải biểu đồ: " + ex.Message);
                }
            }
        }

        //  NAV BUTTON CLICK HANDLERS (Tổng quan)
        private void btnNav_Overview_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnNav_Overview);
        }

        private void btnNav_DangNhap_Click(object sender, EventArgs e)
        {
            Form formLogin = new FrmLogin();
            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                currentUserID = ((FrmLogin)formLogin).LoggedInUserID;
                currentUserName = ((FrmLogin)formLogin).LoggedInUserName;
                isLoggedIn = true;

                lblAvatarInitials.Text = GetInitials(currentUserName);
                lblUserName.Text = currentUserName;
                lblStatus.Text = "Đã đăng nhập  -  " + currentUserID;

                ToggleSidebarFeatures(true);
                SetActiveNav(btnNav_Overview);

                // Khi đăng nhập đặt lại ngày xem về tháng hiện tại
                currentViewDate = DateTime.Now;
                LoadDashboardData(currentViewDate);
            }
        }

        private void btnNav_DangKy_Click(object sender, EventArgs e)
        {
            new FrmRegister().ShowDialog();
        }

        private void btnNav_DangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có muốn đăng xuất không", "Đăng xuất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                currentUserID = null;
                currentUserName = null;
                isLoggedIn = false;

                lblAvatarInitials.Text = "--";
                lblUserName.Text = "Chưa đăng nhập";
                lblStatus.Text = "Sẵn sàng  -  Đã đăng xuất";

                ToggleSidebarFeatures(false);
                SetActiveNav(btnNav_Overview);

                lblTotalBalance.Text = "0 VNĐ";
                lblTotalIncome.Text = "0 VNĐ";
                lblTotalExpense.Text = "0 VNĐ";
                lblChangeBalance.Text = "";
                lblChangeIncome.Text = "";
                lblChangeExpense.Text = "";
                dgv_Accounts.DataSource = null;
                chartChiTieu.Series.Clear();
                chartChiTieu.Titles.Clear();
            }
        }

        private void btnNav_Thoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnNav_GiaoDich_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnNav_GiaoDich);
            new FrmGiaoDich(currentUserID).ShowDialog();
            SetActiveNav(btnNav_Overview);
            LoadDashboard(); // vẫn tương thích; LoadDashboard sẽ dùng currentViewDate
        }

        private void btnNav_TaiKhoan_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnNav_TaiKhoan);
            new FrmTaiKhoan(currentUserID).ShowDialog();
            SetActiveNav(btnNav_Overview);
            LoadDashboard();
        }

        private void btnNav_ThongKe_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnNav_ThongKe);
            new FrmThongKe(currentUserID).ShowDialog();
            SetActiveNav(btnNav_Overview);
        }

        private void btnNav_NganSach_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnNav_NganSach);
            new FrmNganSach(currentUserID).ShowDialog();
            SetActiveNav(btnNav_Overview);
        }

        private void btnNav_KhoanVay_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnNav_KhoanVay);
            new FrmVayNo(currentUserID).ShowDialog();
            SetActiveNav(btnNav_Overview);
        }

        private void btnNav_DanhMuc_Click(object sender, EventArgs e)
        {
            SetActiveNav(btnNav_DanhMuc);
            new FrmDanhMuc(currentUserID).ShowDialog();
            SetActiveNav(btnNav_Overview);
            LoadDashboard();
        }

        //  TIMER
        private void time_clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
        }

        //  PUBLIC REFRESH
        public void RefreshMenu()
        {
            LoadDashboard();
        }

        //  HELPERS (hiển thị tên viết tắt trên avatar)
        private static string GetInitials(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "--";
            var parts = name.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 1)
                return parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpper();
            return (parts[0][0].ToString() + parts[parts.Length - 1][0]).ToUpper();
        }

        // NEW: Sự kiện cho các nút mũi tên (người dùng sẽ thêm Button và gán event này)
        // Gợi ý: đặt tên button là btnPrevMonth và btnNextMonth, và gán event handlers bên dưới.
        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            currentViewDate = currentViewDate.AddMonths(-1);
            LoadDashboardData(currentViewDate);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            currentViewDate = currentViewDate.AddMonths(1);
            LoadDashboardData(currentViewDate);
        }
    }
}