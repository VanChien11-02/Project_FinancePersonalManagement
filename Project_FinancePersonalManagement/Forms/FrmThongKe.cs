using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmThongKe : Form
    {
        private string currentUserID;
        public FrmThongKe(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
        }

        private void form_ThongKe_Load(object sender, EventArgs e)
        {
            // Thiết lập ngày mặc định (Đầu năm đến hiện tại)
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, 1, 1);
            dtpDenNgay.Value = today;

            // Tự động nhấn nút Lọc khi form bật lên
            btn_Filter.PerformClick();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    var transList = db.Transactions
                              .Where(t => t.UserID == currentUserID && t.TransDate >= tuNgay && t.TransDate <= denNgay)
                              .ToList();

                    var dailyStats = transList
                        .GroupBy(t => t.TransDate.Value.Date)
                        .Select(g => new
                        {
                            NgayGoc = g.Key,
                            NgayHienThi = g.Key.ToString("dd/MM"),
                            Thu = g.Where(x => x.TransType == "Income").Sum(x => x.Amount),
                            Chi = g.Where(x => x.TransType == "Expense").Sum(x => x.Amount)
                        }).OrderBy(x => x.NgayGoc).ToList();

                    chartThuChi.Series.Clear();
                    chartThuChi.ChartAreas[0].AxisX.Interval = 1;

                    Series sThu = chartThuChi.Series.Add("Thu Nhập");
                    sThu.ChartType = SeriesChartType.Line; // Đổi thành đường thẳng
                    sThu.BorderWidth = 3;
                    sThu.Color = Color.FromArgb(46, 204, 113); // Xanh lá
                    sThu.MarkerStyle = MarkerStyle.Circle;
                    sThu.MarkerSize = 7;

                    Series sChi = chartThuChi.Series.Add("Chi Tiêu");
                    sChi.ChartType = SeriesChartType.Line; // Đổi thành đường thẳng
                    sChi.BorderWidth = 3;
                    sChi.Color = Color.FromArgb(231, 76, 60); // Đỏ
                    sChi.MarkerStyle = MarkerStyle.Circle;
                    sChi.MarkerSize = 7;

                    foreach (var item in dailyStats)
                    {
                        sThu.Points.AddXY(item.NgayHienThi, item.Thu);
                        sChi.Points.AddXY(item.NgayHienThi, item.Chi);
                    }

                    // BIỂU ĐỒ NGÂN SÁCH VS ĐÃ CHI (Thay cho Thu nhập tháng)
                    chartThuNhapThang.Legends[0].Enabled = true; // Bật chú thích để phân biệt 2 cột
                    chartThuNhapThang.Series.Clear();

                    // Lấy tháng và năm của mốc "Từ ngày" để lọc ngân sách
                    int selectedMonth = tuNgay.Month;
                    int selectedYear = tuNgay.Year;
                    lbl_DanhMuc.Text = $"Ngân sách và chi tiêu trong tháng {selectedMonth}/{selectedYear}";

                    var budgets = db.Budgets
                        .Where(b => b.UserID == currentUserID && b.Month == selectedMonth && b.Year == selectedYear)
                        .ToList();

                    // Lọc sẵn các giao dịch là Chi Tiêu
                    var spentTransactions = transList.Where(t => t.TransType == "Expense").ToList();

                    Series sBudget = chartThuNhapThang.Series.Add("Ngân sách");
                    sBudget.ChartType = SeriesChartType.Column;
                    sBudget.Color = Color.LightBlue;
                    sBudget["PixelPointWidth"] = "35";

                    Series sSpent = chartThuNhapThang.Series.Add("Chi tiêu");
                    sSpent.ChartType = SeriesChartType.Column;
                    sSpent.Color = Color.FromArgb(231, 76, 60); // Màu đỏ cảnh báo
                    sSpent["PixelPointWidth"] = "35";

                    foreach (var budget in budgets)
                    {
                        string catName = db.Categories.FirstOrDefault(c => c.CategoryID == budget.CategoryID)?.CategoryName ?? "Khác";
                        decimal totalSpent = spentTransactions.Where(t => t.CategoryID == budget.CategoryID).Sum(t => t.Amount);

                        int pIndexB = sBudget.Points.AddXY(catName, budget.Amount);
                        sBudget.Points[pIndexB].ToolTip = $"Ngân sách: {budget.Amount:N0} VNĐ";

                        int pIndexS = sSpent.Points.AddXY(catName, totalSpent);
                        sSpent.Points[pIndexS].ToolTip = $"Chi tiêu: {totalSpent:N0} VNĐ";
                    }

                    // BIỂU ĐỒ NỢ / VAY (Doughnut Chart)
                    var debtStats = db.Debts
                        .Where(d => d.UserID == currentUserID && d.Status == "Active" && d.StartDate >= tuNgay && d.StartDate <= denNgay)
                        .GroupBy(d => d.DebtType)
                        .Select(g => new { LoaiNo = g.Key, TongTien = g.Sum(x => x.Amount) })
                        .ToList();

                    chartNoVay.Series.Clear();

                    Series seriesNoVay = chartNoVay.Series.Add("NoVaySeries");
                    seriesNoVay.ChartType = SeriesChartType.Doughnut;
                    seriesNoVay["DoughnutRadius"] = "50";
                    seriesNoVay.Label = "#PERCENT{P0}";
                    seriesNoVay["PieLabelStyle"] = "Inside";
                    seriesNoVay.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    seriesNoVay.LabelForeColor = Color.White;
                    seriesNoVay.LegendText = "#VALX";

                    foreach (var item in debtStats)
                    {
                        int pIndex = seriesNoVay.Points.AddXY(item.LoaiNo, item.TongTien);
                        seriesNoVay.Points[pIndex].ToolTip = $"{item.LoaiNo}: {item.TongTien:N0} VNĐ";

                        if (item.LoaiNo.Contains("Đi vay"))
                            seriesNoVay.Points[pIndex].Color = Color.FromArgb(231, 76, 60);
                        else
                            seriesNoVay.Points[pIndex].Color = Color.FromArgb(46, 204, 113);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshThongKe()
        {
            btn_Filter.PerformClick();
        }

        private void chartThuNhapThang_Click(object sender, EventArgs e)
        {

        }
    }
}