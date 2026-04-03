using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmNganSach : Form
    {
        private string currentUserId;
        private string currentBudgetID = "";

        // Tháng/năm đang lọc — điều khiển bởi nút ‹ ›
        private int filterMonth;
        private int filterYear;

        private static readonly Color[] BarColors = {
            Color.FromArgb(99,  102, 241),
            Color.FromArgb(139, 92,  246),
            Color.FromArgb(6,   182, 212),
            Color.FromArgb(16,  185, 129),
            Color.FromArgb(245, 158, 11),
            Color.FromArgb(239, 68,  68),
            Color.FromArgb(20,  184, 166),
        };

        public FrmNganSach(string UserID)
        {
            InitializeComponent();
            currentUserId = UserID;
            dgv_nganSach.CellFormatting += dgv_nganSach_CellFormatting;
        }

        // LOAD 
        private void frm_nganSach_Load(object sender, EventArgs e)
        {
            filterMonth = DateTime.Now.Month;
            filterYear = DateTime.Now.Year;

            cbo_ChartType.Items.Add("Cột (Column)");
            cbo_ChartType.Items.Add("Thanh ngang (Bar)");
            cbo_ChartType.Items.Add("Đường (Line)");
            cbo_ChartType.SelectedIndex = 0;

            UpdatePeriodDisplay();
            LoadComboBoxDanhMuc();
            LoadData();
            LoadChart();
            UpdateMetrics();
        }

        // Cập nhật hiển thị tháng/năm
        private void UpdatePeriodDisplay()
        {
            string s = $"Tháng {filterMonth} / {filterYear}";
            lbl_PeriodNav.Text = s;
            lbl_Period.Text = s;
            txt_thang.Text = filterMonth.ToString();
            txt_nam.Text = filterYear.ToString();
        }

        // Nút tháng trước 
        private void btn_PrevMonth_Click(object sender, EventArgs e)
        {
            filterMonth--;
            if (filterMonth < 1) { filterMonth = 12; filterYear--; }
            UpdatePeriodDisplay();
            LoadData();
            LoadChart();
            UpdateMetrics();
        }

        //  Nút tháng sau 
        private void btn_NextMonth_Click(object sender, EventArgs e)
        {
            filterMonth++;
            if (filterMonth > 12) { filterMonth = 1; filterYear++; }
            UpdatePeriodDisplay();
            LoadData();
            LoadChart();
            UpdateMetrics();
        }

        // LOAD COMBOBOX 
        void LoadComboBoxDanhMuc()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var list = db.Categories.Where(c => c.UserID == currentUserId && c.CategoryType == "Expense").ToList();

                cbo_DanhMuc.DataSource = list;
                cbo_DanhMuc.DisplayMember = "CategoryName";
                cbo_DanhMuc.ValueMember = "CategoryID";
            }
        }

        //  LOAD BẢNG — lọc theo filterMonth/filterYear 
        void LoadData()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    var data = (from b in db.Budgets
                                join c in db.Categories on b.CategoryID equals c.CategoryID
                                where b.UserID == currentUserId
                                   && b.Month == filterMonth
                                   && b.Year == filterYear
                                orderby c.CategoryName
                                select new
                                {
                                    BudgetID = b.BudgetID,
                                    CategoryID = b.CategoryID,
                                    CategoryName = c.CategoryName,
                                    Amount = b.Amount,
                                    Month = b.Month,
                                    Year = b.Year
                                }).ToList();

                    dgv_nganSach.DataSource = data;

                    if (dgv_nganSach.Columns.Count > 0)
                    {
                        dgv_nganSach.Columns["BudgetID"].Visible = false;
                        dgv_nganSach.Columns["CategoryID"].Visible = false;

                        dgv_nganSach.Columns["CategoryName"].HeaderText = "DANH MỤC";
                        dgv_nganSach.Columns["CategoryName"].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                        dgv_nganSach.Columns["Amount"].HeaderText = "SỐ TIỀN (VNĐ)";
                        dgv_nganSach.Columns["Amount"].DefaultCellStyle.Format = "N0";
                        //dgv_nganSach.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv_nganSach.Columns["Amount"].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                        dgv_nganSach.Columns["Amount"].DefaultCellStyle.ForeColor = Color.FromArgb(55, 48, 163);

                        dgv_nganSach.Columns["Month"].HeaderText = "THÁNG";
                        dgv_nganSach.Columns["Month"].Width = 70;
                        //dgv_nganSach.Columns["Month"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dgv_nganSach.Columns["Year"].HeaderText = "NĂM";
                        dgv_nganSach.Columns["Year"].Width = 70;
                        dgv_nganSach.Columns["Year"].DefaultCellStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    }

                    lbl_RowCount.Text = $"{data.Count} mục";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //  LOAD BIỂU ĐỒ — lọc theo filterMonth/filterYear 
        void LoadChart()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    var data = (from b in db.Budgets
                                join c in db.Categories on b.CategoryID equals c.CategoryID
                                where b.UserID == currentUserId
                                   && b.Month == filterMonth
                                   && b.Year == filterYear
                                group b by c.CategoryName into g
                                select new
                                {
                                    CategoryName = g.Key,
                                    TotalAmount = g.Sum(x => x.Amount)
                                }).ToList();

                    budgetChart.Series.Clear();

                    SeriesChartType chartType = SeriesChartType.Column;
                    switch (cbo_ChartType.SelectedIndex)
                    {
                        case 1: chartType = SeriesChartType.Bar; break;
                        case 2: chartType = SeriesChartType.Line; break;
                    }

                    Series s = new Series("Ngân sách");
                    s.ChartType = chartType;
                    s.IsValueShownAsLabel = true;
                    s.LabelFormat = "N0";
                    s.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
                    s.LabelForeColor = Color.FromArgb(55, 48, 163);
                    if(chartType == SeriesChartType.Column)
                    {
                        s["PixelPointWidth"] = "45"; // Tránh cột bị phình to
                    }

                    for (int i = 0; i < data.Count; i++)
                    {
                        int idx = s.Points.AddXY(data[i].CategoryName, data[i].TotalAmount);
                        s.Points[idx].Color = BarColors[i % BarColors.Length];
                        s.Points[idx].ToolTip = $"{data[i].CategoryName}: {data[i].TotalAmount:N0} VNĐ";
                    }

                    budgetChart.Series.Add(s);
                    budgetChart.ChartAreas[0].AxisY.LabelStyle.Format = "N0";
                }
                catch { }
            }
        }

        //  METRIC CARDS — lọc theo filterMonth/filterYear 
        void UpdateMetrics()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    var budgets = db.Budgets
                        .Where(b => b.UserID == currentUserId
                                 && b.Month == filterMonth
                                 && b.Year == filterYear)
                        .ToList();

                    if (budgets.Count > 0)
                    {
                        decimal total = budgets.Sum(b => (decimal)b.Amount);
                        lblTongSoDu.Text = total.ToString("N0") + " VNĐ";

                        string topCatId = budgets
                            .GroupBy(b => b.CategoryID)
                            .OrderByDescending(g => g.Sum(b => (decimal)b.Amount))
                            .Select(g => g.Key)
                            .FirstOrDefault();

                        if (topCatId != null)
                        {
                            var cat = db.Categories.FirstOrDefault(c => c.CategoryID == topCatId);
                            lbl_MTopVal.Text = cat != null ? cat.CategoryName : "—";
                        }

                        int countCat = budgets.Select(b => b.CategoryID).Distinct().Count();
                        lbl_MCountVal.Text = countCat.ToString();
                    }
                    else
                    {
                        lblTongSoDu.Text = "0 VNĐ";
                        lbl_MTopVal.Text = "—";
                        lbl_MCountVal.Text = "0";
                    }
                }
                catch { }
            }
        }

        // CellFormatting 
        private void dgv_nganSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_nganSach.Columns[e.ColumnIndex].Name != "Month") return;
            if (e.Value == null) return;
            e.CellStyle.BackColor = Color.FromArgb(238, 242, 255);
            e.CellStyle.ForeColor = Color.FromArgb(55, 48, 163);
            e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        //  Đổi loại biểu đồ 
        private void cbo_ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChart();
        }

        // THÊM
        private void btn_them_Click(object sender, EventArgs e)
        {
            string Tien = txt_soTien.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            if (cbo_DanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Danh mục!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!decimal.TryParse(Tien, out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!int.TryParse(txt_thang.Text.Trim(), out int thang) || thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng phải từ 1 đến 12!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!int.TryParse(txt_nam.Text.Trim(), out int nam) || nam < 2000)
            {
                MessageBox.Show("Năm không hợp lệ (>= 2000)!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            string maDM = cbo_DanhMuc.SelectedValue.ToString();

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                if (db.Budgets.Any(b => b.UserID == currentUserId
                                     && b.CategoryID == maDM
                                     && b.Month == thang
                                     && b.Year == nam))
                {
                    MessageBox.Show("Danh mục này đã có ngân sách trong tháng/năm này!",
                        "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }

                string newBudgetID = "B001";
                var listIDs = db.Budgets.Where(b => b.BudgetID.StartsWith("B")).Select(b => b.BudgetID).ToList();
                if (listIDs.Count > 0)
                {
                    int maxNum = listIDs.Max(id => int.TryParse(id.Substring(3), out int num) ? num : 0);
                    newBudgetID = "B" + (maxNum + 1).ToString("D3");
                }

                db.Budgets.InsertOnSubmit(new Budget
                {
                    BudgetID = newBudgetID,
                    UserID = currentUserId,
                    CategoryID = maDM,
                    Amount = soTien,
                    Month = thang,
                    Year = nam
                });
                db.SubmitChanges();

                MessageBox.Show("Thêm ngân sách thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_reset_Click(null, null);
                LoadData(); LoadChart(); UpdateMetrics();
            }
        }

        // SỬA 
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string Tien = txt_soTien.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            if (string.IsNullOrEmpty(currentBudgetID)) return;
            if (!decimal.TryParse(Tien, out decimal soTien) || soTien <= 0) return;
            if (!int.TryParse(txt_thang.Text.Trim(), out int thang) || thang < 1 || thang > 12) return;
            if (!int.TryParse(txt_nam.Text.Trim(), out int nam) || nam < 2000) return;

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var bd = db.Budgets.SingleOrDefault(x => x.BudgetID == currentBudgetID);
                if (bd != null)
                {
                    bd.CategoryID = cbo_DanhMuc.SelectedValue.ToString();
                    bd.Amount = soTien;
                    bd.Month = thang;
                    bd.Year = nam;
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); LoadChart(); UpdateMetrics();
                    currentBudgetID = "";
                }
            }
        }

        // XOÁ 
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentBudgetID)) return;
            if (MessageBox.Show("Bạn có chắc muốn xoá ngân sách này?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var bd = db.Budgets.SingleOrDefault(x => x.BudgetID == currentBudgetID);
                if (bd != null)
                {
                    db.Budgets.DeleteOnSubmit(bd);
                    db.SubmitChanges();
                    MessageBox.Show("Xoá thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_reset_Click(null, null);
                    LoadData(); LoadChart(); UpdateMetrics();
                }
            }
        }

        //  RESET 
        private void btn_reset_Click(object sender, EventArgs e)
        {
            currentBudgetID = "";
            txt_soTien.Clear();
            txt_thang.Text = filterMonth.ToString();
            txt_nam.Text = filterYear.ToString();
            if (cbo_DanhMuc.Items.Count > 0) cbo_DanhMuc.SelectedIndex = 0;
            dgv_nganSach.ClearSelection();
        }

        //  THOÁT 
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<FrmMainMenu>().FirstOrDefault()?.RefreshMenu();
            Application.OpenForms.OfType<FrmTaiKhoan>().FirstOrDefault()?.RefreshTaiKhoan();
            Application.OpenForms.OfType<FrmThongKe>().FirstOrDefault()?.RefreshThongKe();
            Application.OpenForms.OfType<FrmGiaoDich>().FirstOrDefault()?.RefreshGiaoDich();
            this.Close();
        }

        //  CLICK HÀNG 
        private void dgv_nganSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_nganSach.Rows[e.RowIndex];
            currentBudgetID = row.Cells["BudgetID"].Value?.ToString();

            if (row.Cells["CategoryID"].Value != null)
                cbo_DanhMuc.SelectedValue = row.Cells["CategoryID"].Value.ToString();

            txt_thang.Text = row.Cells["Month"].Value?.ToString();
            txt_nam.Text = row.Cells["Year"].Value?.ToString();

            decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);
            txt_soTien.Text = amount.ToString("G0");
        }
    }
}