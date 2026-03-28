namespace Project_FinancePersonalManagement
{
    partial class form_GiaoDich
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
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_ChuyenDenTK = new System.Windows.Forms.ComboBox();
            this.lbl_ChuyenDenTK = new System.Windows.Forms.Label();
            this.dtp_NgayGD = new System.Windows.Forms.DateTimePicker();
            this.cbo_LoaiGD = new System.Windows.Forms.ComboBox();
            this.cbo_DanhMuc = new System.Windows.Forms.ComboBox();
            this.cbo_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_Tien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Expense = new System.Windows.Forms.Panel();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblTitleExpense = new System.Windows.Forms.Label();
            this.panel_income = new System.Windows.Forms.Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTitleIncome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_Expense.SuspendLayout();
            this.panel_income.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDich.Location = new System.Drawing.Point(24, 393);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.RowHeadersWidth = 62;
            this.dgvGiaoDich.RowTemplate.Height = 28;
            this.dgvGiaoDich.Size = new System.Drawing.Size(878, 183);
            this.dgvGiaoDich.TabIndex = 12;
            this.dgvGiaoDich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoDich_CellClick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(562, 245);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(104, 39);
            this.btn_Reset.TabIndex = 25;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(247, 245);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 39);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(82, 245);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 39);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(726, 245);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(104, 39);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(405, 245);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 39);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btn_Loc);
            this.panel1.Controls.Add(this.dtp_DenNgay);
            this.panel1.Controls.Add(this.dtp_TuNgay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(24, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 62);
            this.panel1.TabIndex = 35;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(702, 12);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(104, 39);
            this.btn_Loc.TabIndex = 39;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DenNgay.Location = new System.Drawing.Point(452, 16);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(152, 26);
            this.dtp_DenNgay.TabIndex = 38;
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TuNgay.Location = new System.Drawing.Point(144, 16);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(147, 26);
            this.dtp_TuNgay.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(355, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Đến ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(50, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Từ ngày:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Danh sách giao dịch";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.txt_SoDu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbo_ChuyenDenTK);
            this.panel2.Controls.Add(this.lbl_ChuyenDenTK);
            this.panel2.Controls.Add(this.dtp_NgayGD);
            this.panel2.Controls.Add(this.cbo_LoaiGD);
            this.panel2.Controls.Add(this.cbo_DanhMuc);
            this.panel2.Controls.Add(this.cbo_TaiKhoan);
            this.panel2.Controls.Add(this.txt_Note);
            this.panel2.Controls.Add(this.txt_Tien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 218);
            this.panel2.TabIndex = 37;
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.Location = new System.Drawing.Point(196, 56);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.ReadOnly = true;
            this.txt_SoDu.Size = new System.Drawing.Size(221, 26);
            this.txt_SoDu.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Số dư:";
            // 
            // cbo_ChuyenDenTK
            // 
            this.cbo_ChuyenDenTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ChuyenDenTK.FormattingEnabled = true;
            this.cbo_ChuyenDenTK.Location = new System.Drawing.Point(264, 182);
            this.cbo_ChuyenDenTK.Name = "cbo_ChuyenDenTK";
            this.cbo_ChuyenDenTK.Size = new System.Drawing.Size(221, 28);
            this.cbo_ChuyenDenTK.TabIndex = 45;
            // 
            // lbl_ChuyenDenTK
            // 
            this.lbl_ChuyenDenTK.AutoSize = true;
            this.lbl_ChuyenDenTK.Location = new System.Drawing.Point(80, 185);
            this.lbl_ChuyenDenTK.Name = "lbl_ChuyenDenTK";
            this.lbl_ChuyenDenTK.Size = new System.Drawing.Size(167, 20);
            this.lbl_ChuyenDenTK.TabIndex = 44;
            this.lbl_ChuyenDenTK.Text = "Chuyển đến tài khoản:";
            // 
            // dtp_NgayGD
            // 
            this.dtp_NgayGD.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayGD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayGD.Location = new System.Drawing.Point(588, 57);
            this.dtp_NgayGD.Name = "dtp_NgayGD";
            this.dtp_NgayGD.Size = new System.Drawing.Size(206, 26);
            this.dtp_NgayGD.TabIndex = 43;
            // 
            // cbo_LoaiGD
            // 
            this.cbo_LoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiGD.FormattingEnabled = true;
            this.cbo_LoaiGD.Location = new System.Drawing.Point(196, 98);
            this.cbo_LoaiGD.Name = "cbo_LoaiGD";
            this.cbo_LoaiGD.Size = new System.Drawing.Size(221, 28);
            this.cbo_LoaiGD.TabIndex = 42;
            this.cbo_LoaiGD.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiGD_SelectedIndexChanged);
            // 
            // cbo_DanhMuc
            // 
            this.cbo_DanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DanhMuc.FormattingEnabled = true;
            this.cbo_DanhMuc.Location = new System.Drawing.Point(196, 140);
            this.cbo_DanhMuc.Name = "cbo_DanhMuc";
            this.cbo_DanhMuc.Size = new System.Drawing.Size(221, 28);
            this.cbo_DanhMuc.TabIndex = 41;
            // 
            // cbo_TaiKhoan
            // 
            this.cbo_TaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TaiKhoan.FormattingEnabled = true;
            this.cbo_TaiKhoan.Location = new System.Drawing.Point(196, 16);
            this.cbo_TaiKhoan.Name = "cbo_TaiKhoan";
            this.cbo_TaiKhoan.Size = new System.Drawing.Size(221, 28);
            this.cbo_TaiKhoan.TabIndex = 40;
            this.cbo_TaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbo_TaiKhoan_SelectedIndexChanged);
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(588, 98);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(207, 112);
            this.txt_Note.TabIndex = 39;
            // 
            // txt_Tien
            // 
            this.txt_Tien.Location = new System.Drawing.Point(588, 17);
            this.txt_Tien.Name = "txt_Tien";
            this.txt_Tien.Size = new System.Drawing.Size(207, 26);
            this.txt_Tien.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Danh mục:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Loại giao dịch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tài khoản:";
            // 
            // panel_Expense
            // 
            this.panel_Expense.BackColor = System.Drawing.Color.Tomato;
            this.panel_Expense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Expense.Controls.Add(this.lblTotalExpense);
            this.panel_Expense.Controls.Add(this.lblTitleExpense);
            this.panel_Expense.Location = new System.Drawing.Point(472, 582);
            this.panel_Expense.Name = "panel_Expense";
            this.panel_Expense.Size = new System.Drawing.Size(354, 61);
            this.panel_Expense.TabIndex = 38;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpense.Location = new System.Drawing.Point(29, 30);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(115, 29);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "000 VNĐ";
            // 
            // lblTitleExpense
            // 
            this.lblTitleExpense.AutoSize = true;
            this.lblTitleExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleExpense.Location = new System.Drawing.Point(30, 0);
            this.lblTitleExpense.Name = "lblTitleExpense";
            this.lblTitleExpense.Size = new System.Drawing.Size(88, 25);
            this.lblTitleExpense.TabIndex = 0;
            this.lblTitleExpense.Text = "Tổng chi";
            // 
            // panel_income
            // 
            this.panel_income.BackColor = System.Drawing.Color.Lime;
            this.panel_income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_income.Controls.Add(this.lblTotalIncome);
            this.panel_income.Controls.Add(this.lblTitleIncome);
            this.panel_income.Location = new System.Drawing.Point(108, 582);
            this.panel_income.Name = "panel_income";
            this.panel_income.Size = new System.Drawing.Size(333, 61);
            this.panel_income.TabIndex = 39;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalIncome.Location = new System.Drawing.Point(20, 30);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(115, 29);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "000 VNĐ";
            // 
            // lblTitleIncome
            // 
            this.lblTitleIncome.AutoSize = true;
            this.lblTitleIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleIncome.Location = new System.Drawing.Point(21, 0);
            this.lblTitleIncome.Name = "lblTitleIncome";
            this.lblTitleIncome.Size = new System.Drawing.Size(90, 25);
            this.lblTitleIncome.TabIndex = 0;
            this.lblTitleIncome.Text = "Tổng thu";
            // 
            // form_GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 650);
            this.Controls.Add(this.panel_Expense);
            this.Controls.Add(this.panel_income);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dgvGiaoDich);
            this.Name = "form_GiaoDich";
            this.Text = "Quản lý giao dịch";
            this.Load += new System.EventHandler(this.form_GiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvGiaoDich;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_NgayGD;
        private System.Windows.Forms.ComboBox cbo_LoaiGD;
        private System.Windows.Forms.ComboBox cbo_DanhMuc;
        private System.Windows.Forms.ComboBox cbo_TaiKhoan;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_Tien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ChuyenDenTK;
        private System.Windows.Forms.Label lbl_ChuyenDenTK;
        private System.Windows.Forms.Panel panel_Expense;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblTitleExpense;
        private System.Windows.Forms.Panel panel_income;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTitleIncome;
        private System.Windows.Forms.TextBox txt_SoDu;
        private System.Windows.Forms.Label label10;
    }
}