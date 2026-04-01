using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmLogin : Form
    {
        public string LoggedInUserID { get; private set; }
        public string LoggedInUserName { get; private set; }

        private bool isLoginMode = true;


        private void ShowPanel(Guna.UI2.WinForms.Guna2ShadowPanel panelToShow)
        {
            pn_login.Visible = false;
            pn_regis.Visible = false;
            pn_ForgotAcc.Visible = false;
            pn_ForgotPass.Visible = false;

            panelToShow.Visible = true;
        }

        public FrmLogin()
        {
            InitializeComponent();

            // --- SETUP BÊN ĐĂNG NHẬP ---
            txt_Name_Login.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txt_Pass_Login.Focus(); };
            //txt_Pass_Login.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btn_Accept_Click(s, e); };

            // --- SETUP BÊN ĐĂNG KÝ ---
            txt_Name_Reg.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txt_Pass_Reg.Focus(); };
            txt_Pass_Reg.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txt_PassConfirm_Reg.Focus(); };
            txt_PassConfirm_Reg.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btn_Register_Click(s, e); };
        }



        /*
        // Đăng nhập cũ
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            /*
            ////default để test (bỏ qua phần đăng nhập tạm thời)
            //LoggedInUserID = "USER001";
            //LoggedInUserName = "chien";
            //this.DialogResult = DialogResult.OK;
            //this.Close();
            
            string username = txt_Name.Text.Trim();
            string passwordHash = txt_Pass.Text.Trim();
            if (isLoginMode)
                PerformLogin();
            else
                PerformRegister();
        }

        // --- LOGIC ĐĂNG NHẬP ---
        private void PerformLogin()
        {
            string username = txt_Name_Login.Text.Trim();
            string passwordHash = txt_Pass_Login.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwordHash))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);

                    if (user != null)
                    {
                        // Đăng nhập thành công! Gán dữ liệu vào 2 biến public
                        LoggedInUserID = user.UserID;
                        LoggedInUserName = user.Username;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Pass_Login.Clear();
                        txt_Name_Login.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        // --- LOGIC ĐĂNG KÝ ---
        private void PerformRegister()
        {
            string username = txt_Name_Login.Text.Trim();
            string password = txt_Pass_Login.Text.Trim();
            string confirm = txt_PassConfirm_Reg.Text;

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
                MessageBox.Show("Mật khẩu phải có ít nhất 5 ký tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password != confirm)
            {
                lbl_MatchMsg.Text = "✗ Mật khẩu xác nhận không khớp.";
                lbl_MatchMsg.ForeColor = Color.FromArgb(194, 35, 35);
                txt_PassConfirm_Reg.Clear();
                txt_PassConfirm_Reg.Focus();
                return;
            }

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                if (db.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Name_Login.SelectAll();
                    txt_Name_Login.Focus();
                    return;
                }

                try
                {
                    // Tự động Generate ID mới
                    string newUserID = "USER001";
                    var lastUser = db.Users.OrderByDescending(u => u.UserID).FirstOrDefault();
                    if (lastUser != null)
                    {
                        int lastNumber = int.Parse(lastUser.UserID.Substring(4));
                        newUserID = "USER" + (lastNumber + 1).ToString("D3");
                    }

                    User newUser = new User
                    {
                        UserID = newUserID,
                        Username = username,
                        PasswordHash = password
                    };

                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();

                    MessageBox.Show($"Đăng ký thành công!\nMã tài khoản: {newUserID}\nHãy tiến hành đăng nhập.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đăng ký xong tự động quay về màn hình Login
                    ShowPanel(pn_login);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            txt_Pass_Login.PasswordChar = (txt_Pass_Login.PasswordChar == '\0') ? '*' : '\0';
        }


        
       

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lbl_NameError.Text = "";
            lbl_MatchMsg.Text = "";

            // 1. Ép 3 bảng chui vào đúng vị trí của bảng Login
            pn_regis.Location = pn_login.Location;
            pn_ForgotAcc.Location = pn_login.Location;
            pn_ForgotPass.Location = pn_login.Location;
            lbl_MatchMsg_ForgotPass.Visible = false;
            // 2. Xóa các chữ báo lỗi mặc định
            lbl_NameError.Text = "";
            lbl_MatchMsg.Text = "";
            // Xóa luôn chữ label5 ở 2 bảng Quên MK/TK nếu bạn có tạo

            // 3. Mới mở App lên thì chỉ hiện bảng Login
            ShowPanel(pn_login);

            if (Properties.Settings.Default.IsRemembered)
            {
                txt_Name_Login.Text = Properties.Settings.Default.UserSaved;
                txt_Pass_Login.Text = Properties.Settings.Default.PassSaved;
                tg_RememberMe.Checked = true;
            }
        }

       
     

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_regis);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_ForgotAcc);
        }

        private void btn_Accept_Click_1(object sender, EventArgs e)
        {
            string username = txt_Name_Login.Text.Trim();
            string passwordHash = txt_Pass_Login.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwordHash))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);

                    if (user != null)
                    {
                        LoggedInUserID = user.UserID;
                        LoggedInUserName = user.Username;

                        // ========================================================
                        // CHÈN THÊM CODE "GHI NHỚ TÔI" Ở ĐÂY
                        // ========================================================
                        if (tg_RememberMe.Checked) // Nếu nút gạt đang bật
                        {
                            Properties.Settings.Default.UserSaved = username;
                            Properties.Settings.Default.PassSaved = passwordHash;
                            Properties.Settings.Default.IsRemembered = true;
                        }
                        else // Nếu không bật thì xóa trắng bộ nhớ cũ (đề phòng trước đó có lưu)
                        {
                            Properties.Settings.Default.UserSaved = "";
                            Properties.Settings.Default.PassSaved = "";
                            Properties.Settings.Default.IsRemembered = false;
                        }
                        Properties.Settings.Default.Save(); // Chốt lưu cài đặt
                                                            // ========================================================

                        this.DialogResult = DialogResult.OK;
                        this.Close(); // Đăng nhập thành công, đóng form và vào Menu chính
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Pass_Login.Clear();
                        txt_Pass_Login.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       
       

        

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string username = txt_Name_Reg.Text.Trim();
            string password = txt_Pass_Reg.Text.Trim();
            string confirm = txt_PassConfirm_Reg.Text;

            // Lấy thêm dữ liệu từ 2 ô mới
            string email = txt_Email_Reg.Text.Trim();
            string phone = txt_Phone_Reg.Text.Trim();

            // 1. Kiểm tra tài khoản
            if (username.Length < 3)
            {
                lbl_NameError.Text = "Tên đăng nhập cần ít nhất 3 ký tự!";
                lbl_NameError.ForeColor = Color.Red;
                txt_Name_Reg.Focus();
                return;
            }
            else
            {
                lbl_NameError.Text = ""; // Xóa lỗi nếu đã hợp lệ
            }

            // 2. Kiểm tra độ dài mật khẩu
            if (password.Length < 5)
            {
                lbl_MatchMsg.Text = "Mật khẩu quá ngắn (cần ít nhất 5 ký tự).";
                lbl_MatchMsg.ForeColor = Color.Red;
                txt_Pass_Reg.Focus();
                return;
            }

            // 3. Kiểm tra khớp mật khẩu
            if (password != confirm)
            {
                lbl_MatchMsg.Text = "✗ Mật khẩu xác nhận không khớp.";
                lbl_MatchMsg.ForeColor = Color.Red;
                txt_PassConfirm_Reg.Focus();
                return;
            }

            // 4. Kiểm tra Email và SĐT (Bắt buộc nhập ít nhất 1 cái)
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone))
            {
                lbl_NameError.Text = "Vui lòng nhập Email hoặc Số điện thoại!";
                lbl_NameError.ForeColor = Color.Red;
                txt_Email_Reg.Focus();
                return;
            }

            // 5. Lưu vào CSDL
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                // Check trùng Tên đăng nhập
                if (db.Users.Any(u => u.Username == username))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Name_Reg.SelectAll();
                    txt_Name_Reg.Focus();
                    return;
                }

                // Check trùng Email (nếu có nhập)
                if (!string.IsNullOrEmpty(email) && db.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("Email này đã được sử dụng cho tài khoản khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Email_Reg.Focus();
                    return;
                }

                // Check trùng SĐT (nếu có nhập)
                if (!string.IsNullOrEmpty(phone) && db.Users.Any(u => u.PhoneNumber == phone))
                {
                    MessageBox.Show("Số điện thoại này đã được sử dụng cho tài khoản khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Phone_Reg.Focus();
                    return;
                }

                try
                {
                    // Tự động Generate ID mới (USER001, USER002...)
                    string newUserID = "USER001";
                    var lastUser = db.Users.OrderByDescending(u => u.UserID).FirstOrDefault();
                    if (lastUser != null)
                    {
                        int lastNumber = int.Parse(lastUser.UserID.Substring(4));
                        newUserID = "USER" + (lastNumber + 1).ToString("D3");
                    }

                    // TẠO USER MỚI VỚI 2 CỘT TÁCH BIỆT
                    User newUser = new User
                    {
                        UserID = newUserID,
                        Username = username,
                        PasswordHash = password,
                        Email = string.IsNullOrEmpty(email) ? null : email,
                        PhoneNumber = string.IsNullOrEmpty(phone) ? null : phone
                    };

                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();

                    MessageBox.Show($"Đăng ký thành công!\nMã tài khoản: {newUserID}\nBây giờ bạn có thể dùng tài khoản này ở bảng Đăng nhập bên cạnh.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset các ô đăng ký sau khi thành công
                    txt_Name_Reg.Clear();
                    txt_Pass_Reg.Clear();
                    txt_PassConfirm_Reg.Clear();
                    txt_Email_Reg.Clear();
                    txt_Phone_Reg.Clear();

                    // Mẹo: Gọi hàm chuyển về bảng Login để người dùng đăng nhập luôn
                    // ShowPanel(pn_login); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      

       

        

        private void txt_Pass_Login_IconRightClick(object sender, EventArgs e)
        {
            if (txt_Pass_Login.UseSystemPasswordChar)
            {
                // Đang che -> Mở ra
                txt_Pass_Login.UseSystemPasswordChar = false;
                txt_Pass_Login.PasswordChar = '\0';
                txt_Pass_Login.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_open;
            }
            else
            {
                // Đang hiện -> Che lại
                txt_Pass_Login.UseSystemPasswordChar = true;
                txt_Pass_Login.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_close;
            }
        }

        private void txt_Pass_Reg_IconRightClick(object sender, EventArgs e)
        {
            if (txt_Pass_Reg.UseSystemPasswordChar)
            {
                txt_Pass_Reg.UseSystemPasswordChar = false;
                txt_Pass_Reg.PasswordChar = '\0';
                txt_Pass_Reg.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_open;
            }
            else
            {
                txt_Pass_Reg.UseSystemPasswordChar = true;
                txt_Pass_Reg.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_close;
            }
        }

        private void txt_PassConfirm_Reg_IconRightClick(object sender, EventArgs e)
        {
            if (txt_PassConfirm_Reg.UseSystemPasswordChar)
            {
                txt_PassConfirm_Reg.UseSystemPasswordChar = false;
                txt_PassConfirm_Reg.PasswordChar = '\0';
                txt_PassConfirm_Reg.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_open;
            }
            else
            {
                txt_PassConfirm_Reg.UseSystemPasswordChar = true;
                txt_PassConfirm_Reg.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_close;
            }
        }

       

        private void txt_PassConfirm_Reg_TextChanged(object sender, EventArgs e)
        {
            // Nếu ô xác nhận trống thì không báo gì
            if (txt_PassConfirm_Reg.Text.Length == 0)
            {
                lbl_MatchMsg.Text = "";
                return;
            }

            // So sánh với ô mật khẩu ở trên
            if (txt_PassConfirm_Reg.Text == txt_Pass_Reg.Text)
            {
                lbl_MatchMsg.Text = "✓ Mật khẩu khớp";
                lbl_MatchMsg.ForeColor = Color.Green; // Chữ màu xanh
            }
            else
            {
                lbl_MatchMsg.Text = "✗ Mật khẩu không khớp";
                lbl_MatchMsg.ForeColor = Color.Red;   // Chữ màu đỏ
            }
        }

      

        private void btn_RecoverAcc_Click(object sender, EventArgs e)
        {
            string inputData = txt_Email_ForgotAcc.Text.Trim(); // Lấy chữ người dùng gõ
            if (string.IsNullOrEmpty(inputData))
            {
                MessageBox.Show("Vui lòng nhập Email hoặc Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    // Tìm user dựa vào Email HOẶC Số điện thoại
                    var user = db.Users.FirstOrDefault(u => u.Email == inputData || u.PhoneNumber == inputData);

                    if (user != null)
                    {
                        // Random mật khẩu 6 ký tự
                        string randomPass = Guid.NewGuid().ToString().Substring(0, 6).ToUpper();

                        // Cập nhật pass mới vào DB
                        user.PasswordHash = randomPass;
                        db.SubmitChanges();

                        // KỊCH BẢN 1: Nếu tài khoản có Email -> Gửi mail
                        if (!string.IsNullOrEmpty(user.Email))
                        {
                            // Gọi hàm gửi mail vừa tạo ở Bước 2
                            SendEmail(user.Email, user.Username, randomPass);

                            lbl_ResultAcc.Text = $"Tên tài khoản: {user.Username}\n✓ Mật khẩu mới đã được gửi vào Email của bạn!";
                            lbl_ResultAcc.ForeColor = Color.Green;
                        }
                        // KỊCH BẢN 2: Tài khoản đăng ký bằng SĐT, không có Email -> Hiện thẳng lên màn hình
                        else
                        {
                            lbl_ResultAcc.Text = $"Tên tài khoản: {user.Username}\nMật khẩu mới: {randomPass}\n(Lưu ý: TK này không có Email để gửi thông báo)";
                            lbl_ResultAcc.ForeColor = Color.Orange;
                        }
                    }
                    else
                    {
                        lbl_ResultAcc.Text = "✗ Không tìm thấy tài khoản nào với Email/SĐT này.";
                        lbl_ResultAcc.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            string email = txt_Email_ForgotPass.Text.Trim();
            string newPass = txt_NewPass.Text.Trim();
            string confirmPass = txt_ConfirmNewPass.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass.Length < 5)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 5 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ConfirmNewPass.Clear();
                return;
            }

            try
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Email == email || u.PhoneNumber == email);

                    if (user != null)
                    {
                        user.PasswordHash = newPass;
                        db.SubmitChanges();

                        MessageBox.Show("Đổi mật khẩu thành công! Bạn có thể đăng nhập bằng mật khẩu mới.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ẩn bảng Forgot Pass, hiện lại bảng Login
                        pn_ForgotPass.Visible = false;
                        pn_login.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản với Email/SĐT này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txt_NewPass_IconRightClick(object sender, EventArgs e)
        {
            if (txt_NewPass.UseSystemPasswordChar)
            {
                txt_NewPass.UseSystemPasswordChar = false;
                txt_NewPass.PasswordChar = '\0';
                txt_NewPass.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_open;
            }
            else
            {
                txt_NewPass.UseSystemPasswordChar = true;
                txt_NewPass.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_close;
            }
        }

        private void txt_ConfirmNewPass_IconRightClick(object sender, EventArgs e)
        {
            if (txt_ConfirmNewPass.UseSystemPasswordChar)
            {
                txt_ConfirmNewPass.UseSystemPasswordChar = false;
                txt_ConfirmNewPass.PasswordChar = '\0';
                txt_ConfirmNewPass.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_open;
            }
            else
            {
                txt_ConfirmNewPass.UseSystemPasswordChar = true;
                txt_ConfirmNewPass.IconRight = Project_FinancePersonalManagement.Properties.Resources.mat_close;
            }
        }

        private void lbl_ForgotPass_Link_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_ForgotPass);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_login);
        }

        private void lbl_BackFromAcc_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_login);
        }

        private void lbl_BackFromPass_Click(object sender, EventArgs e)
        {
            ShowPanel(pn_login);
        }

        private void SendEmail(string toEmail, string username, string newPassword)
        {
            try
            {
                // 1. Nhập Email của bạn vào đây
                var fromAddress = new MailAddress("nguyentatdo296@gmail.com", "Hệ thống Quản lý Tài chính");
                var toAddress = new MailAddress(toEmail);

                // 2. NHẬP MẬT KHẨU ỨNG DỤNG GMAIL VÀO ĐÂY (Mã 16 ký tự)
                const string fromPassword = "yefe eiat obrs hheq";

                const string subject = "Khôi phục mật khẩu tài khoản";
                string body = $"Chào {username},\n\nMật khẩu mới của bạn là: {newPassword}\nVui lòng đăng nhập và đổi lại mật khẩu ngay để bảo mật tài khoản.";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message, "Lỗi Smtp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ConfirmNewPass_TextChanged(object sender, EventArgs e)
        {
            // 1. Nếu xóa trắng ô -> Cho tàng hình luôn
            if (txt_ConfirmNewPass.Text.Length == 0)
            {
                lbl_MatchMsg_ForgotPass.Visible = false;
                return;
            }

            // 2. Nếu bắt đầu gõ chữ -> Cho hiện hình lên
            lbl_MatchMsg_ForgotPass.Visible = true;

            // 3. Kiểm tra khớp hay không
            if (txt_ConfirmNewPass.Text == txt_NewPass.Text)
            {
                lbl_MatchMsg_ForgotPass.Text = "✓ Mật khẩu khớp";
                lbl_MatchMsg_ForgotPass.ForeColor = Color.Green;
            }
            else
            {
                lbl_MatchMsg_ForgotPass.Text = "✗ Mật khẩu không khớp";
                lbl_MatchMsg_ForgotPass.ForeColor = Color.Red;
            }
        }

        
    }
}