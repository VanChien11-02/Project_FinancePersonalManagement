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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_RePass = new System.Windows.Forms.TextBox();
            this.btn_ViewPass = new System.Windows.Forms.Button();
            this.lbl_Strength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(40, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(611, 31);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Chào mừng đến với Personal Finance Management";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(295, 268);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 29);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(163, 268);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(104, 29);
            this.btn_Accept.TabIndex = 11;
            this.btn_Accept.Text = "Xác nhận";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(253, 174);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(290, 22);
            this.txt_Pass.TabIndex = 10;
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(253, 130);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(290, 22);
            this.txt_Name.TabIndex = 9;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Pass.Location = new System.Drawing.Point(160, 180);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(64, 16);
            this.lbl_Pass.TabIndex = 8;
            this.lbl_Pass.Text = "Mật khẩu:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Name.Location = new System.Drawing.Point(124, 130);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(101, 16);
            this.lbl_Name.TabIndex = 7;
            this.lbl_Name.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập lại mật khẩu:";
            // 
            // txt_RePass
            // 
            this.txt_RePass.Location = new System.Drawing.Point(253, 226);
            this.txt_RePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_RePass.Name = "txt_RePass";
            this.txt_RePass.Size = new System.Drawing.Size(290, 22);
            this.txt_RePass.TabIndex = 15;
            this.txt_RePass.UseSystemPasswordChar = true;
            // 
            // btn_ViewPass
            // 
            this.btn_ViewPass.Location = new System.Drawing.Point(428, 268);
            this.btn_ViewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ViewPass.Name = "btn_ViewPass";
            this.btn_ViewPass.Size = new System.Drawing.Size(123, 29);
            this.btn_ViewPass.TabIndex = 16;
            this.btn_ViewPass.Text = "Xem mật khẩu";
            this.btn_ViewPass.UseVisualStyleBackColor = true;
            this.btn_ViewPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ViewPass_MouseDown);
            this.btn_ViewPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ViewPass_MouseUp);
            // 
            // lbl_Strength
            // 
            this.lbl_Strength.AutoSize = true;
            this.lbl_Strength.Location = new System.Drawing.Point(250, 202);
            this.lbl_Strength.Name = "lbl_Strength";
            this.lbl_Strength.Size = new System.Drawing.Size(130, 16);
            this.lbl_Strength.TabIndex = 17;
            this.lbl_Strength.Text = "Độ mạnh: Chưa nhập";
            // 
            // form_Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.lbl_Strength);
            this.Controls.Add(this.btn_ViewPass);
            this.Controls.Add(this.txt_RePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Name);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Kí";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RePass;
        private System.Windows.Forms.Button btn_ViewPass;
        private System.Windows.Forms.Label lbl_Strength;
    }
}