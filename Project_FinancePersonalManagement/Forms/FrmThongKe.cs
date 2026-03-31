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
    public partial class FrmThongKe : Form
    {
        private string currentUserID;
        public FrmThongKe(string UserID)
        {
            InitializeComponent();

            currentUserID = UserID;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;

            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // BIỂU ĐỒ NỢ / VAY (chartNoVay)
                    // Dùng LINQ lọc các khoản nợ ĐANG HOẠT ĐỘNG (Active) và được tạo trong khoảng thời gian đã chọn
                    var debtStats = db.Debts
                        .Where(d => d.UserID == currentUserID
                                 && d.Status == "Active"
                                 && d.StartDate >= tuNgay
                                 && d.StartDate <= denNgay)
                        .GroupBy(d => d.DebtType)
                        .Select(g => new
                        {
                            LoaiNo = g.Key,
                            TongTien = g.Sum(x => x.Amount)
                        }).ToList();

                    // Xóa dữ liệu cũ
                    chartNoVay.Series.Clear();

                    // Tạo Series mới dạng bánh Doughnut
                    Series seriesNoVay = chartNoVay.Series.Add("NoVaySeries");
                    seriesNoVay.ChartType = SeriesChartType.Doughnut;

                    // Trang trí giống biểu đồ Dashboard hôm trước
                    seriesNoVay.Label = "#PERCENT{P0}";
                    seriesNoVay["PieLabelStyle"] = "Inside";
                    seriesNoVay.Font = new Font("Arial", 9, FontStyle.Bold);
                    seriesNoVay.LabelForeColor = Color.White;
                    seriesNoVay.LegendText = "#VALX"; // Hiện tên ở phần chú thích

                    // Đổ dữ liệu vào biểu đồ
                    foreach (var item in debtStats)
                    {
                        int pIndex = seriesNoVay.Points.AddXY(item.LoaiNo, item.TongTien);

                        // Thêm Tooltip để khi rê chuột vào sẽ thấy số tiền cụ thể
                        seriesNoVay.Points[pIndex].ToolTip = $"{item.LoaiNo}: {item.TongTien:N0} VNĐ";

                        // Đổi màu cho dễ nhận diện (Đi vay màu Đỏ, Cho mượn màu Xanh)
                        if (item.LoaiNo.Contains("Đi vay"))
                            seriesNoVay.Points[pIndex].Color = Color.Tomato;
                        else
                            seriesNoVay.Points[pIndex].Color = Color.MediumSeaGreen;
                    }

                    var transList = db.Transactions
                              .Where(t => t.UserID == currentUserID && t.TransDate >= tuNgay && t.TransDate <= denNgay)
                              .ToList(); // Kéo về RAM xử lý cho mượt

                    // BIỂU ĐỒ THU NHẬP VÀ CHI TIÊU (Line Chart)
                    // Gom nhóm giao dịch theo từng Ngày
                    var dailyStats = transList
                        .GroupBy(t => t.TransDate.Value.Date)
                        .Select(g => new
                        {
                            NgayGoc = g.Key, // Giữ lại kiểu DateTime để sắp xếp cho đúng
                            NgayHienThi = g.Key.ToString("dd/MM"), // Cắt ra dạng chuỗi chỉ để hiển thị
                            Thu = g.Where(x => x.TransType == "Income").Sum(x => x.Amount),
                            Chi = g.Where(x => x.TransType == "Expense").Sum(x => x.Amount)
                        })
                        .OrderBy(x => x.NgayGoc) // SẮP XẾP CHUẨN: Xếp theo thời gian thực tế
                        .ToList();

                    chartThuChi.Series.Clear();

                    // (Mẹo UI) Ép biểu đồ hiển thị ĐẦY ĐỦ các ngày trên trục X, không bị nhảy cóc hay lẩn khuất
                    chartThuChi.ChartAreas[0].AxisX.Interval = 1;

                    // Đường Xanh lá (Thu)
                    Series sThu = chartThuChi.Series.Add("Thu Nhập");
                    sThu.ChartType = SeriesChartType.Line;
                    sThu.BorderWidth = 3;
                    sThu.Color = Color.MediumSeaGreen;
                    sThu.MarkerStyle = MarkerStyle.Circle;

                    // Đường Đỏ (Chi)
                    Series sChi = chartThuChi.Series.Add("Chi Tiêu");
                    sChi.ChartType = SeriesChartType.Line;
                    sChi.BorderWidth = 3;
                    sChi.Color = Color.Tomato;
                    sChi.MarkerStyle = MarkerStyle.Circle;

                    foreach (var item in dailyStats)
                    {
                        // Nhét cái biến NgayHienThi (dạng dd/MM) vào biểu đồ
                        sThu.Points.AddXY(item.NgayHienThi, item.Thu);
                        sChi.Points.AddXY(item.NgayHienThi, item.Chi);
                    }

                    // BIỂU ĐỒ THU NHẬP THEO THÁNG (Column Chart)
                    // Lọc ra các khoản Thu và gom nhóm theo Tháng/Năm
                    chartThuNhapThang.Legends[0].Enabled = false;
                    var monthlyIncome = transList
                        .Where(t => t.TransType == "Income")
                        .GroupBy(t => new { t.TransDate.Value.Year, t.TransDate.Value.Month })
                        .Select(g => new
                        {
                            Thang = $"T{g.Key.Month}/{g.Key.Year}", // VD: T3/2026
                            Thu = g.Sum(x => x.Amount)
                        })
                        .OrderBy(x => x.Thang).ToList();

                    chartThuNhapThang.Series.Clear();
                    Series sThuThang = chartThuNhapThang.Series.Add("Thu Nhập Tháng");
                    sThuThang.ChartType = SeriesChartType.Column;
                    sThuThang.Color = Color.DodgerBlue;

                    // Bật hiển thị số tiền trên đầu cột
                    //sThuThang.IsValueShownAsLabel = true;
                    //sThuThang.LabelFormat = "{0:N0}";

                    foreach (var item in monthlyIncome)
                    {
                        sThuThang.Points.AddXY(item.Thang, item.Thu);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void form_ThongKe_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1); // Ngày đầu tiên của tháng hiện tại

            dtpDenNgay.Value = today;

            btn_Filter.PerformClick();
        }

        public void RefreshThongKe()
        {
            btn_Filter.PerformClick();
        }
    }
}
