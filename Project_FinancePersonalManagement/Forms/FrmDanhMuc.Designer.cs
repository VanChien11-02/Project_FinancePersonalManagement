namespace Project_FinancePersonalManagement
{
    partial class FrmDanhMuc
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
            this.pnl_Sidebar = new System.Windows.Forms.Panel();
            this.lbl_FilterTitle = new System.Windows.Forms.Label();
            this.rAll = new System.Windows.Forms.RadioButton();
            this.rThuNhap = new System.Windows.Forms.RadioButton();
            this.rChiTieu = new System.Windows.Forms.RadioButton();
            this.pnl_FilterDivider = new System.Windows.Forms.Panel();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_tenDanhMuc = new System.Windows.Forms.TextBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.cbo_LoaiDM = new System.Windows.Forms.ComboBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.pnl_BtnDivider = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.dgv_danhMuc = new System.Windows.Forms.DataGridView();
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.pnl_Sidebar.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Sidebar
            // 
            this.pnl_Sidebar.BackColor = System.Drawing.Color.White;
            this.pnl_Sidebar.Controls.Add(this.lbl_FilterTitle);
            this.pnl_Sidebar.Controls.Add(this.rAll);
            this.pnl_Sidebar.Controls.Add(this.rThuNhap);
            this.pnl_Sidebar.Controls.Add(this.rChiTieu);
            this.pnl_Sidebar.Controls.Add(this.pnl_FilterDivider);
            this.pnl_Sidebar.Controls.Add(this.lbl_FormTitle);
            this.pnl_Sidebar.Controls.Add(this.lbl_Name);
            this.pnl_Sidebar.Controls.Add(this.txt_tenDanhMuc);
            this.pnl_Sidebar.Controls.Add(this.lbl_Type);
            this.pnl_Sidebar.Controls.Add(this.cbo_LoaiDM);
            this.pnl_Sidebar.Controls.Add(this.lbl_Note);
            this.pnl_Sidebar.Controls.Add(this.txt_ghiChu);
            this.pnl_Sidebar.Controls.Add(this.pnl_BtnDivider);
            this.pnl_Sidebar.Controls.Add(this.btn_them);
            this.pnl_Sidebar.Controls.Add(this.btn_sua);
            this.pnl_Sidebar.Controls.Add(this.btn_xoa);
            this.pnl_Sidebar.Controls.Add(this.btn_reset);
            this.pnl_Sidebar.Controls.Add(this.btn_thoat);
            this.pnl_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Sidebar.Name = "pnl_Sidebar";
            this.pnl_Sidebar.Padding = new System.Windows.Forms.Padding(21, 24, 21, 21);
            this.pnl_Sidebar.Size = new System.Drawing.Size(345, 749);
            this.pnl_Sidebar.TabIndex = 1;
            // 
            // lbl_FilterTitle
            // 
            this.lbl_FilterTitle.AutoSize = true;
            this.lbl_FilterTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_FilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbl_FilterTitle.Location = new System.Drawing.Point(21, 11);
            this.lbl_FilterTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FilterTitle.Name = "lbl_FilterTitle";
            this.lbl_FilterTitle.Size = new System.Drawing.Size(133, 21);
            this.lbl_FilterTitle.TabIndex = 0;
            this.lbl_FilterTitle.Text = "LỌC DANH MỤC";
            // 
            // rAll
            // 
            this.rAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rAll.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.rAll.Location = new System.Drawing.Point(21, 40);
            this.rAll.Margin = new System.Windows.Forms.Padding(4);
            this.rAll.Name = "rAll";
            this.rAll.Size = new System.Drawing.Size(283, 37);
            this.rAll.TabIndex = 0;
            this.rAll.Text = "Tất cả";
            this.rAll.CheckedChanged += new System.EventHandler(this.rAll_CheckedChanged);
            // 
            // rThuNhap
            // 
            this.rThuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rThuNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rThuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.rThuNhap.Location = new System.Drawing.Point(21, 80);
            this.rThuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.rThuNhap.Name = "rThuNhap";
            this.rThuNhap.Size = new System.Drawing.Size(283, 37);
            this.rThuNhap.TabIndex = 1;
            this.rThuNhap.Text = "Thu nhập";
            this.rThuNhap.CheckedChanged += new System.EventHandler(this.rThuNhap_CheckedChanged);
            // 
            // rChiTieu
            // 
            this.rChiTieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rChiTieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rChiTieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.rChiTieu.Location = new System.Drawing.Point(21, 120);
            this.rChiTieu.Margin = new System.Windows.Forms.Padding(4);
            this.rChiTieu.Name = "rChiTieu";
            this.rChiTieu.Size = new System.Drawing.Size(283, 37);
            this.rChiTieu.TabIndex = 2;
            this.rChiTieu.Text = "Chi tiêu";
            this.rChiTieu.CheckedChanged += new System.EventHandler(this.rChiTieu_CheckedChanged);
            // 
            // pnl_FilterDivider
            // 
            this.pnl_FilterDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.pnl_FilterDivider.Location = new System.Drawing.Point(21, 160);
            this.pnl_FilterDivider.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_FilterDivider.Name = "pnl_FilterDivider";
            this.pnl_FilterDivider.Size = new System.Drawing.Size(303, 1);
            this.pnl_FilterDivider.TabIndex = 3;
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.lbl_FormTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_FormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbl_FormTitle.Location = new System.Drawing.Point(21, 176);
            this.lbl_FormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(191, 21);
            this.lbl_FormTitle.TabIndex = 4;
            this.lbl_FormTitle.Text = "THÔNG TIN DANH MỤC";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_Name.Location = new System.Drawing.Point(21, 206);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(131, 25);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Tên danh mục";
            // 
            // txt_tenDanhMuc
            // 
            this.txt_tenDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_tenDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_tenDanhMuc.Location = new System.Drawing.Point(21, 232);
            this.txt_tenDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenDanhMuc.Name = "txt_tenDanhMuc";
            this.txt_tenDanhMuc.Size = new System.Drawing.Size(303, 34);
            this.txt_tenDanhMuc.TabIndex = 3;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_Type.Location = new System.Drawing.Point(21, 271);
            this.lbl_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(136, 25);
            this.lbl_Type.TabIndex = 6;
            this.lbl_Type.Text = "Loại danh mục";
            // 
            // cbo_LoaiDM
            // 
            this.cbo_LoaiDM.BackColor = System.Drawing.Color.Gray;
            this.cbo_LoaiDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_LoaiDM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_LoaiDM.Location = new System.Drawing.Point(21, 298);
            this.cbo_LoaiDM.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_LoaiDM.Name = "cbo_LoaiDM";
            this.cbo_LoaiDM.Size = new System.Drawing.Size(302, 36);
            this.cbo_LoaiDM.TabIndex = 4;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_Note.Location = new System.Drawing.Point(21, 342);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(77, 25);
            this.lbl_Note.TabIndex = 7;
            this.lbl_Note.Text = "Ghi chú";
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_ghiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ghiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_ghiChu.Location = new System.Drawing.Point(21, 369);
            this.txt_ghiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(303, 34);
            this.txt_ghiChu.TabIndex = 5;
            // 
            // pnl_BtnDivider
            // 
            this.pnl_BtnDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.pnl_BtnDivider.Location = new System.Drawing.Point(20, 408);
            this.pnl_BtnDivider.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_BtnDivider.Name = "pnl_BtnDivider";
            this.pnl_BtnDivider.Size = new System.Drawing.Size(303, 1);
            this.pnl_BtnDivider.TabIndex = 8;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(20, 421);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(303, 48);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "+ Thêm mới";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(247)))), ((int)(((byte)(208)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.btn_sua.Location = new System.Drawing.Point(20, 480);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(303, 45);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btn_xoa.Location = new System.Drawing.Point(20, 536);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(303, 45);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btn_reset.Location = new System.Drawing.Point(20, 592);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(303, 45);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.btn_thoat.Location = new System.Drawing.Point(20, 645);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(303, 45);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnl_Main.Controls.Add(this.dgv_danhMuc);
            this.pnl_Main.Controls.Add(this.lbl_RowCount);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(345, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Padding = new System.Windows.Forms.Padding(26, 21, 26, 21);
            this.pnl_Main.Size = new System.Drawing.Size(860, 749);
            this.pnl_Main.TabIndex = 0;
            // 
            // dgv_danhMuc
            // 
            this.dgv_danhMuc.AllowUserToAddRows = false;
            this.dgv_danhMuc.AllowUserToDeleteRows = false;
            this.dgv_danhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_danhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgv_danhMuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_danhMuc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_danhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_danhMuc.ColumnHeadersHeight = 38;
            this.dgv_danhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_danhMuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_danhMuc.EnableHeadersVisualStyles = false;
            this.dgv_danhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgv_danhMuc.Location = new System.Drawing.Point(8, 50);
            this.dgv_danhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_danhMuc.Name = "dgv_danhMuc";
            this.dgv_danhMuc.ReadOnly = true;
            this.dgv_danhMuc.RowHeadersVisible = false;
            this.dgv_danhMuc.RowHeadersWidth = 62;
            this.dgv_danhMuc.RowTemplate.Height = 38;
            this.dgv_danhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhMuc.Size = new System.Drawing.Size(839, 686);
            this.dgv_danhMuc.TabIndex = 11;
            this.dgv_danhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhMuc_CellClick);
            this.dgv_danhMuc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_danhMuc_CellFormatting_1);
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_RowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbl_RowCount.Location = new System.Drawing.Point(26, 21);
            this.lbl_RowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(150, 25);
            this.lbl_RowCount.TabIndex = 12;
            this.lbl_RowCount.Text = "Đang tải dữ liệu...";
            // 
            // frm_danhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1205, 749);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Sidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "frm_danhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục — Finance Manager";
            this.Load += new System.EventHandler(this.frm_danhMuc_Load);
            this.pnl_Sidebar.ResumeLayout(false);
            this.pnl_Sidebar.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Sidebar;
        private System.Windows.Forms.Label lbl_FilterTitle;
        private System.Windows.Forms.RadioButton rAll;
        private System.Windows.Forms.RadioButton rThuNhap;
        private System.Windows.Forms.RadioButton rChiTieu;
        private System.Windows.Forms.Panel pnl_FilterDivider;
        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_tenDanhMuc;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.ComboBox cbo_LoaiDM;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.Panel pnl_BtnDivider;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.DataGridView dgv_danhMuc;
    }
}