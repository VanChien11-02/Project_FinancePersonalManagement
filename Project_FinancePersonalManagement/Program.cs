using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_FinancePersonalManagement
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Chạy màn hình Welcome trước
            Application.Run(new FrmSplash());

            // 2. Sau khi màn hình Welcome tự tắt, nó sẽ tự động chạy tiếp Form chính
            // (Form chính sẽ tự động gọi Form Đăng nhập như code hồi nãy bạn đã sửa)
            Application.Run(new FrmMainMenu());
        }
    }

    // --- CODE TẠO MÀN HÌNH WELCOME TỰ ĐỘNG ---
    public class FrmSplash : Form
    {
        private Timer timer;
        private bool isFadingIn = true;

        public FrmSplash()
        {
            // Cài đặt giao diện form cơ bản
            this.FormBorderStyle = FormBorderStyle.None; // Tắt thanh tiêu đề
            this.StartPosition = FormStartPosition.CenterScreen; // Ra giữa màn hình
            this.Size = new Size(500, 250);
            this.BackColor = Color.White; // Nền trắng
            this.Opacity = 0; // Bắt đầu với độ mờ = 0 (tàng hình)

            // Tạo chữ WELCOME
            Label lbl = new Label();
            lbl.Text = "WELCOME";
            lbl.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(249, 168, 38); // Màu cam vàng tone-sur-tone với app của bạn
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Dock = DockStyle.Fill;
            this.Controls.Add(lbl);

            // Cài đặt bộ đếm thời gian (Timer) để làm mượt
            timer = new Timer();
            timer.Interval = 30; // Cứ 30 mili-giây thì chạy hàm Timer_Tick 1 lần
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isFadingIn)
            {
                this.Opacity += 0.05; // Đậm dần lên mỗi nhịp
                if (this.Opacity >= 1)
                {
                    isFadingIn = false;
                    timer.Interval = 1200; // Đứng hình khoảng 1.2 giây cho người ta đọc chữ
                }
            }
            else
            {
                timer.Interval = 30; // Trở lại tốc độ cũ để mờ đi
                this.Opacity -= 0.05; // Mờ dần đi
                if (this.Opacity <= 0)
                {
                    timer.Stop();
                    this.Close(); // Tắt form Welcome hoàn toàn
                }
            }
        }
    }
}