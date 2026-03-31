namespace Project_FinancePersonalManagement
{
    partial class form_Sign_In
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_ViewPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Name.Location = new System.Drawing.Point(72, 93);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(101, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Tên đăng nhập:";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Pass.Location = new System.Drawing.Point(109, 144);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(64, 16);
            this.lbl_Pass.TabIndex = 1;
            this.lbl_Pass.Text = "Mật khẩu:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(185, 90);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(290, 22);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(185, 141);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(290, 22);
            this.txt_Pass.TabIndex = 3;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(118, 229);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(104, 29);
            this.btn_Accept.TabIndex = 4;
            this.btn_Accept.Text = "Xác nhận";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(445, 229);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 29);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(179, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 35);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Chào mừng bạn trở lại";
            // 
            // btn_ViewPass
            // 
            this.btn_ViewPass.Location = new System.Drawing.Point(263, 229);
            this.btn_ViewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ViewPass.Name = "btn_ViewPass";
            this.btn_ViewPass.Size = new System.Drawing.Size(141, 29);
            this.btn_ViewPass.TabIndex = 7;
            this.btn_ViewPass.Text = "Xem mật khẩu";
            this.btn_ViewPass.UseVisualStyleBackColor = true;
            this.btn_ViewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ViewPass_MouseDown);
            this.btn_ViewPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ViewPass_MouseUp);
            // 
            // form_Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btn_ViewPass);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_Sign_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_ViewPass;
    }
}