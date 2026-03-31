using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Project_FinancePersonalManagement
{
    public partial class form_Sign_Up : Form
    {
        public form_Sign_Up()
        {
            InitializeComponent();

            // Đảm bảo khi form vừa mở lên là 2 ô mật khẩu đã bị che bằng dấu chấm
            txt_Pass.UseSystemPasswordChar = true;
            txt_RePass.UseSystemPasswordChar = true;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string username = txt_Name.Text.Trim();
            string password = txt_Pass.Text.Trim();
            string rePassword = txt_RePass.Text.Trim();

            // 1. Kiểm tra không được để trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rePassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập, Mật khẩu và Nhập lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra mật khẩu có khớp nhau không
            if (password != rePassword)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp! Vui lòng kiểm tra lại.", "Lỗi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_RePass.Clear();
                txt_RePass.Focus();
                return;
            }

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                // 3. Kiểm tra xem Username đã tồn tại chưa
                bool isExist = db.Users.Any(u => u.Username == username);
                if (isExist)
                {
                    MessageBox.Show("Tên đăng nhập này đã có người sử dụng. Vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Name.Clear();
                    txt_Pass.Clear();
                    txt_RePass.Clear();
                    txt_Name.Focus();
                    return;
                }

                try
                {
                    // Tự động tạo ID mới
                    string newUserID = "USER001";

                    var lastUser = db.Users.OrderByDescending(u => u.UserID).FirstOrDefault();
                    if (lastUser != null)
                    {
                        int lastNumber = int.Parse(lastUser.UserID.Substring(4));
                        newUserID = "USER" + (lastNumber + 1).ToString("D3");
                    }

                    // Lưu vào DB
                    User newUser = new User();
                    newUser.UserID = newUserID;
                    newUser.Username = username;
                    newUser.PasswordHash = password;

                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();

                    MessageBox.Show($"Đăng ký thành công! Mã của bạn là: {newUserID}\nBây giờ bạn có thể đăng nhập.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // =========================================================================
        // DÙNG 1 NÚT ĐỂ HIỆN/ẨN CẢ 2 MẬT KHẨU CÙNG LÚC
        // =========================================================================

        // Khi CHUỘT NHẤN XUỐNG (và giữ) -> Hiện cả 2 mật khẩu ra
        private void btn_ViewPass_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Pass.UseSystemPasswordChar = false;
            txt_RePass.UseSystemPasswordChar = false;
        }

        // Khi CHUỘT THẢ RA -> Ẩn cả 2 mật khẩu lại
        private void btn_ViewPass_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Pass.UseSystemPasswordChar = true;
            txt_RePass.UseSystemPasswordChar = true;
        }
        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            string pass = txt_Pass.Text;
            int score = 0;

            // THUẬT TOÁN CHẤM ĐIỂM (Tối đa 5 điểm)
            if (pass.Length >= 6) score++; // Tiêu chí 1: Dài từ 6 ký tự trở lên
            if (Regex.IsMatch(pass, "[a-z]")) score++; // Tiêu chí 2: Có chứa chữ cái thường
            if (Regex.IsMatch(pass, "[A-Z]")) score++; // Tiêu chí 3: Có chứa chữ cái in hoa
            if (Regex.IsMatch(pass, "[0-9]")) score++; // Tiêu chí 4: Có chứa con số
            if (Regex.IsMatch(pass, "[^a-zA-Z0-9]")) score++; // Tiêu chí 5: Có ký tự đặc biệt (!@#$%)

            // Cập nhật Label cái "Chấm" hiển thị
            if (pass.Length == 0)
            {
                lbl_Strength.Text = "Độ mạnh: Chưa nhập";
                lbl_Strength.ForeColor = Color.Black;
            }
            else if (score <= 2) // Dưới 2 điểm là YẾU
            {
                lbl_Strength.Text = "Độ mạnh: Yếu 🔴";
                lbl_Strength.ForeColor = Color.Red;
            }
            else if (score == 3 || score == 4) // 3-4 điểm là TRUNG BÌNH
            {
                lbl_Strength.Text = "Độ mạnh: Khá 🟡";
                lbl_Strength.ForeColor = Color.Orange;
            }
            else if (score == 5) // Đạt cả 5 tiêu chí là MẠNH
            {
                lbl_Strength.Text = "Độ mạnh: Tuyệt đối 🟢";
                lbl_Strength.ForeColor = Color.Green;
            }
        }
    }
}