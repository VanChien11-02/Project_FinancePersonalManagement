using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FinancePersonalManagement
{
    public partial class form_Sign_In : Form
    {
        public string LoggedInUserID { get; private set; }
        public string LoggedInUserName { get; private set; }

        public form_Sign_In()
        {
            InitializeComponent();

            // Đảm bảo mật khẩu bị che bằng dấu chấm khi vừa mở form
            txt_Pass.UseSystemPasswordChar = true;

            // Thiết lập nút btn_Accept làm nút mặc định khi nhấn phím Enter
            this.AcceptButton = btn_Accept;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string username = txt_Name.Text.Trim();
            string password = txt_Pass.Text.Trim();
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                // Dùng LINQ để tìm User có Username và Password khớp với TextBox
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

                if (user != null)
                {
                    // Đăng nhập thành công! Gán dữ liệu vào 2 biến public
                    LoggedInUserID = user.UserID;
                    LoggedInUserName = user.Username;

                    // Báo hiệu thành công và đóng form đăng nhập
                    MessageBox.Show($"Đăng nhập thành công! Chào mừng {LoggedInUserName}.", "Thành công", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Đăng nhập thất bại
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // SỬA Ở ĐÂY: Bỏ dòng txt_Name.Clear() để giữ nguyên tên đăng nhập
                    txt_Pass.Clear();  // Chỉ xóa mật khẩu bị sai
                    txt_Pass.Focus();  // Đưa con trỏ chuột nháy lại vào ô mật khẩu
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy đăng nhập không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        // =========================================================================
        // XỬ LÝ ẤN GIỮ ĐỂ XEM MẬT KHẨU
        // =========================================================================

        // Khi CHUỘT NHẤN XUỐNG (và giữ) -> Hiện mật khẩu ra
        private void btn_ViewPass_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Pass.UseSystemPasswordChar = false;
        }

        // Khi CHUỘT THẢ RA -> Ẩn mật khẩu lại
        private void btn_ViewPass_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Pass.UseSystemPasswordChar = true;
        }
    }
}