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
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Name.Location = new System.Drawing.Point(81, 116);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(101, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Tên của bạn:";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Pass.Location = new System.Drawing.Point(103, 182);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(79, 20);
            this.lbl_Pass.TabIndex = 1;
            this.lbl_Pass.Text = "Mật khẩu:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(208, 113);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(326, 26);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(208, 176);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(326, 26);
            this.txt_Pass.TabIndex = 3;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(208, 286);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(117, 36);
            this.btn_Accept.TabIndex = 4;
            this.btn_Accept.Text = "Xác nhận";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(417, 286);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 36);
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
            this.lblTitle.Location = new System.Drawing.Point(201, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(364, 41);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Chào mừng bạn trở lại";
            // 
            // form_Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Name);
            this.Name = "form_Sign_In";
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
    }
}