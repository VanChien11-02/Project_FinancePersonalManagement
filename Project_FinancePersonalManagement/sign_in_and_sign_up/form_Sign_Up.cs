using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Project_FinancePersonalManagement
{
    public partial class form_Sign_Up : Form
    {
        public form_Sign_Up()
        {
            InitializeComponent();
            
            txt_Name.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    txt_Pass.Focus();
                }
            };
            txt_Pass.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    txt_PassConfirm.Focus();
                }
            };
            txt_PassConfirm.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                    btn_Accept_Click(s, e);
                }
            };
        }

        // Đăng ký
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string username = txt_Name.Text.Trim();
            string password = txt_Pass.Text.Trim();
            string confirm = txt_PassConfirm.Text.Trim();

            // Reset lỗi
            lbl_NameError.Text = "";
            lbl_MatchMsg.Text = "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lbl_NameError.Text = "Vui lòng nhập đầy đủ thông tin.";
                return;
            }
            if (username.Length < 3)
            {
                lbl_NameError.Text = "Tên đăng nhập phải có ít nhất 3 ký tự.";
                lbl_NameError.ForeColor = Color.FromArgb(194, 35, 35);
                return;
            }
            if (password.Length < 5)
            {
                lbl_Strength.Text = "Mật khẩu phải có ít nhất 5 ký tự.";
                lbl_Strength.ForeColor = Color.FromArgb(194, 35, 35);
                return;
            }
            if (password != confirm)
            {
                lbl_MatchMsg.Text = "✗ Mật khẩu xác nhận không khớp.";
                lbl_MatchMsg.ForeColor = Color.FromArgb(194, 35, 35);
                txt_PassConfirm.Clear();
                txt_PassConfirm.Focus();
                return;
            }

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                if (db.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.",
                        "Lỗi trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbl_NameError.ForeColor = Color.FromArgb(194, 35, 35);
                    txt_Name.Clear();
                    txt_Pass.Clear();
                    txt_PassConfirm.Clear();
                    txt_Name.Focus();
                    return;
                }

                try
                {
                    // Tự động Generate ID mới
                    string newUserID = "USER001"; // Mặc định nếu là người đầu tiên

                    // Lấy ra user có ID lớn nhất hiện tại
                    var lastUser = db.Users.OrderByDescending(u => u.UserID).FirstOrDefault();
                    if (lastUser != null)
                    {
                        // Cắt chữ "USER" đi, lấy phần số ("USER005" -> 5), cộng 1 thành 6, rồi gắn lại
                        int lastNumber = int.Parse(lastUser.UserID.Substring(4));
                        newUserID = "USER" + (lastNumber + 1).ToString("D3"); // D3 là format 3 chữ số: 006
                    }

                    User newUser = new User
                    {
                        UserID = newUserID,
                        Username = username,
                        PasswordHash = password
                    };

                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();

                    MessageBox.Show(
                        $"Đăng ký thành công!\nMã tài khoản của bạn: {newUserID}\nBây giờ bạn có thể đăng nhập.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message,
                        "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Thoát
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hiện / ẩn mật khẩu
        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = (txt_Pass.PasswordChar == '\0') ? '*' : '\0';
        }

        private void btn_ShowPass2_Click(object sender, EventArgs e)
        {
            txt_PassConfirm.PasswordChar = (txt_PassConfirm.PasswordChar == '\0') ? '*' : '\0';
        }

        // Kiểm tra tên đăng nhập realtime
        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            string username = txt_Name.Text.Trim();
            if (username.Length == 0) { lbl_NameError.Text = ""; return; }
            if (username.Length < 3)
            {
                lbl_NameError.Text = "Cần ít nhất 3 ký tự.";
                lbl_NameError.ForeColor = Color.FromArgb(194, 35, 35);
            }
            else
            {
                lbl_NameError.Text = "✓ Tên hợp lệ";
                lbl_NameError.ForeColor = Color.FromArgb(29, 158, 117);
            }
        }

        // Kiểm tra khớp mật khẩu realtime
        private void txt_PassConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txt_PassConfirm.Text.Trim().Length == 0) { lbl_MatchMsg.Text = ""; return; }

            if (txt_PassConfirm.Text.Trim() == txt_Pass.Text.Trim())
            {
                lbl_MatchMsg.Text = "✓ Mật khẩu khớp";
                lbl_MatchMsg.ForeColor = Color.FromArgb(29, 158, 117);
            }
            else
            {
                lbl_MatchMsg.Text = "✗ Mật khẩu không khớp";
                lbl_MatchMsg.ForeColor = Color.FromArgb(194, 35, 35);
            }
        }
    }
}