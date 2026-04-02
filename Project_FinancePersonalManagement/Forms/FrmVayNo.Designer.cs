namespace Project_FinancePersonalManagement
{
    partial class FrmVayNo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTabBar = new System.Windows.Forms.Panel();
            this.rb_ChoMuon = new System.Windows.Forms.RadioButton();
            this.rb_DiVay = new System.Windows.Forms.RadioButton();
            this.rb_TatCa = new System.Windows.Forms.RadioButton();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.pnlInputFields = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_ToiVay = new System.Windows.Forms.RadioButton();
            this.rb_ToiChoMuon = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_LaiSuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TienThanhToan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TienCanThanhToan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.lblCardInput = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgv_dsVayMuon = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.panel_Expense = new System.Windows.Forms.Panel();
            this.lblSubChoMuon = new System.Windows.Forms.Label();
            this.lblTotal_ChoMuon = new System.Windows.Forms.Label();
            this.lblTitleExpense = new System.Windows.Forms.Label();
            this.panel_income = new System.Windows.Forms.Panel();
            this.lblSubNo = new System.Windows.Forms.Label();
            this.lblTotal_No = new System.Windows.Forms.Label();
            this.lblTitleIncome = new System.Windows.Forms.Label();
            this.rb_ChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pnlTabBar.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
            this.pnlInputFields.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsVayMuon)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.panel_Expense.SuspendLayout();
            this.panel_income.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabBar
            // 
            this.pnlTabBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlTabBar.Controls.Add(this.rb_ChuaThanhToan);
            this.pnlTabBar.Controls.Add(this.rb_ChoMuon);
            this.pnlTabBar.Controls.Add(this.rb_DiVay);
            this.pnlTabBar.Controls.Add(this.rb_TatCa);
            this.pnlTabBar.Location = new System.Drawing.Point(0, 291);
            this.pnlTabBar.Name = "pnlTabBar";
            this.pnlTabBar.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnlTabBar.Size = new System.Drawing.Size(1020, 42);
            this.pnlTabBar.TabIndex = 3;
            this.pnlTabBar.Paint += new System.Windows.Forms.PaintEventHandler(this.TabBar_Paint);
            // 
            // rb_ChoMuon
            // 
            this.rb_ChoMuon.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_ChoMuon.BackColor = System.Drawing.Color.White;
            this.rb_ChoMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_ChoMuon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rb_ChoMuon.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.rb_ChoMuon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.rb_ChoMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_ChoMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rb_ChoMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rb_ChoMuon.Location = new System.Drawing.Point(212, 7);
            this.rb_ChoMuon.Name = "rb_ChoMuon";
            this.rb_ChoMuon.Size = new System.Drawing.Size(105, 28);
            this.rb_ChoMuon.TabIndex = 0;
            this.rb_ChoMuon.Text = "  Cho mượn";
            this.rb_ChoMuon.UseVisualStyleBackColor = false;
            this.rb_ChoMuon.CheckedChanged += new System.EventHandler(this.rb_ChoMuon_CheckedChanged);
            // 
            // rb_DiVay
            // 
            this.rb_DiVay.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_DiVay.BackColor = System.Drawing.Color.White;
            this.rb_DiVay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_DiVay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rb_DiVay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.rb_DiVay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.rb_DiVay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_DiVay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rb_DiVay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rb_DiVay.Location = new System.Drawing.Point(114, 7);
            this.rb_DiVay.Name = "rb_DiVay";
            this.rb_DiVay.Size = new System.Drawing.Size(90, 28);
            this.rb_DiVay.TabIndex = 1;
            this.rb_DiVay.Text = "  Đi vay";
            this.rb_DiVay.UseVisualStyleBackColor = false;
            this.rb_DiVay.CheckedChanged += new System.EventHandler(this.rb_DiVay_CheckedChanged);
            // 
            // rb_TatCa
            // 
            this.rb_TatCa.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_TatCa.BackColor = System.Drawing.Color.White;
            this.rb_TatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_TatCa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rb_TatCa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.rb_TatCa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.rb_TatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_TatCa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rb_TatCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rb_TatCa.Location = new System.Drawing.Point(16, 7);
            this.rb_TatCa.Name = "rb_TatCa";
            this.rb_TatCa.Size = new System.Drawing.Size(90, 28);
            this.rb_TatCa.TabIndex = 2;
            this.rb_TatCa.Text = "  Tất cả";
            this.rb_TatCa.UseVisualStyleBackColor = false;
            this.rb_TatCa.CheckedChanged += new System.EventHandler(this.rb_TatCa_CheckedChanged);
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.Controls.Add(this.pnlInputFields);
            this.pnlInputCard.Controls.Add(this.lblCardInput);
            this.pnlInputCard.Location = new System.Drawing.Point(0, 1);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Padding = new System.Windows.Forms.Padding(16, 10, 16, 8);
            this.pnlInputCard.Size = new System.Drawing.Size(1020, 230);
            this.pnlInputCard.TabIndex = 2;
            this.pnlInputCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlInputFields
            // 
            this.pnlInputFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInputFields.BackColor = System.Drawing.Color.Transparent;
            this.pnlInputFields.Controls.Add(this.label1);
            this.pnlInputFields.Controls.Add(this.rb_ToiVay);
            this.pnlInputFields.Controls.Add(this.rb_ToiChoMuon);
            this.pnlInputFields.Controls.Add(this.label2);
            this.pnlInputFields.Controls.Add(this.txt_Ten);
            this.pnlInputFields.Controls.Add(this.label3);
            this.pnlInputFields.Controls.Add(this.txt_Tien);
            this.pnlInputFields.Controls.Add(this.label5);
            this.pnlInputFields.Controls.Add(this.txt_LaiSuat);
            this.pnlInputFields.Controls.Add(this.label4);
            this.pnlInputFields.Controls.Add(this.cbo_TaiKhoan);
            this.pnlInputFields.Controls.Add(this.label10);
            this.pnlInputFields.Controls.Add(this.txt_SoDu);
            this.pnlInputFields.Controls.Add(this.label7);
            this.pnlInputFields.Controls.Add(this.dtp_TuNgay);
            this.pnlInputFields.Controls.Add(this.label8);
            this.pnlInputFields.Controls.Add(this.dtp_DenNgay);
            this.pnlInputFields.Controls.Add(this.label11);
            this.pnlInputFields.Controls.Add(this.txt_TienThanhToan);
            this.pnlInputFields.Controls.Add(this.label12);
            this.pnlInputFields.Controls.Add(this.txt_TienCanThanhToan);
            this.pnlInputFields.Controls.Add(this.label6);
            this.pnlInputFields.Controls.Add(this.txt_Note);
            this.pnlInputFields.Location = new System.Drawing.Point(12, 41);
            this.pnlInputFields.Name = "pnlInputFields";
            this.pnlInputFields.Size = new System.Drawing.Size(1008, 178);
            this.pnlInputFields.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại:";
            // 
            // rb_ToiVay
            // 
            this.rb_ToiVay.AutoSize = true;
            this.rb_ToiVay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rb_ToiVay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rb_ToiVay.Location = new System.Drawing.Point(120, 5);
            this.rb_ToiVay.Name = "rb_ToiVay";
            this.rb_ToiVay.Size = new System.Drawing.Size(62, 19);
            this.rb_ToiVay.TabIndex = 1;
            this.rb_ToiVay.Text = "Tôi vay";
            // 
            // rb_ToiChoMuon
            // 
            this.rb_ToiChoMuon.AutoSize = true;
            this.rb_ToiChoMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rb_ToiChoMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rb_ToiChoMuon.Location = new System.Drawing.Point(220, 5);
            this.rb_ToiChoMuon.Name = "rb_ToiChoMuon";
            this.rb_ToiChoMuon.Size = new System.Drawing.Size(99, 19);
            this.rb_ToiChoMuon.TabIndex = 2;
            this.rb_ToiChoMuon.Text = "Tôi cho mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đối tác:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Ten.Location = new System.Drawing.Point(120, 36);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(185, 23);
            this.txt_Ten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số tiền:";
            // 
            // txt_Tien
            // 
            this.txt_Tien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tien.Location = new System.Drawing.Point(120, 70);
            this.txt_Tien.Name = "txt_Tien";
            this.txt_Tien.Size = new System.Drawing.Size(185, 23);
            this.txt_Tien.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(0, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lãi suất (%/tháng):";
            // 
            // txt_LaiSuat
            // 
            this.txt_LaiSuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_LaiSuat.Location = new System.Drawing.Point(145, 104);
            this.txt_LaiSuat.Name = "txt_LaiSuat";
            this.txt_LaiSuat.Size = new System.Drawing.Size(120, 23);
            this.txt_LaiSuat.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(0, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tài khoản:";
            // 
            // cbo_TaiKhoan
            // 
            this.cbo_TaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_TaiKhoan.FormattingEnabled = true;
            this.cbo_TaiKhoan.Location = new System.Drawing.Point(120, 139);
            this.cbo_TaiKhoan.Name = "cbo_TaiKhoan";
            this.cbo_TaiKhoan.Size = new System.Drawing.Size(185, 23);
            this.cbo_TaiKhoan.TabIndex = 6;
            this.cbo_TaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbo_TaiKhoan_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(320, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Số dư:";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txt_SoDu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoDu.Location = new System.Drawing.Point(382, 139);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.ReadOnly = true;
            this.txt_SoDu.Size = new System.Drawing.Size(145, 23);
            this.txt_SoDu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(560, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày vay:";
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_TuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TuNgay.Location = new System.Drawing.Point(660, 4);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(165, 23);
            this.dtp_TuNgay.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(560, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hạn trả:";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_DenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DenNgay.Location = new System.Drawing.Point(660, 38);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(165, 23);
            this.dtp_DenNgay.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(560, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tiền thanh toán:";
            // 
            // txt_TienThanhToan
            // 
            this.txt_TienThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TienThanhToan.Location = new System.Drawing.Point(660, 72);
            this.txt_TienThanhToan.Name = "txt_TienThanhToan";
            this.txt_TienThanhToan.Size = new System.Drawing.Size(165, 23);
            this.txt_TienThanhToan.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(560, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Còn phải trả:";
            // 
            // txt_TienCanThanhToan
            // 
            this.txt_TienCanThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txt_TienCanThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TienCanThanhToan.Location = new System.Drawing.Point(660, 106);
            this.txt_TienCanThanhToan.Name = "txt_TienCanThanhToan";
            this.txt_TienCanThanhToan.ReadOnly = true;
            this.txt_TienCanThanhToan.Size = new System.Drawing.Size(165, 23);
            this.txt_TienCanThanhToan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(560, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ghi chú:";
            // 
            // txt_Note
            // 
            this.txt_Note.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Note.Location = new System.Drawing.Point(660, 139);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(260, 23);
            this.txt_Note.TabIndex = 12;
            // 
            // lblCardInput
            // 
            this.lblCardInput.AutoSize = true;
            this.lblCardInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCardInput.Location = new System.Drawing.Point(16, 10);
            this.lblCardInput.Name = "lblCardInput";
            this.lblCardInput.Size = new System.Drawing.Size(211, 19);
            this.lblCardInput.TabIndex = 2;
            this.lblCardInput.Text = "Thông tin khoản vay / cho vay";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btn_Xoa);
            this.pnlButtons.Controls.Add(this.btn_Thoat);
            this.pnlButtons.Controls.Add(this.btn_Them);
            this.pnlButtons.Controls.Add(this.btn_Sua);
            this.pnlButtons.Controls.Add(this.btn_ThanhToan);
            this.pnlButtons.Controls.Add(this.btn_Reset);
            this.pnlButtons.Location = new System.Drawing.Point(0, 251);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1020, 34);
            this.pnlButtons.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Cyan;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Thoat.Location = new System.Drawing.Point(650, -1);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 32);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click_1);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.btn_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(95)))), ((int)(((byte)(72)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(0, 0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 32);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btn_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btn_Sua.Location = new System.Drawing.Point(118, 0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 32);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(110)))), ((int)(((byte)(20)))));
            this.btn_ThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(10)))));
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(236, 0);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(125, 32);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Gray;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(378, 0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(108, 32);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Làm mới";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgv_dsVayMuon);
            this.pnlGridCard.Controls.Add(this.lbl_title);
            this.pnlGridCard.Location = new System.Drawing.Point(0, 331);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.pnlGridCard.Size = new System.Drawing.Size(1020, 275);
            this.pnlGridCard.TabIndex = 0;
            this.pnlGridCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // dgv_dsVayMuon
            // 
            this.dgv_dsVayMuon.AllowUserToAddRows = false;
            this.dgv_dsVayMuon.AllowUserToDeleteRows = false;
            this.dgv_dsVayMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dsVayMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dsVayMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dsVayMuon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_dsVayMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsVayMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_dsVayMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dsVayMuon.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_dsVayMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgv_dsVayMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgv_dsVayMuon.Location = new System.Drawing.Point(14, 8);
            this.dgv_dsVayMuon.Name = "dgv_dsVayMuon";
            this.dgv_dsVayMuon.ReadOnly = true;
            this.dgv_dsVayMuon.RowHeadersVisible = false;
            this.dgv_dsVayMuon.RowHeadersWidth = 62;
            this.dgv_dsVayMuon.RowTemplate.Height = 32;
            this.dgv_dsVayMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsVayMuon.Size = new System.Drawing.Size(992, 259);
            this.dgv_dsVayMuon.TabIndex = 0;
            this.dgv_dsVayMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsVayMuon_CellClick);
            this.dgv_dsVayMuon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_dsVayMuon_DataBindingComplete);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_title.Location = new System.Drawing.Point(14, 8);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 19);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Danh sách vay / cho vay";
            // 
            // pnlSummary
            // 
            this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlSummary.Controls.Add(this.panel_Expense);
            this.pnlSummary.Controls.Add(this.panel_income);
            this.pnlSummary.Location = new System.Drawing.Point(0, 606);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlSummary.Size = new System.Drawing.Size(1020, 74);
            this.pnlSummary.TabIndex = 1;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.SummaryBar_Paint);
            // 
            // panel_Expense
            // 
            this.panel_Expense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Expense.BackColor = System.Drawing.Color.White;
            this.panel_Expense.Controls.Add(this.lblSubChoMuon);
            this.panel_Expense.Controls.Add(this.lblTotal_ChoMuon);
            this.panel_Expense.Controls.Add(this.lblTitleExpense);
            this.panel_Expense.Location = new System.Drawing.Point(296, 10);
            this.panel_Expense.Name = "panel_Expense";
            this.panel_Expense.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.panel_Expense.Size = new System.Drawing.Size(280, 54);
            this.panel_Expense.TabIndex = 0;
            this.panel_Expense.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblSubChoMuon
            // 
            this.lblSubChoMuon.AutoSize = true;
            this.lblSubChoMuon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubChoMuon.ForeColor = System.Drawing.Color.Gray;
            this.lblSubChoMuon.Location = new System.Drawing.Point(36, 39);
            this.lblSubChoMuon.Name = "lblSubChoMuon";
            this.lblSubChoMuon.Size = new System.Drawing.Size(130, 13);
            this.lblSubChoMuon.TabIndex = 0;
            this.lblSubChoMuon.Text = "Người khác đang nợ tôi";
            // 
            // lblTotal_ChoMuon
            // 
            this.lblTotal_ChoMuon.AutoSize = true;
            this.lblTotal_ChoMuon.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal_ChoMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.lblTotal_ChoMuon.Location = new System.Drawing.Point(12, 14);
            this.lblTotal_ChoMuon.Name = "lblTotal_ChoMuon";
            this.lblTotal_ChoMuon.Size = new System.Drawing.Size(66, 25);
            this.lblTotal_ChoMuon.TabIndex = 1;
            this.lblTotal_ChoMuon.Text = "0 VNĐ";
            // 
            // lblTitleExpense
            // 
            this.lblTitleExpense.AutoSize = true;
            this.lblTitleExpense.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTitleExpense.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleExpense.Location = new System.Drawing.Point(14, 2);
            this.lblTitleExpense.Name = "lblTitleExpense";
            this.lblTitleExpense.Size = new System.Drawing.Size(129, 12);
            this.lblTitleExpense.TabIndex = 2;
            this.lblTitleExpense.Text = "TỔNG SỐ TIỀN CHO MƯỢN";
            // 
            // panel_income
            // 
            this.panel_income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_income.BackColor = System.Drawing.Color.White;
            this.panel_income.Controls.Add(this.lblSubNo);
            this.panel_income.Controls.Add(this.lblTotal_No);
            this.panel_income.Controls.Add(this.lblTitleIncome);
            this.panel_income.Location = new System.Drawing.Point(16, 10);
            this.panel_income.Name = "panel_income";
            this.panel_income.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.panel_income.Size = new System.Drawing.Size(280, 54);
            this.panel_income.TabIndex = 1;
            this.panel_income.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblSubNo
            // 
            this.lblSubNo.AutoSize = true;
            this.lblSubNo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubNo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubNo.Location = new System.Drawing.Point(39, 39);
            this.lblSubNo.Name = "lblSubNo";
            this.lblSubNo.Size = new System.Drawing.Size(129, 13);
            this.lblSubNo.TabIndex = 0;
            this.lblSubNo.Text = "Tôi đang nợ người khác";
            // 
            // lblTotal_No
            // 
            this.lblTotal_No.AutoSize = true;
            this.lblTotal_No.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTotal_No.Location = new System.Drawing.Point(12, 14);
            this.lblTotal_No.Name = "lblTotal_No";
            this.lblTotal_No.Size = new System.Drawing.Size(66, 25);
            this.lblTotal_No.TabIndex = 1;
            this.lblTotal_No.Text = "0 VNĐ";
            // 
            // lblTitleIncome
            // 
            this.lblTitleIncome.AutoSize = true;
            this.lblTitleIncome.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTitleIncome.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleIncome.Location = new System.Drawing.Point(14, 2);
            this.lblTitleIncome.Name = "lblTitleIncome";
            this.lblTitleIncome.Size = new System.Drawing.Size(90, 12);
            this.lblTitleIncome.TabIndex = 2;
            this.lblTitleIncome.Text = "TỔNG SỐ TIỀN VAY";
            // 
            // rb_ChuaThanhToan
            // 
            this.rb_ChuaThanhToan.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_ChuaThanhToan.BackColor = System.Drawing.Color.White;
            this.rb_ChuaThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_ChuaThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rb_ChuaThanhToan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.rb_ChuaThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.rb_ChuaThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_ChuaThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rb_ChuaThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rb_ChuaThanhToan.Location = new System.Drawing.Point(323, 7);
            this.rb_ChuaThanhToan.Name = "rb_ChuaThanhToan";
            this.rb_ChuaThanhToan.Size = new System.Drawing.Size(116, 28);
            this.rb_ChuaThanhToan.TabIndex = 3;
            this.rb_ChuaThanhToan.Text = "Chưa thanh toán";
            this.rb_ChuaThanhToan.UseVisualStyleBackColor = false;
            this.rb_ChuaThanhToan.CheckedChanged += new System.EventHandler(this.rb_ChuaThanhToan_CheckedChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Xoa.Location = new System.Drawing.Point(513, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(108, 32);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FrmVayNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlGridCard);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlInputCard);
            this.Controls.Add(this.pnlTabBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "FrmVayNo";
            this.Text = "Quản lý khoản vay / cho vay";
            this.Load += new System.EventHandler(this.form_KhoanVay_ChoVay_Load);
            this.pnlTabBar.ResumeLayout(false);
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            this.pnlInputFields.ResumeLayout(false);
            this.pnlInputFields.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsVayMuon)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.panel_Expense.ResumeLayout(false);
            this.panel_Expense.PerformLayout();
            this.panel_income.ResumeLayout(false);
            this.panel_income.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTabBar;
        private System.Windows.Forms.RadioButton rb_TatCa;
        private System.Windows.Forms.RadioButton rb_DiVay;
        private System.Windows.Forms.RadioButton rb_ChoMuon;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblCardInput;
        private System.Windows.Forms.Panel pnlInputFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_ToiVay;
        private System.Windows.Forms.RadioButton rb_ToiChoMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_LaiSuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_TaiKhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SoDu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_TienThanhToan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TienCanThanhToan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv_dsVayMuon;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel panel_income;
        private System.Windows.Forms.Label lblTitleIncome;
        private System.Windows.Forms.Label lblTotal_No;
        private System.Windows.Forms.Label lblSubNo;
        private System.Windows.Forms.Panel panel_Expense;
        private System.Windows.Forms.Label lblTitleExpense;
        private System.Windows.Forms.Label lblTotal_ChoMuon;
        private System.Windows.Forms.Label lblSubChoMuon;

        // Legacy aliases
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.RadioButton rb_ChuaThanhToan;
        private System.Windows.Forms.Button btn_Xoa;
    }
}