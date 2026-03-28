namespace Project_FinancePersonalManagement
{
    partial class form_Sign_Up
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(45, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(718, 36);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Chào mừng đến với Personal Finance Management";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(494, 335);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 36);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(285, 335);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(117, 36);
            this.btn_Accept.TabIndex = 11;
            this.btn_Accept.Text = "Xác nhận";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(285, 225);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(326, 26);
            this.txt_Pass.TabIndex = 10;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(285, 162);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(326, 26);
            this.txt_Name.TabIndex = 9;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Pass.Location = new System.Drawing.Point(180, 231);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(79, 20);
            this.lbl_Pass.TabIndex = 8;
            this.lbl_Pass.Text = "Mật khẩu:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Name.Location = new System.Drawing.Point(158, 165);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(101, 20);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Tên của bạn:";
            // 
            // form_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Name);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "form_Sign_Up";
            this.Text = "Đăng ký tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_Name;
    }
}