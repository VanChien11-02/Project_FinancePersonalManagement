namespace Project_FinancePersonalManagement
{
    partial class FrmVayNo
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
            this.dgv_dsVayMuon = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_DiVay = new System.Windows.Forms.RadioButton();
            this.rb_ChoMuon = new System.Windows.Forms.RadioButton();
            this.rb_TatCa = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_TienCanThanhToan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TienThanhToan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.cbo_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.txt_LaiSuat = new System.Windows.Forms.TextBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_Tien = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.rb_ToiChoMuon = new System.Windows.Forms.RadioButton();
            this.rb_ToiVay = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_Expense = new System.Windows.Forms.Panel();
            this.lblTotal_ChoMuon = new System.Windows.Forms.Label();
            this.lblTitleExpense = new System.Windows.Forms.Label();
            this.panel_income = new System.Windows.Forms.Panel();
            this.lblTotal_No = new System.Windows.Forms.Label();
            this.lblTitleIncome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsVayMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Expense.SuspendLayout();
            this.panel_income.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_dsVayMuon
            // 
            this.dgv_dsVayMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsVayMuon.Location = new System.Drawing.Point(12, 379);
            this.dgv_dsVayMuon.Name = "dgv_dsVayMuon";
            this.dgv_dsVayMuon.RowHeadersWidth = 62;
            this.dgv_dsVayMuon.RowTemplate.Height = 28;
            this.dgv_dsVayMuon.Size = new System.Drawing.Size(877, 222);
            this.dgv_dsVayMuon.TabIndex = 17;
            this.dgv_dsVayMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsVayMuon_CellClick);
            this.dgv_dsVayMuon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_dsVayMuon_DataBindingComplete);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(13, 314);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 32);
            this.btn_Them.TabIndex = 18;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(173, 314);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 32);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ThanhToan.Location = new System.Drawing.Point(329, 314);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(110, 32);
            this.btn_ThanhToan.TabIndex = 21;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.rb_DiVay);
            this.panel1.Controls.Add(this.rb_ChoMuon);
            this.panel1.Controls.Add(this.rb_TatCa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 33);
            this.panel1.TabIndex = 25;
            // 
            // rb_DiVay
            // 
            this.rb_DiVay.AutoSize = true;
            this.rb_DiVay.Location = new System.Drawing.Point(296, 4);
            this.rb_DiVay.Name = "rb_DiVay";
            this.rb_DiVay.Size = new System.Drawing.Size(76, 24);
            this.rb_DiVay.TabIndex = 27;
            this.rb_DiVay.TabStop = true;
            this.rb_DiVay.Text = "Đi vay";
            this.rb_DiVay.UseVisualStyleBackColor = true;
            this.rb_DiVay.CheckedChanged += new System.EventHandler(this.rb_DiVay_CheckedChanged);
            // 
            // rb_ChoMuon
            // 
            this.rb_ChoMuon.AutoSize = true;
            this.rb_ChoMuon.Location = new System.Drawing.Point(437, 4);
            this.rb_ChoMuon.Name = "rb_ChoMuon";
            this.rb_ChoMuon.Size = new System.Drawing.Size(107, 24);
            this.rb_ChoMuon.TabIndex = 26;
            this.rb_ChoMuon.TabStop = true;
            this.rb_ChoMuon.Text = "Cho mượn";
            this.rb_ChoMuon.UseVisualStyleBackColor = true;
            this.rb_ChoMuon.CheckedChanged += new System.EventHandler(this.rb_ChoMuon_CheckedChanged);
            // 
            // rb_TatCa
            // 
            this.rb_TatCa.AutoSize = true;
            this.rb_TatCa.Location = new System.Drawing.Point(149, 4);
            this.rb_TatCa.Name = "rb_TatCa";
            this.rb_TatCa.Size = new System.Drawing.Size(78, 24);
            this.rb_TatCa.TabIndex = 25;
            this.rb_TatCa.TabStop = true;
            this.rb_TatCa.Text = "Tất cả";
            this.rb_TatCa.UseVisualStyleBackColor = true;
            this.rb_TatCa.CheckedChanged += new System.EventHandler(this.rb_TatCa_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.txt_TienCanThanhToan);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_TienThanhToan);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_SoDu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dtp_DenNgay);
            this.panel2.Controls.Add(this.dtp_TuNgay);
            this.panel2.Controls.Add(this.cbo_TaiKhoan);
            this.panel2.Controls.Add(this.txt_LaiSuat);
            this.panel2.Controls.Add(this.txt_Note);
            this.panel2.Controls.Add(this.txt_Tien);
            this.panel2.Controls.Add(this.txt_Ten);
            this.panel2.Controls.Add(this.rb_ToiChoMuon);
            this.panel2.Controls.Add(this.rb_ToiVay);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 248);
            this.panel2.TabIndex = 26;
            // 
            // txt_TienCanThanhToan
            // 
            this.txt_TienCanThanhToan.Location = new System.Drawing.Point(593, 168);
            this.txt_TienCanThanhToan.Name = "txt_TienCanThanhToan";
            this.txt_TienCanThanhToan.Size = new System.Drawing.Size(212, 26);
            this.txt_TienCanThanhToan.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Số tiền gốc + lại còn lại:";
            // 
            // txt_TienThanhToan
            // 
            this.txt_TienThanhToan.Location = new System.Drawing.Point(593, 129);
            this.txt_TienThanhToan.Name = "txt_TienThanhToan";
            this.txt_TienThanhToan.Size = new System.Drawing.Size(212, 26);
            this.txt_TienThanhToan.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Số tiền thanh toán:";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.Location = new System.Drawing.Point(139, 210);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Size = new System.Drawing.Size(212, 26);
            this.txt_SoDu.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Số dư:";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DenNgay.Location = new System.Drawing.Point(593, 83);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(211, 26);
            this.dtp_DenNgay.TabIndex = 33;
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TuNgay.Location = new System.Drawing.Point(593, 40);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(212, 26);
            this.dtp_TuNgay.TabIndex = 32;
            // 
            // cbo_TaiKhoan
            // 
            this.cbo_TaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TaiKhoan.FormattingEnabled = true;
            this.cbo_TaiKhoan.Location = new System.Drawing.Point(139, 166);
            this.cbo_TaiKhoan.Name = "cbo_TaiKhoan";
            this.cbo_TaiKhoan.Size = new System.Drawing.Size(211, 28);
            this.cbo_TaiKhoan.TabIndex = 31;
            this.cbo_TaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbo_TaiKhoan_SelectedIndexChanged);
            // 
            // txt_LaiSuat
            // 
            this.txt_LaiSuat.Location = new System.Drawing.Point(194, 126);
            this.txt_LaiSuat.Name = "txt_LaiSuat";
            this.txt_LaiSuat.Size = new System.Drawing.Size(156, 26);
            this.txt_LaiSuat.TabIndex = 30;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(593, 207);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(212, 38);
            this.txt_Note.TabIndex = 29;
            // 
            // txt_Tien
            // 
            this.txt_Tien.Location = new System.Drawing.Point(138, 85);
            this.txt_Tien.Name = "txt_Tien";
            this.txt_Tien.Size = new System.Drawing.Size(212, 26);
            this.txt_Tien.TabIndex = 28;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(138, 42);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(212, 26);
            this.txt_Ten.TabIndex = 27;
            // 
            // rb_ToiChoMuon
            // 
            this.rb_ToiChoMuon.AutoSize = true;
            this.rb_ToiChoMuon.Location = new System.Drawing.Point(317, 12);
            this.rb_ToiChoMuon.Name = "rb_ToiChoMuon";
            this.rb_ToiChoMuon.Size = new System.Drawing.Size(129, 24);
            this.rb_ToiChoMuon.TabIndex = 26;
            this.rb_ToiChoMuon.TabStop = true;
            this.rb_ToiChoMuon.Text = "Tôi cho mượn";
            this.rb_ToiChoMuon.UseVisualStyleBackColor = true;
            // 
            // rb_ToiVay
            // 
            this.rb_ToiVay.AutoSize = true;
            this.rb_ToiVay.Location = new System.Drawing.Point(149, 12);
            this.rb_ToiVay.Name = "rb_ToiVay";
            this.rb_ToiVay.Size = new System.Drawing.Size(82, 24);
            this.rb_ToiVay.TabIndex = 25;
            this.rb_ToiVay.TabStop = true;
            this.rb_ToiVay.Text = "Tôi vay";
            this.rb_ToiVay.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Hạn trả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày vay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lãi suất(%/tháng):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Số tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Loại:";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(494, 314);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(110, 32);
            this.btn_Reset.TabIndex = 27;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(662, 314);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(110, 32);
            this.btn_Thoat.TabIndex = 28;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 353);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(225, 23);
            this.lbl_title.TabIndex = 34;
            this.lbl_title.Text = "danh sách vay / cho mượn";
            // 
            // panel_Expense
            // 
            this.panel_Expense.BackColor = System.Drawing.Color.Tomato;
            this.panel_Expense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Expense.Controls.Add(this.lblTotal_ChoMuon);
            this.panel_Expense.Controls.Add(this.lblTitleExpense);
            this.panel_Expense.Location = new System.Drawing.Point(449, 621);
            this.panel_Expense.Name = "panel_Expense";
            this.panel_Expense.Size = new System.Drawing.Size(354, 61);
            this.panel_Expense.TabIndex = 40;
            // 
            // lblTotal_ChoMuon
            // 
            this.lblTotal_ChoMuon.AutoSize = true;
            this.lblTotal_ChoMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal_ChoMuon.Location = new System.Drawing.Point(29, 30);
            this.lblTotal_ChoMuon.Name = "lblTotal_ChoMuon";
            this.lblTotal_ChoMuon.Size = new System.Drawing.Size(115, 29);
            this.lblTotal_ChoMuon.TabIndex = 1;
            this.lblTotal_ChoMuon.Text = "000 VNĐ";
            // 
            // lblTitleExpense
            // 
            this.lblTitleExpense.AutoSize = true;
            this.lblTitleExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleExpense.Location = new System.Drawing.Point(30, 0);
            this.lblTitleExpense.Name = "lblTitleExpense";
            this.lblTitleExpense.Size = new System.Drawing.Size(211, 25);
            this.lblTitleExpense.TabIndex = 0;
            this.lblTitleExpense.Text = "Tổng số tiền cho mượn";
            // 
            // panel_income
            // 
            this.panel_income.BackColor = System.Drawing.Color.Lime;
            this.panel_income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_income.Controls.Add(this.lblTotal_No);
            this.panel_income.Controls.Add(this.lblTitleIncome);
            this.panel_income.Location = new System.Drawing.Point(85, 621);
            this.panel_income.Name = "panel_income";
            this.panel_income.Size = new System.Drawing.Size(333, 61);
            this.panel_income.TabIndex = 41;
            // 
            // lblTotal_No
            // 
            this.lblTotal_No.AutoSize = true;
            this.lblTotal_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal_No.Location = new System.Drawing.Point(20, 30);
            this.lblTotal_No.Name = "lblTotal_No";
            this.lblTotal_No.Size = new System.Drawing.Size(115, 29);
            this.lblTotal_No.TabIndex = 1;
            this.lblTotal_No.Text = "000 VNĐ";
            // 
            // lblTitleIncome
            // 
            this.lblTitleIncome.AutoSize = true;
            this.lblTitleIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleIncome.Location = new System.Drawing.Point(21, 0);
            this.lblTitleIncome.Name = "lblTitleIncome";
            this.lblTitleIncome.Size = new System.Drawing.Size(153, 25);
            this.lblTitleIncome.TabIndex = 0;
            this.lblTitleIncome.Text = "Tổng số tiền nợ:";
            // 
            // form_KhoanVay_ChoVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 694);
            this.Controls.Add(this.panel_Expense);
            this.Controls.Add(this.panel_income);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_dsVayMuon);
            this.Name = "form_KhoanVay_ChoVay";
            this.Text = "Quản lý khoản vay / cho vay";
            this.Load += new System.EventHandler(this.form_KhoanVay_ChoVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsVayMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Expense.ResumeLayout(false);
            this.panel_Expense.PerformLayout();
            this.panel_income.ResumeLayout(false);
            this.panel_income.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_dsVayMuon;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_DiVay;
        private System.Windows.Forms.RadioButton rb_ChoMuon;
        private System.Windows.Forms.RadioButton rb_TatCa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.ComboBox cbo_TaiKhoan;
        private System.Windows.Forms.TextBox txt_LaiSuat;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_Tien;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.RadioButton rb_ToiChoMuon;
        private System.Windows.Forms.RadioButton rb_ToiVay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_Expense;
        private System.Windows.Forms.Label lblTotal_ChoMuon;
        private System.Windows.Forms.Label lblTitleExpense;
        private System.Windows.Forms.Panel panel_income;
        private System.Windows.Forms.Label lblTotal_No;
        private System.Windows.Forms.Label lblTitleIncome;
        private System.Windows.Forms.TextBox txt_SoDu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TienCanThanhToan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TienThanhToan;
        private System.Windows.Forms.Label label11;
    }
}