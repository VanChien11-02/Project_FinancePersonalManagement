namespace Project_FinancePersonalManagement
{
    partial class FrmRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_NameError = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_ShowPass = new System.Windows.Forms.Button();
            this.pnl_Strength = new System.Windows.Forms.Panel();
            this.pnl_StrengthFill = new System.Windows.Forms.Panel();
            this.lbl_Strength = new System.Windows.Forms.Label();
            this.lbl_PassConfirm = new System.Windows.Forms.Label();
            this.txt_PassConfirm = new System.Windows.Forms.TextBox();
            this.btn_ShowPass2 = new System.Windows.Forms.Button();
            this.lbl_MatchMsg = new System.Windows.Forms.Label();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            this.pnl_Strength.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Controls.Add(this.lbl_Subtitle);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(617, 133);
            this.pnl_Header.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(31, 24);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(326, 48);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Tạo tài khoản mới";
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(220)))), ((int)(((byte)(200)))));
            this.lbl_Subtitle.Location = new System.Drawing.Point(33, 77);
            this.lbl_Subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(277, 28);
            this.lbl_Subtitle.TabIndex = 1;
            this.lbl_Subtitle.Text = "Personal Finance Management";
            // 
            // pnl_Body
            // 
            this.pnl_Body.BackColor = System.Drawing.Color.White;
            this.pnl_Body.Controls.Add(this.lbl_Name);
            this.pnl_Body.Controls.Add(this.txt_Name);
            this.pnl_Body.Controls.Add(this.lbl_NameError);
            this.pnl_Body.Controls.Add(this.lbl_Pass);
            this.pnl_Body.Controls.Add(this.txt_Pass);
            this.pnl_Body.Controls.Add(this.btn_ShowPass);
            this.pnl_Body.Controls.Add(this.pnl_Strength);
            this.pnl_Body.Controls.Add(this.lbl_Strength);
            this.pnl_Body.Controls.Add(this.lbl_PassConfirm);
            this.pnl_Body.Controls.Add(this.txt_PassConfirm);
            this.pnl_Body.Controls.Add(this.btn_ShowPass2);
            this.pnl_Body.Controls.Add(this.lbl_MatchMsg);
            this.pnl_Body.Controls.Add(this.btn_Accept);
            this.pnl_Body.Controls.Add(this.btn_Exit);
            this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Body.Location = new System.Drawing.Point(0, 133);
            this.pnl_Body.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(31, 21, 31, 21);
            this.pnl_Body.Size = new System.Drawing.Size(617, 440);
            this.pnl_Body.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbl_Name.Location = new System.Drawing.Point(31, 21);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(138, 25);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Tên đăng nhập";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Name.Location = new System.Drawing.Point(31, 51);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(524, 37);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_NameError
            // 
            this.lbl_NameError.AutoSize = true;
            this.lbl_NameError.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_NameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lbl_NameError.Location = new System.Drawing.Point(31, 99);
            this.lbl_NameError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NameError.Name = "lbl_NameError";
            this.lbl_NameError.Size = new System.Drawing.Size(0, 23);
            this.lbl_NameError.TabIndex = 1;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbl_Pass.Location = new System.Drawing.Point(31, 125);
            this.lbl_Pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(93, 25);
            this.lbl_Pass.TabIndex = 2;
            this.lbl_Pass.Text = "Mật khẩu";
            // 
            // txt_Pass
            // 
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_Pass.Location = new System.Drawing.Point(31, 155);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(480, 37);
            this.txt_Pass.TabIndex = 1;
            // 
            // btn_ShowPass
            // 
            this.btn_ShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btn_ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPass.FlatAppearance.BorderSize = 0;
            this.btn_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_ShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_ShowPass.Location = new System.Drawing.Point(514, 155);
            this.btn_ShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowPass.Name = "btn_ShowPass";
            this.btn_ShowPass.Size = new System.Drawing.Size(41, 43);
            this.btn_ShowPass.TabIndex = 3;
            this.btn_ShowPass.TabStop = false;
            this.btn_ShowPass.Text = "👁";
            this.btn_ShowPass.UseVisualStyleBackColor = false;
            this.btn_ShowPass.Click += new System.EventHandler(this.btn_ShowPass_Click);
            // 
            // pnl_Strength
            // 
            this.pnl_Strength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnl_Strength.Controls.Add(this.pnl_StrengthFill);
            this.pnl_Strength.Location = new System.Drawing.Point(31, 205);
            this.pnl_Strength.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Strength.Name = "pnl_Strength";
            this.pnl_Strength.Size = new System.Drawing.Size(525, 7);
            this.pnl_Strength.TabIndex = 4;
            // 
            // pnl_StrengthFill
            // 
            this.pnl_StrengthFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnl_StrengthFill.Location = new System.Drawing.Point(0, 0);
            this.pnl_StrengthFill.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_StrengthFill.Name = "pnl_StrengthFill";
            this.pnl_StrengthFill.Size = new System.Drawing.Size(0, 7);
            this.pnl_StrengthFill.TabIndex = 0;
            // 
            // lbl_Strength
            // 
            this.lbl_Strength.AutoSize = true;
            this.lbl_Strength.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_Strength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_Strength.Location = new System.Drawing.Point(31, 216);
            this.lbl_Strength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Strength.Name = "lbl_Strength";
            this.lbl_Strength.Size = new System.Drawing.Size(0, 23);
            this.lbl_Strength.TabIndex = 5;
            // 
            // lbl_PassConfirm
            // 
            this.lbl_PassConfirm.AutoSize = true;
            this.lbl_PassConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_PassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbl_PassConfirm.Location = new System.Drawing.Point(31, 248);
            this.lbl_PassConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PassConfirm.Name = "lbl_PassConfirm";
            this.lbl_PassConfirm.Size = new System.Drawing.Size(176, 25);
            this.lbl_PassConfirm.TabIndex = 6;
            this.lbl_PassConfirm.Text = "Xác nhận mật khẩu";
            // 
            // txt_PassConfirm
            // 
            this.txt_PassConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txt_PassConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PassConfirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_PassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_PassConfirm.Location = new System.Drawing.Point(31, 277);
            this.txt_PassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PassConfirm.Name = "txt_PassConfirm";
            this.txt_PassConfirm.PasswordChar = '*';
            this.txt_PassConfirm.Size = new System.Drawing.Size(480, 37);
            this.txt_PassConfirm.TabIndex = 2;
            this.txt_PassConfirm.TextChanged += new System.EventHandler(this.txt_PassConfirm_TextChanged);
            // 
            // btn_ShowPass2
            // 
            this.btn_ShowPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.btn_ShowPass2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPass2.FlatAppearance.BorderSize = 0;
            this.btn_ShowPass2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPass2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_ShowPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_ShowPass2.Location = new System.Drawing.Point(514, 277);
            this.btn_ShowPass2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowPass2.Name = "btn_ShowPass2";
            this.btn_ShowPass2.Size = new System.Drawing.Size(41, 43);
            this.btn_ShowPass2.TabIndex = 7;
            this.btn_ShowPass2.TabStop = false;
            this.btn_ShowPass2.Text = "👁";
            this.btn_ShowPass2.UseVisualStyleBackColor = false;
            this.btn_ShowPass2.Click += new System.EventHandler(this.btn_ShowPass2_Click);
            // 
            // lbl_MatchMsg
            // 
            this.lbl_MatchMsg.AutoSize = true;
            this.lbl_MatchMsg.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_MatchMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_MatchMsg.Location = new System.Drawing.Point(31, 325);
            this.lbl_MatchMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MatchMsg.Name = "lbl_MatchMsg";
            this.lbl_MatchMsg.Size = new System.Drawing.Size(0, 23);
            this.lbl_MatchMsg.TabIndex = 8;
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.btn_Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accept.FlatAppearance.BorderSize = 0;
            this.btn_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accept.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Accept.ForeColor = System.Drawing.Color.White;
            this.btn_Accept.Location = new System.Drawing.Point(31, 363);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(252, 56);
            this.btn_Accept.TabIndex = 3;
            this.btn_Accept.Text = "Đăng ký";
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Exit.Location = new System.Drawing.Point(303, 363);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(252, 56);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // form_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 573);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "form_Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản — Finance Manager";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Body.ResumeLayout(false);
            this.pnl_Body.PerformLayout();
            this.pnl_Strength.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_NameError;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_ShowPass;
        private System.Windows.Forms.Panel pnl_Strength;
        private System.Windows.Forms.Panel pnl_StrengthFill;
        private System.Windows.Forms.Label lbl_Strength;
        private System.Windows.Forms.Label lbl_PassConfirm;
        private System.Windows.Forms.TextBox txt_PassConfirm;
        private System.Windows.Forms.Button btn_ShowPass2;
        private System.Windows.Forms.Label lbl_MatchMsg;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Exit;
    }
}