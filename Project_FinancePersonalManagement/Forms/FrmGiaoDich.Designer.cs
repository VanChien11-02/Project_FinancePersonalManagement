namespace Project_FinancePersonalManagement
{
    partial class FrmGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnlInputFields = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ConLai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_LoaiGD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_DanhMuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_NgayGD = new System.Windows.Forms.DateTimePicker();
            this.lbl_ChuyenDenTK = new System.Windows.Forms.Label();
            this.cbo_ChuyenDenTK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.lblCardInput = new System.Windows.Forms.Label();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.btnThangSau = new System.Windows.Forms.Button();
            this.btnThangTruoc = new System.Windows.Forms.Button();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.panel_Expense = new System.Windows.Forms.Panel();
            this.lblChangeExpense = new System.Windows.Forms.Label();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblTitleExpense = new System.Windows.Forms.Label();
            this.panel_income = new System.Windows.Forms.Panel();
            this.lblChangeIncome = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTitleIncome = new System.Windows.Forms.Label();
            this.pnlInputCard.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlInputFields.SuspendLayout();
            this.pnlFilterBar.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.panel_Expense.SuspendLayout();
            this.panel_income.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.Controls.Add(this.pnlButtons);
            this.pnlInputCard.Controls.Add(this.pnlInputFields);
            this.pnlInputCard.Controls.Add(this.lblCardInput);
            this.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInputCard.Location = new System.Drawing.Point(0, 0);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Padding = new System.Windows.Forms.Padding(16, 10, 16, 8);
            this.pnlInputCard.Size = new System.Drawing.Size(1020, 218);
            this.pnlInputCard.TabIndex = 3;
            this.pnlInputCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnInBaoCao);
            this.pnlButtons.Controls.Add(this.btn_Thoat);
            this.pnlButtons.Controls.Add(this.btnXuatExcel);
            this.pnlButtons.Controls.Add(this.btn_Them);
            this.pnlButtons.Controls.Add(this.btn_Sua);
            this.pnlButtons.Controls.Add(this.btn_Xoa);
            this.pnlButtons.Controls.Add(this.btn_Reset);
            this.pnlButtons.Location = new System.Drawing.Point(12, 182);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1004, 36);
            this.pnlButtons.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Lime;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.Location = new System.Drawing.Point(826, 0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(98, 34);
            this.btn_Thoat.TabIndex = 14;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
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
            this.btn_Them.Size = new System.Drawing.Size(110, 34);
            this.btn_Them.TabIndex = 10;
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
            this.btn_Sua.Size = new System.Drawing.Size(110, 34);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_Xoa.Location = new System.Drawing.Point(236, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(90, 34);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Reset.Location = new System.Drawing.Point(334, 0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(98, 34);
            this.btn_Reset.TabIndex = 13;
            this.btn_Reset.Text = "Làm mới";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // pnlInputFields
            // 
            this.pnlInputFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInputFields.BackColor = System.Drawing.Color.Transparent;
            this.pnlInputFields.Controls.Add(this.label11);
            this.pnlInputFields.Controls.Add(this.txt_ConLai);
            this.pnlInputFields.Controls.Add(this.label1);
            this.pnlInputFields.Controls.Add(this.cbo_TaiKhoan);
            this.pnlInputFields.Controls.Add(this.label10);
            this.pnlInputFields.Controls.Add(this.txt_SoDu);
            this.pnlInputFields.Controls.Add(this.label3);
            this.pnlInputFields.Controls.Add(this.cbo_LoaiGD);
            this.pnlInputFields.Controls.Add(this.label4);
            this.pnlInputFields.Controls.Add(this.txt_Tien);
            this.pnlInputFields.Controls.Add(this.label2);
            this.pnlInputFields.Controls.Add(this.cbo_DanhMuc);
            this.pnlInputFields.Controls.Add(this.label5);
            this.pnlInputFields.Controls.Add(this.dtp_NgayGD);
            this.pnlInputFields.Controls.Add(this.lbl_ChuyenDenTK);
            this.pnlInputFields.Controls.Add(this.cbo_ChuyenDenTK);
            this.pnlInputFields.Controls.Add(this.label6);
            this.pnlInputFields.Controls.Add(this.txt_Note);
            this.pnlInputFields.Location = new System.Drawing.Point(16, 41);
            this.pnlInputFields.Name = "pnlInputFields";
            this.pnlInputFields.Size = new System.Drawing.Size(1004, 135);
            this.pnlInputFields.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(1, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Còn lại:";
            // 
            // txt_ConLai
            // 
            this.txt_ConLai.Location = new System.Drawing.Point(110, 105);
            this.txt_ConLai.Name = "txt_ConLai";
            this.txt_ConLai.ReadOnly = true;
            this.txt_ConLai.Size = new System.Drawing.Size(190, 31);
            this.txt_ConLai.TabIndex = 9;
            this.txt_ConLai.TextChanged += new System.EventHandler(this.cbo_DanhMuc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // cbo_TaiKhoan
            // 
            this.cbo_TaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_TaiKhoan.FormattingEnabled = true;
            this.cbo_TaiKhoan.Location = new System.Drawing.Point(110, 4);
            this.cbo_TaiKhoan.Name = "cbo_TaiKhoan";
            this.cbo_TaiKhoan.Size = new System.Drawing.Size(190, 33);
            this.cbo_TaiKhoan.TabIndex = 1;
            this.cbo_TaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbo_TaiKhoan_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(320, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số dư:";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.txt_SoDu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoDu.Location = new System.Drawing.Point(400, 4);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.ReadOnly = true;
            this.txt_SoDu.Size = new System.Drawing.Size(190, 31);
            this.txt_SoDu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(0, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại GD:";
            // 
            // cbo_LoaiGD
            // 
            this.cbo_LoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiGD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_LoaiGD.FormattingEnabled = true;
            this.cbo_LoaiGD.Location = new System.Drawing.Point(110, 38);
            this.cbo_LoaiGD.Name = "cbo_LoaiGD";
            this.cbo_LoaiGD.Size = new System.Drawing.Size(190, 33);
            this.cbo_LoaiGD.TabIndex = 3;
            this.cbo_LoaiGD.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiGD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(320, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tiền:";
            // 
            // txt_Tien
            // 
            this.txt_Tien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tien.Location = new System.Drawing.Point(400, 38);
            this.txt_Tien.Name = "txt_Tien";
            this.txt_Tien.Size = new System.Drawing.Size(190, 31);
            this.txt_Tien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(0, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh mục:";
            // 
            // cbo_DanhMuc
            // 
            this.cbo_DanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_DanhMuc.FormattingEnabled = true;
            this.cbo_DanhMuc.Location = new System.Drawing.Point(110, 72);
            this.cbo_DanhMuc.Name = "cbo_DanhMuc";
            this.cbo_DanhMuc.Size = new System.Drawing.Size(190, 33);
            this.cbo_DanhMuc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(320, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày GD:";
            // 
            // dtp_NgayGD
            // 
            this.dtp_NgayGD.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayGD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_NgayGD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayGD.Location = new System.Drawing.Point(400, 72);
            this.dtp_NgayGD.Name = "dtp_NgayGD";
            this.dtp_NgayGD.Size = new System.Drawing.Size(190, 31);
            this.dtp_NgayGD.TabIndex = 6;
            // 
            // lbl_ChuyenDenTK
            // 
            this.lbl_ChuyenDenTK.AutoSize = true;
            this.lbl_ChuyenDenTK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_ChuyenDenTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_ChuyenDenTK.Location = new System.Drawing.Point(320, 109);
            this.lbl_ChuyenDenTK.Name = "lbl_ChuyenDenTK";
            this.lbl_ChuyenDenTK.Size = new System.Drawing.Size(106, 23);
            this.lbl_ChuyenDenTK.TabIndex = 7;
            this.lbl_ChuyenDenTK.Text = "Chuyển đến:";
            this.lbl_ChuyenDenTK.Visible = false;
            // 
            // cbo_ChuyenDenTK
            // 
            this.cbo_ChuyenDenTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ChuyenDenTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_ChuyenDenTK.FormattingEnabled = true;
            this.cbo_ChuyenDenTK.Location = new System.Drawing.Point(400, 105);
            this.cbo_ChuyenDenTK.Name = "cbo_ChuyenDenTK";
            this.cbo_ChuyenDenTK.Size = new System.Drawing.Size(190, 33);
            this.cbo_ChuyenDenTK.TabIndex = 7;
            this.cbo_ChuyenDenTK.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(610, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ghi chú:";
            // 
            // txt_Note
            // 
            this.txt_Note.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Note.Location = new System.Drawing.Point(610, 28);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Note.Size = new System.Drawing.Size(310, 86);
            this.txt_Note.TabIndex = 8;
            // 
            // lblCardInput
            // 
            this.lblCardInput.AutoSize = true;
            this.lblCardInput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCardInput.Location = new System.Drawing.Point(16, 10);
            this.lblCardInput.Name = "lblCardInput";
            this.lblCardInput.Size = new System.Drawing.Size(199, 28);
            this.lblCardInput.TabIndex = 2;
            this.lblCardInput.Text = "Nhập giao dịch mới";
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlFilterBar.Controls.Add(this.lblThangNam);
            this.pnlFilterBar.Controls.Add(this.btnThangSau);
            this.pnlFilterBar.Controls.Add(this.btnThangTruoc);
            this.pnlFilterBar.Controls.Add(this.btn_Loc);
            this.pnlFilterBar.Controls.Add(this.dtp_DenNgay);
            this.pnlFilterBar.Controls.Add(this.label8);
            this.pnlFilterBar.Controls.Add(this.dtp_TuNgay);
            this.pnlFilterBar.Controls.Add(this.label7);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(0, 218);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(1020, 82);
            this.pnlFilterBar.TabIndex = 2;
            this.pnlFilterBar.Paint += new System.Windows.Forms.PaintEventHandler(this.FilterBar_Paint);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(587, 0);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(114, 36);
            this.btnInBaoCao.TabIndex = 23;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(449, 0);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(112, 36);
            this.btnXuatExcel.TabIndex = 22;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // lblThangNam
            // 
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Location = new System.Drawing.Point(743, 15);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Size = new System.Drawing.Size(106, 25);
            this.lblThangNam.TabIndex = 21;
            this.lblThangNam.Text = "Tháng/Năm";
            // 
            // btnThangSau
            // 
            this.btnThangSau.Location = new System.Drawing.Point(838, 8);
            this.btnThangSau.Name = "btnThangSau";
            this.btnThangSau.Size = new System.Drawing.Size(75, 23);
            this.btnThangSau.TabIndex = 20;
            this.btnThangSau.Text = ">";
            this.btnThangSau.UseVisualStyleBackColor = true;
            this.btnThangSau.Click += new System.EventHandler(this.btnThangSau_Click);
            // 
            // btnThangTruoc
            // 
            this.btnThangTruoc.Location = new System.Drawing.Point(649, 10);
            this.btnThangTruoc.Name = "btnThangTruoc";
            this.btnThangTruoc.Size = new System.Drawing.Size(75, 23);
            this.btnThangTruoc.TabIndex = 19;
            this.btnThangTruoc.Text = "<";
            this.btnThangTruoc.UseVisualStyleBackColor = true;
            this.btnThangTruoc.Click += new System.EventHandler(this.btnThangTruoc_Click);
            // 
            // btn_Loc
            // 
            this.btn_Loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.btn_Loc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Loc.FlatAppearance.BorderSize = 0;
            this.btn_Loc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(95)))), ((int)(((byte)(72)))));
            this.btn_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Loc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Loc.ForeColor = System.Drawing.Color.White;
            this.btn_Loc.Location = new System.Drawing.Point(524, 11);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(90, 31);
            this.btn_Loc.TabIndex = 16;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = false;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_DenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DenNgay.Location = new System.Drawing.Point(360, 11);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(145, 31);
            this.dtp_DenNgay.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label8.Location = new System.Drawing.Point(270, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Đến ngày:";
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtp_TuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TuNgay.Location = new System.Drawing.Point(105, 11);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(145, 31);
            this.dtp_TuNgay.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label7.Location = new System.Drawing.Point(17, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Từ ngày:";
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgvGiaoDich);
            this.pnlGridCard.Controls.Add(this.lblListTitle);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(0, 300);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.pnlGridCard.Size = new System.Drawing.Size(1020, 278);
            this.pnlGridCard.TabIndex = 0;
            this.pnlGridCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.AllowUserToAddRows = false;
            this.dgvGiaoDich.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvGiaoDich.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaoDich.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaoDich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiaoDich.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiaoDich.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoDich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoDich.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiaoDich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvGiaoDich.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvGiaoDich.Location = new System.Drawing.Point(14, 8);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.RowHeadersVisible = false;
            this.dgvGiaoDich.RowHeadersWidth = 62;
            this.dgvGiaoDich.RowTemplate.Height = 32;
            this.dgvGiaoDich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoDich.Size = new System.Drawing.Size(992, 262);
            this.dgvGiaoDich.TabIndex = 20;
            this.dgvGiaoDich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoDich_CellClick);
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblListTitle.Location = new System.Drawing.Point(14, 8);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(203, 28);
            this.lblListTitle.TabIndex = 21;
            this.lblListTitle.Text = "Danh sách giao dịch";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlSummary.Controls.Add(this.panel_Expense);
            this.pnlSummary.Controls.Add(this.panel_income);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSummary.Location = new System.Drawing.Point(0, 578);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlSummary.Size = new System.Drawing.Size(1020, 74);
            this.pnlSummary.TabIndex = 1;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.SummaryBar_Paint);
            // 
            // panel_Expense
            // 
            this.panel_Expense.BackColor = System.Drawing.Color.White;
            this.panel_Expense.Controls.Add(this.lblChangeExpense);
            this.panel_Expense.Controls.Add(this.lblTotalExpense);
            this.panel_Expense.Controls.Add(this.lblTitleExpense);
            this.panel_Expense.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Expense.Location = new System.Drawing.Point(276, 10);
            this.panel_Expense.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.panel_Expense.Name = "panel_Expense";
            this.panel_Expense.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.panel_Expense.Size = new System.Drawing.Size(260, 54);
            this.panel_Expense.TabIndex = 0;
            this.panel_Expense.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblChangeExpense
            // 
            this.lblChangeExpense.AutoSize = true;
            this.lblChangeExpense.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblChangeExpense.ForeColor = System.Drawing.Color.Gray;
            this.lblChangeExpense.Location = new System.Drawing.Point(14, 44);
            this.lblChangeExpense.Name = "lblChangeExpense";
            this.lblChangeExpense.Size = new System.Drawing.Size(0, 21);
            this.lblChangeExpense.TabIndex = 0;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTotalExpense.Location = new System.Drawing.Point(12, 22);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(94, 36);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "0 VNĐ";
            // 
            // lblTitleExpense
            // 
            this.lblTitleExpense.AutoSize = true;
            this.lblTitleExpense.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTitleExpense.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleExpense.Location = new System.Drawing.Point(14, 6);
            this.lblTitleExpense.Name = "lblTitleExpense";
            this.lblTitleExpense.Size = new System.Drawing.Size(95, 20);
            this.lblTitleExpense.TabIndex = 2;
            this.lblTitleExpense.Text = "Tổng chi tiêu";
            // 
            // panel_income
            // 
            this.panel_income.BackColor = System.Drawing.Color.White;
            this.panel_income.Controls.Add(this.lblChangeIncome);
            this.panel_income.Controls.Add(this.lblTotalIncome);
            this.panel_income.Controls.Add(this.lblTitleIncome);
            this.panel_income.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_income.Location = new System.Drawing.Point(16, 10);
            this.panel_income.Name = "panel_income";
            this.panel_income.Padding = new System.Windows.Forms.Padding(14, 6, 14, 6);
            this.panel_income.Size = new System.Drawing.Size(260, 54);
            this.panel_income.TabIndex = 1;
            this.panel_income.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblChangeIncome
            // 
            this.lblChangeIncome.AutoSize = true;
            this.lblChangeIncome.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblChangeIncome.ForeColor = System.Drawing.Color.Gray;
            this.lblChangeIncome.Location = new System.Drawing.Point(14, 44);
            this.lblChangeIncome.Name = "lblChangeIncome";
            this.lblChangeIncome.Size = new System.Drawing.Size(0, 21);
            this.lblChangeIncome.TabIndex = 0;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.lblTotalIncome.Location = new System.Drawing.Point(12, 22);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(94, 36);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "0 VNĐ";
            // 
            // lblTitleIncome
            // 
            this.lblTitleIncome.AutoSize = true;
            this.lblTitleIncome.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTitleIncome.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleIncome.Location = new System.Drawing.Point(14, 6);
            this.lblTitleIncome.Name = "lblTitleIncome";
            this.lblTitleIncome.Size = new System.Drawing.Size(105, 20);
            this.lblTitleIncome.TabIndex = 2;
            this.lblTitleIncome.Text = "Tổng thu nhập";
            // 
            // FrmGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1020, 652);
            this.Controls.Add(this.pnlGridCard);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlFilterBar);
            this.Controls.Add(this.pnlInputCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(860, 580);
            this.Name = "FrmGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGiaoDich_Load);
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlInputFields.ResumeLayout(false);
            this.pnlInputFields.PerformLayout();
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlFilterBar.PerformLayout();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.panel_Expense.ResumeLayout(false);
            this.panel_Expense.PerformLayout();
            this.panel_income.ResumeLayout(false);
            this.panel_income.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblCardInput;
        private System.Windows.Forms.Panel pnlInputFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_TaiKhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SoDu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_LoaiGD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_DanhMuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_NgayGD;
        private System.Windows.Forms.Label lbl_ChuyenDenTK;
        private System.Windows.Forms.ComboBox cbo_ChuyenDenTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_DenNgay;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvGiaoDich;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel panel_income;
        private System.Windows.Forms.Label lblTitleIncome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblChangeIncome;
        private System.Windows.Forms.Panel panel_Expense;
        private System.Windows.Forms.Label lblTitleExpense;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblChangeExpense;

        // Legacy aliases
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_ConLai;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.Button btnThangSau;
        private System.Windows.Forms.Button btnThangTruoc;
        private System.Windows.Forms.Label label11;
    }
}