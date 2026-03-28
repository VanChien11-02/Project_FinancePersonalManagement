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
    public partial class form_Sign_Up : Form
    {
        public form_Sign_Up()
        {
            InitializeComponent();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string username = txt_Name.Text.Trim();
            string password = txt_Pass.Text.Trim();

            // Kiểm tra không được để trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                // Kiểm tra xem Username đã tồn tại chưa (Dùng LINQ .Any)
                bool isExist = db.Users.Any(u => u.Username == username);
                if (isExist)
                {
                    MessageBox.Show("Tên đăng nhập này đã có người sử dụng. Vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK);
                    txt_Name.Clear();
                    txt_Pass.Clear();
                    txt_Name.Focus();
                    return;
                }

                try
                {
                    // Tự động Generate ID mới (Vì ID của bạn là kiểu chuỗi USER001)
                    string newUserID = "USER001"; // Mặc định nếu là người đầu tiên

                    // Lấy ra user có ID lớn nhất hiện tại
                    var lastUser = db.Users.OrderByDescending(u => u.UserID).FirstOrDefault();
                    if (lastUser != null)
                    {
                        // Cắt chữ "USER" đi, lấy phần số ("USER005" -> 5), cộng 1 thành 6, rồi gắn lại
                        int lastNumber = int.Parse(lastUser.UserID.Substring(4));
                        newUserID = "USER" + (lastNumber + 1).ToString("D3"); // D3 là format 3 chữ số: 006
                    }

                    // Tạo đối tượng User mới và thêm vào DB
                    User newUser = new User();
                    newUser.UserID = newUserID;
                    newUser.Username = username;
                    newUser.PasswordHash = password;

                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges(); // Lưu xuống SQL Server

                    MessageBox.Show($"Đăng ký thành công! Mã của bạn là: {newUserID}\nBây giờ bạn có thể đăng nhập.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form đăng ký
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
    }
}
