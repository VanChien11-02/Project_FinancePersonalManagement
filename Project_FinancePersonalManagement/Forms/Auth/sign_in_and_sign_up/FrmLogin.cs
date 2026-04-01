using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmLogin : Form
    {
        public string LoggedInUserID { get; private set; }
        public string LoggedInUserName { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();
            // Nhấn Enter để chuyển field hoặc submit
            txt_Name.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txt_Pass.Focus(); };
            txt_Pass.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btn_Accept_Click(s, e); };
        }

        // Đăng nhập 
        private void btn_Accept_Click(object sender, EventArgs e)
        {

            //default để test (bỏ qua phần đăng nhập tạm thời)
            LoggedInUserID = "USER001";
            LoggedInUserName = "chien";
            this.DialogResult = DialogResult.OK;
            this.Close();
            /*
            string username = txt_Name.Text.Trim();
            string passwordHash = txt_Pass.Text.Trim();

            lbl_Error.Text = "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(txt_Pass.Text))
            {
                lbl_Error.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return;
            }

            try
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var user = db.Users.FirstOrDefault(
                        u => u.Username == username && u.PasswordHash == passwordHash);

                    if (user != null)
                    {
                        // Đăng nhập thành công! Gán dữ liệu vào 2 biến public
                        LoggedInUserID = user.UserID;
                        LoggedInUserName = user.Username;
                        MessageBox.Show($"Đăng nhập thành công! Chào mừng {LoggedInUserName}.", "Thành công", MessageBoxButtons.OK);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        lbl_Error.Text = "Tên đăng nhập hoặc mật khẩu không chính xác.";
                        txt_Name.Clear();
                        txt_Pass.Clear();
                        txt_Name.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_Error.Text = "Lỗi hệ thống: " + ex.Message;
            }
            */
        }
       

        // Thoát
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        // Hiện / ẩn mật khẩu
        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = (txt_Pass.PasswordChar == '\0') ? '*' : '\0';
        }
    }
}