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
            // Thiết lập ngày mặc định
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
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

                    // BIỂU ĐỒ THU NHẬP VÀ CHI TIÊU (Spline Chart)
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
                    sThu.ChartType = SeriesChartType.Spline;
                    sThu.BorderWidth = 3;
                    sThu.Color = Color.FromArgb(46, 204, 113); // Màu xanh lá (#2ECC71)
                    sThu.MarkerStyle = MarkerStyle.Circle;
                    sThu.MarkerSize = 7;

                    Series sChi = chartThuChi.Series.Add("Chi Tiêu");
                    sChi.ChartType = SeriesChartType.Spline;
                    sChi.BorderWidth = 3;
                    sChi.Color = Color.FromArgb(231, 76, 60); // Màu đỏ (#E74C3C)
                    sChi.MarkerStyle = MarkerStyle.Circle;
                    sChi.MarkerSize = 7;

                    foreach (var item in dailyStats)
                    {
                        sThu.Points.AddXY(item.NgayHienThi, item.Thu);
                        sChi.Points.AddXY(item.NgayHienThi, item.Chi);
                    }

                    // BIỂU ĐỒ THU NHẬP THEO THÁNG (Column Chart)
                    chartThuNhapThang.Legends[0].Enabled = false; // Ẩn chú thích (vì chỉ có 1 cột thu nhập)
                    var monthlyIncome = transList
                        .Where(t => t.TransType == "Income")
                        .GroupBy(t => new { t.TransDate.Value.Year, t.TransDate.Value.Month })
                        .Select(g => new
                        {
                            Thang = $"T{g.Key.Month}/{g.Key.Year}",
                            Thu = g.Sum(x => x.Amount)
                        }).OrderBy(x => x.Thang).ToList();

                    chartThuNhapThang.Series.Clear();
                    Series sThuThang = chartThuNhapThang.Series.Add("Thu Nhập Tháng");
                    sThuThang.ChartType = SeriesChartType.Column;
                    sThuThang.Color = Color.FromArgb(52, 152, 219); // Xanh dương tươi
                    sThuThang["PixelPointWidth"] = "45"; // Tránh cột bị phình to

                    foreach (var item in monthlyIncome)
                    {
                        int pIndex = sThuThang.Points.AddXY(item.Thang, item.Thu);
                        sThuThang.Points[pIndex].ToolTip = $"{item.Thang}: {item.Thu:N0} VNĐ";
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
                    seriesNoVay.LegendText = "#VALX"; // Hiện tên ở phần chú thích

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
    }
}