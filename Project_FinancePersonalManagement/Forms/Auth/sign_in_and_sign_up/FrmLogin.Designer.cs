namespace Project_FinancePersonalManagement
{
    partial class FrmLogin
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
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_ShowPass = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Body.SuspendLayout();
            this.SuspendLayout();

            // ── pnl_Header ──────────────────────────────────────────────
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Size = new System.Drawing.Size(480, 100);
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Controls.Add(this.lbl_Subtitle);

            // ── lbl_Title ────────────────────────────────────────────────
            this.lbl_Title.Text = "Chào mừng trở lại";
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(24, 18);

            // ── lbl_Subtitle ─────────────────────────────────────────────
            this.lbl_Subtitle.Text = "Personal Finance Management";
            this.lbl_Subtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.FromArgb(180, 220, 255);
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Location = new System.Drawing.Point(26, 58);

            // ── pnl_Body ─────────────────────────────────────────────────
            this.pnl_Body.BackColor = System.Drawing.Color.White;
            this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Body.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.pnl_Body.Controls.Add(this.lbl_Name);
            this.pnl_Body.Controls.Add(this.txt_Name);
            this.pnl_Body.Controls.Add(this.lbl_Pass);
            this.pnl_Body.Controls.Add(this.txt_Pass);
            this.pnl_Body.Controls.Add(this.btn_ShowPass);
            this.pnl_Body.Controls.Add(this.lbl_Error);
            this.pnl_Body.Controls.Add(this.btn_Accept);
            this.pnl_Body.Controls.Add(this.btn_Exit);

            // ── lbl_Name ─────────────────────────────────────────────────
            this.lbl_Name.Text = "Tên đăng nhập";
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(24, 24);

            // ── txt_Name ─────────────────────────────────────────────────
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Name.Location = new System.Drawing.Point(24, 46);
            this.txt_Name.Size = new System.Drawing.Size(408, 32);
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txt_Name.TabIndex = 0;

            // ── lbl_Pass ─────────────────────────────────────────────────
            this.lbl_Pass.Text = "Mật khẩu";
            this.lbl_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Pass.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(24, 96);

            // ── txt_Pass ─────────────────────────────────────────────────
            this.txt_Pass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Pass.Location = new System.Drawing.Point(24, 118);
            this.txt_Pass.Size = new System.Drawing.Size(374, 32);
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Pass.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.txt_Pass.TabIndex = 1;

            // ── btn_ShowPass ─────────────────────────────────────────────
            this.btn_ShowPass.Text = "👁";
            this.btn_ShowPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_ShowPass.Location = new System.Drawing.Point(400, 118);
            this.btn_ShowPass.Size = new System.Drawing.Size(32, 32);
            this.btn_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowPass.FlatAppearance.BorderSize = 0;
            this.btn_ShowPass.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.btn_ShowPass.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btn_ShowPass.TabStop = false;
            this.btn_ShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowPass.Click += new System.EventHandler(this.btn_ShowPass_Click);

            // ── lbl_Error ────────────────────────────────────────────────
            this.lbl_Error.Text = "";
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Error.ForeColor = System.Drawing.Color.FromArgb(194, 35, 35);
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(24, 158);
            this.lbl_Error.Size = new System.Drawing.Size(408, 20);

            // ── btn_Accept ───────────────────────────────────────────────
            this.btn_Accept.Text = "Đăng nhập";
            this.btn_Accept.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Accept.Location = new System.Drawing.Point(24, 186);
            this.btn_Accept.Size = new System.Drawing.Size(196, 42);
            this.btn_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accept.FlatAppearance.BorderSize = 0;
            this.btn_Accept.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btn_Accept.ForeColor = System.Drawing.Color.White;
            this.btn_Accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);

            // ── btn_Exit ─────────────────────────────────────────────────
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Exit.Location = new System.Drawing.Point(236, 186);
            this.btn_Exit.Size = new System.Drawing.Size(196, 42);
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);

            // ── form_Sign_In ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 380);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập — Finance Manager";
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Header);

            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Body.ResumeLayout(false);
            this.pnl_Body.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_ShowPass;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Exit;
    }
}