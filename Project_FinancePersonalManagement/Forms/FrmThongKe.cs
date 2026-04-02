using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project_FinancePersonalManagement.Data;
using SelectPdf;

namespace Project_FinancePersonalManagement
{
    public partial class FrmThongKe : Form
    {
        private string currentUserID;

        // Biến lưu trữ tháng/năm cho riêng biểu đồ Ngân sách
        private DateTime currentBudgetMonth = DateTime.Now;

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

            currentBudgetMonth = today; // Gán tháng hiện tại cho Ngân sách

            // Nạp toàn bộ biểu đồ lần đầu
            LoadMainCharts();
            LoadBudgetChart();
        }

        // =======================================================
        // 1. NHÓM BIỂU ĐỒ CHÍNH (Thu/Chi & Nợ/Vay) - Lọc theo ngày
        // =======================================================
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            LoadMainCharts();
        }

        private void LoadMainCharts()
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

                    // --- VẼ BIỂU ĐỒ THU/CHI ---
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
                    sThu.ChartType = SeriesChartType.Line;
                    sThu.BorderWidth = 3;
                    sThu.Color = Color.FromArgb(46, 204, 113);
                    sThu.MarkerStyle = MarkerStyle.Circle;
                    sThu.MarkerSize = 7;

                    Series sChi = chartThuChi.Series.Add("Chi Tiêu");
                    sChi.ChartType = SeriesChartType.Line;
                    sChi.BorderWidth = 3;
                    sChi.Color = Color.FromArgb(231, 76, 60);
                    sChi.MarkerStyle = MarkerStyle.Circle;
                    sChi.MarkerSize = 7;

                    foreach (var item in dailyStats)
                    {
                        sThu.Points.AddXY(item.NgayHienThi, item.Thu);
                        sChi.Points.AddXY(item.NgayHienThi, item.Chi);
                    }

                    // --- VẼ BIỂU ĐỒ NỢ / VAY ---
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
                    MessageBox.Show("Lỗi khi tải biểu đồ chính: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =======================================================
        // 2. BIỂU ĐỒ NGÂN SÁCH - Hoạt động độc lập theo Tháng/Năm
        // =======================================================
        private void btnThangTruoc_Click(object sender, EventArgs e)
        {
            currentBudgetMonth = currentBudgetMonth.AddMonths(-1);
            LoadBudgetChart();
        }

        private void btnThangSau_Click(object sender, EventArgs e)
        {
            currentBudgetMonth = currentBudgetMonth.AddMonths(1);
            LoadBudgetChart();
        }

        private void LoadBudgetChart()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    int m = currentBudgetMonth.Month;
                    int y = currentBudgetMonth.Year;
                    lbl_DanhMuc.Text = $"Ngân sách và chi tiêu tháng {m}/{y}";

                    chartThuNhapThang.Legends[0].Enabled = true;
                    chartThuNhapThang.Series.Clear();

                    var budgets = db.Budgets.Where(b => b.UserID == currentUserID && b.Month == m && b.Year == y).ToList();

                    // Sửa lỗi logic cũ: Query trực tiếp db theo tháng/năm thay vì lấy từ transList
                    var spentTransactions = db.Transactions
                        .Where(t => t.UserID == currentUserID && t.TransType == "Expense" && t.TransDate.Value.Month == m && t.TransDate.Value.Year == y)
                        .ToList();

                    Series sBudget = chartThuNhapThang.Series.Add("Ngân sách");
                    sBudget.ChartType = SeriesChartType.Column;
                    sBudget.Color = Color.LightBlue;
                    sBudget["PixelPointWidth"] = "35";

                    Series sSpent = chartThuNhapThang.Series.Add("Chi tiêu");
                    sSpent.ChartType = SeriesChartType.Column;
                    sSpent.Color = Color.FromArgb(231, 76, 60);
                    sSpent["PixelPointWidth"] = "35";

                    foreach (var budget in budgets)
                    {
                        string catName = db.Categories.FirstOrDefault(c => c.CategoryID == budget.CategoryID)?.CategoryName ?? "Khác";
                        decimal totalSpent = spentTransactions.Where(t => t.CategoryID == budget.CategoryID).Sum(t => (decimal?)t.Amount) ?? 0;

                        int pIndexB = sBudget.Points.AddXY(catName, budget.Amount);
                        sBudget.Points[pIndexB].ToolTip = $"Ngân sách: {budget.Amount:N0} VNĐ";

                        int pIndexS = sSpent.Points.AddXY(catName, totalSpent);
                        sSpent.Points[pIndexS].ToolTip = $"Đã chi: {totalSpent:N0} VNĐ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải biểu đồ Ngân sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. CHỤP ẢNH 3 BIỂU ĐỒ VÀ CHUYỂN THÀNH BASE64 (Để nhúng thẳng vào HTML)
                string imgChart1 = ChartToBase64(chartThuChi);
                string imgChart2 = ChartToBase64(chartThuNhapThang);
                string imgChart3 = ChartToBase64(chartNoVay);

                // 2. TẠO NỘI DUNG HTML (Dùng CSS để trang trí)
                string htmlContent = $@"
        <html>
        <head>
            <style>
                body {{ font-family: 'Arial', sans-serif; color: #333; padding: 20px; }}
                .header {{ text-align: center; border-bottom: 2px solid #185FA5; padding-bottom: 10px; }}
                .title {{ color: #185FA5; font-size: 28px; font-weight: bold; margin-bottom: 5px; }}
                .subtitle {{ font-style: italic; color: #666; }}
                .section {{ margin-top: 30px; border-left: 5px solid #185FA5; padding-left: 15px; }}
                .section-title {{ font-size: 18px; font-weight: bold; color: #185FA5; background: #f0f7ff; padding: 5px; }}
                .chart-container {{ text-align: center; margin-top: 15px; }}
                .chart-img {{ width: 90%; border: 1px solid #ddd; box-shadow: 2px 2px 5px #eee; }}
                .footer {{ margin-top: 50px; text-align: right; font-size: 12px; border-top: 1px solid #eee; padding-top: 10px; }}
            </style>
        </head>
        <body>
            <div class='header'>
                <div class='title'>BÁO CÁO THỐNG KÊ TÀI CHÍNH</div>
                <div class='subtitle'>Thời gian: {dtpTuNgay.Value:dd/MM/yyyy} - {dtpDenNgay.Value:dd/MM/yyyy}</div>
            </div>

            <div class='section'>
                <div class='section-title'>I. BIỂU ĐỒ THU NHẬP VÀ CHI TIÊU</div>
                <div class='chart-container'>
                    <img class='chart-img' src='data:image/png;base64,{imgChart1}' />
                </div>
            </div>

            <div class='section'>
                <div class='section-title'>II. NGÂN SÁCH VÀ CHI TIÊU THÁNG {currentBudgetMonth.Month}/{currentBudgetMonth.Year}</div>
                <div class='chart-container'>
                    <img class='chart-img' src='data:image/png;base64,{imgChart2}' />
                </div>
            </div>

            <div class='section'>
                <div class='section-title'>III. THỐNG KÊ NỢ VÀ VAY</div>
                <div class='chart-container'>
                    <img class='chart-img' src='data:image/png;base64,{imgChart3}' />
                </div>
            </div>

            <div class='footer'>
                Xuất bởi: PFinanceVN System | Ngày: {DateTime.Now:dd/MM/yyyy HH:mm}
            </div>
        </body>
        </html>";

                // 3. CHUYỂN HTML SANG PDF
                HtmlToPdf converter = new HtmlToPdf();
                converter.Options.PdfPageSize = PdfPageSize.A4;
                converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;

                PdfDocument doc = converter.ConvertHtmlString(htmlContent);

                // 4. LƯU VÀ MỞ FILE
                string fileName = Path.Combine(Path.GetTempPath(), "BaoCaoTaiChinh.pdf");
                doc.Save(fileName);
                doc.Close();

                Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất PDF: " + ex.Message);
            }
        }

        // Hàm phụ trợ chuyển Chart sang chuỗi Base64
        private string ChartToBase64(Chart chart)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chart.SaveImage(ms, ChartImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                return Convert.ToBase64String(byteImage);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshThongKe()
        {
            LoadMainCharts();
            LoadBudgetChart();
        }

        private void chartThuNhapThang_Click(object sender, EventArgs e) { }
    }
}