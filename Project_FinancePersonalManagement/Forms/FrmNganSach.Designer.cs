namespace Project_FinancePersonalManagement
{
    partial class FrmNganSach
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Period = new System.Windows.Forms.Label();
            this.lbl_Sub = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Sidebar = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.pnl_SideDiv = new System.Windows.Forms.Panel();
            this.cbo_ChartType = new System.Windows.Forms.ComboBox();
            this.lbl_ChartSec = new System.Windows.Forms.Label();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.lbl_Nam = new System.Windows.Forms.Label();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.lbl_Thang = new System.Windows.Forms.Label();
            this.txt_soTien = new System.Windows.Forms.TextBox();
            this.lbl_SoTien = new System.Windows.Forms.Label();
            this.cbo_DanhMuc = new System.Windows.Forms.ComboBox();
            this.lbl_DanhMuc = new System.Windows.Forms.Label();
            this.lbl_FormSec = new System.Windows.Forms.Label();
            this.pnl_NavRow = new System.Windows.Forms.Panel();
            this.lbl_PeriodNav = new System.Windows.Forms.Label();
            this.btn_NextMonth = new System.Windows.Forms.Button();
            this.btn_PrevMonth = new System.Windows.Forms.Button();
            this.lbl_NavSec = new System.Windows.Forms.Label();
            this.pnl_MTotal = new System.Windows.Forms.Panel();
            this.lblTongSoDu = new System.Windows.Forms.Label();
            this.lbl_MTotalLbl = new System.Windows.Forms.Label();
            this.pnl_MTop = new System.Windows.Forms.Panel();
            this.lbl_MTopVal = new System.Windows.Forms.Label();
            this.lbl_MTopLbl = new System.Windows.Forms.Label();
            this.pnl_MCount = new System.Windows.Forms.Panel();
            this.lbl_MCountVal = new System.Windows.Forms.Label();
            this.lbl_MCountLbl = new System.Windows.Forms.Label();
            this.pnl_ChartCard = new System.Windows.Forms.Panel();
            this.budgetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_ChartTitle = new System.Windows.Forms.Label();
            this.pnl_TableCard = new System.Windows.Forms.Panel();
            this.dgv_nganSach = new System.Windows.Forms.DataGridView();
            this.pnl_TableHdr = new System.Windows.Forms.Panel();
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.lbl_TableTitle = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.pnl_Sidebar.SuspendLayout();
            this.pnl_NavRow.SuspendLayout();
            this.pnl_MTotal.SuspendLayout();
            this.pnl_MTop.SuspendLayout();
            this.pnl_MCount.SuspendLayout();
            this.pnl_ChartCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).BeginInit();
            this.pnl_TableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nganSach)).BeginInit();
            this.pnl_TableHdr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.pnl_Header.Controls.Add(this.lbl_Period);
            this.pnl_Header.Controls.Add(this.lbl_Sub);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1342, 83);
            this.pnl_Header.TabIndex = 6;
            // 
            // lbl_Period
            // 
            this.lbl_Period.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Period.AutoSize = true;
            this.lbl_Period.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Period.ForeColor = System.Drawing.Color.White;
            this.lbl_Period.Location = new System.Drawing.Point(2216, 29);
            this.lbl_Period.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Period.Name = "lbl_Period";
            this.lbl_Period.Size = new System.Drawing.Size(0, 28);
            this.lbl_Period.TabIndex = 0;
            // 
            // lbl_Sub
            // 
            this.lbl_Sub.AutoSize = true;
            this.lbl_Sub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.lbl_Sub.Location = new System.Drawing.Point(28, 49);
            this.lbl_Sub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sub.Name = "lbl_Sub";
            this.lbl_Sub.Size = new System.Drawing.Size(355, 25);
            this.lbl_Sub.TabIndex = 1;
            this.lbl_Sub.Text = "Theo dõi & kiểm soát chi tiêu theo danh mục";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(26, 13);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(238, 36);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Quản lý ngân sách";
            // 
            // pnl_Sidebar
            // 
            this.pnl_Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Sidebar.BackColor = System.Drawing.Color.White;
            this.pnl_Sidebar.Controls.Add(this.btn_thoat);
            this.pnl_Sidebar.Controls.Add(this.btn_reset);
            this.pnl_Sidebar.Controls.Add(this.btn_xoa);
            this.pnl_Sidebar.Controls.Add(this.btn_sua);
            this.pnl_Sidebar.Controls.Add(this.btn_them);
            this.pnl_Sidebar.Controls.Add(this.pnl_SideDiv);
            this.pnl_Sidebar.Controls.Add(this.cbo_ChartType);
            this.pnl_Sidebar.Controls.Add(this.lbl_ChartSec);
            this.pnl_Sidebar.Controls.Add(this.txt_nam);
            this.pnl_Sidebar.Controls.Add(this.lbl_Nam);
            this.pnl_Sidebar.Controls.Add(this.txt_thang);
            this.pnl_Sidebar.Controls.Add(this.lbl_Thang);
            this.pnl_Sidebar.Controls.Add(this.txt_soTien);
            this.pnl_Sidebar.Controls.Add(this.lbl_SoTien);
            this.pnl_Sidebar.Controls.Add(this.cbo_DanhMuc);
            this.pnl_Sidebar.Controls.Add(this.lbl_DanhMuc);
            this.pnl_Sidebar.Controls.Add(this.lbl_FormSec);
            this.pnl_Sidebar.Controls.Add(this.pnl_NavRow);
            this.pnl_Sidebar.Controls.Add(this.lbl_NavSec);
            this.pnl_Sidebar.Location = new System.Drawing.Point(0, 83);
            this.pnl_Sidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Sidebar.Name = "pnl_Sidebar";
            this.pnl_Sidebar.Size = new System.Drawing.Size(347, 824);
            this.pnl_Sidebar.TabIndex = 5;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.btn_thoat.Location = new System.Drawing.Point(23, 682);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(305, 43);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btn_reset.Location = new System.Drawing.Point(18, 573);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(311, 43);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btn_xoa.Location = new System.Drawing.Point(18, 631);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(310, 43);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(95)))), ((int)(((byte)(70)))));
            this.btn_sua.Location = new System.Drawing.Point(18, 520);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(311, 43);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(18, 464);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(311, 45);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm mới";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // pnl_SideDiv
            // 
            this.pnl_SideDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.pnl_SideDiv.Location = new System.Drawing.Point(0, 451);
            this.pnl_SideDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_SideDiv.Name = "pnl_SideDiv";
            this.pnl_SideDiv.Size = new System.Drawing.Size(347, 1);
            this.pnl_SideDiv.TabIndex = 10;
            // 
            // cbo_ChartType
            // 
            this.cbo_ChartType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.cbo_ChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ChartType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_ChartType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_ChartType.Location = new System.Drawing.Point(18, 395);
            this.cbo_ChartType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_ChartType.Name = "cbo_ChartType";
            this.cbo_ChartType.Size = new System.Drawing.Size(310, 36);
            this.cbo_ChartType.TabIndex = 4;
            this.cbo_ChartType.SelectedIndexChanged += new System.EventHandler(this.cbo_ChartType_SelectedIndexChanged);
            // 
            // lbl_ChartSec
            // 
            this.lbl_ChartSec.AutoSize = true;
            this.lbl_ChartSec.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lbl_ChartSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lbl_ChartSec.Location = new System.Drawing.Point(18, 371);
            this.lbl_ChartSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChartSec.Name = "lbl_ChartSec";
            this.lbl_ChartSec.Size = new System.Drawing.Size(108, 20);
            this.lbl_ChartSec.TabIndex = 11;
            this.lbl_ChartSec.Text = "LOẠI BIỂU ĐỒ";
            // 
            // txt_nam
            // 
            this.txt_nam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_nam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_nam.Location = new System.Drawing.Point(183, 315);
            this.txt_nam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(146, 34);
            this.txt_nam.TabIndex = 3;
            // 
            // lbl_Nam
            // 
            this.lbl_Nam.AutoSize = true;
            this.lbl_Nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_Nam.Location = new System.Drawing.Point(183, 291);
            this.lbl_Nam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nam.Name = "lbl_Nam";
            this.lbl_Nam.Size = new System.Drawing.Size(52, 25);
            this.lbl_Nam.TabIndex = 12;
            this.lbl_Nam.Text = "Năm";
            // 
            // txt_thang
            // 
            this.txt_thang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_thang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_thang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_thang.Location = new System.Drawing.Point(18, 315);
            this.txt_thang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(146, 34);
            this.txt_thang.TabIndex = 2;
            // 
            // lbl_Thang
            // 
            this.lbl_Thang.AutoSize = true;
            this.lbl_Thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_Thang.Location = new System.Drawing.Point(18, 291);
            this.lbl_Thang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Thang.Name = "lbl_Thang";
            this.lbl_Thang.Size = new System.Drawing.Size(66, 25);
            this.lbl_Thang.TabIndex = 13;
            this.lbl_Thang.Text = "Tháng";
            // 
            // txt_soTien
            // 
            this.txt_soTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txt_soTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_soTien.Location = new System.Drawing.Point(18, 235);
            this.txt_soTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soTien.Name = "txt_soTien";
            this.txt_soTien.Size = new System.Drawing.Size(311, 34);
            this.txt_soTien.TabIndex = 1;
            // 
            // lbl_SoTien
            // 
            this.lbl_SoTien.AutoSize = true;
            this.lbl_SoTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SoTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_SoTien.Location = new System.Drawing.Point(18, 211);
            this.lbl_SoTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoTien.Name = "lbl_SoTien";
            this.lbl_SoTien.Size = new System.Drawing.Size(193, 25);
            this.lbl_SoTien.TabIndex = 14;
            this.lbl_SoTien.Text = "Số tiền ngân sách (VNĐ)";
            // 
            // cbo_DanhMuc
            // 
            this.cbo_DanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.cbo_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbo_DanhMuc.Location = new System.Drawing.Point(18, 157);
            this.cbo_DanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_DanhMuc.Name = "cbo_DanhMuc";
            this.cbo_DanhMuc.Size = new System.Drawing.Size(310, 36);
            this.cbo_DanhMuc.TabIndex = 0;
            // 
            // lbl_DanhMuc
            // 
            this.lbl_DanhMuc.AutoSize = true;
            this.lbl_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_DanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lbl_DanhMuc.Location = new System.Drawing.Point(18, 133);
            this.lbl_DanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DanhMuc.Name = "lbl_DanhMuc";
            this.lbl_DanhMuc.Size = new System.Drawing.Size(98, 25);
            this.lbl_DanhMuc.TabIndex = 15;
            this.lbl_DanhMuc.Text = "Danh mục";
            // 
            // lbl_FormSec
            // 
            this.lbl_FormSec.AutoSize = true;
            this.lbl_FormSec.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lbl_FormSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lbl_FormSec.Location = new System.Drawing.Point(18, 109);
            this.lbl_FormSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FormSec.Name = "lbl_FormSec";
            this.lbl_FormSec.Size = new System.Drawing.Size(186, 20);
            this.lbl_FormSec.TabIndex = 16;
            this.lbl_FormSec.Text = "THÔNG TIN NGÂN SÁCH";
            // 
            // pnl_NavRow
            // 
            this.pnl_NavRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pnl_NavRow.Controls.Add(this.lbl_PeriodNav);
            this.pnl_NavRow.Controls.Add(this.btn_NextMonth);
            this.pnl_NavRow.Controls.Add(this.btn_PrevMonth);
            this.pnl_NavRow.Location = new System.Drawing.Point(18, 43);
            this.pnl_NavRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_NavRow.Name = "pnl_NavRow";
            this.pnl_NavRow.Size = new System.Drawing.Size(311, 51);
            this.pnl_NavRow.TabIndex = 17;
            // 
            // lbl_PeriodNav
            // 
            this.lbl_PeriodNav.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_PeriodNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(163)))));
            this.lbl_PeriodNav.Location = new System.Drawing.Point(49, 5);
            this.lbl_PeriodNav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PeriodNav.Name = "lbl_PeriodNav";
            this.lbl_PeriodNav.Size = new System.Drawing.Size(213, 40);
            this.lbl_PeriodNav.TabIndex = 0;
            this.lbl_PeriodNav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_NextMonth
            // 
            this.btn_NextMonth.BackColor = System.Drawing.Color.White;
            this.btn_NextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NextMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.btn_NextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextMonth.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_NextMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btn_NextMonth.Location = new System.Drawing.Point(267, 5);
            this.btn_NextMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NextMonth.Name = "btn_NextMonth";
            this.btn_NextMonth.Size = new System.Drawing.Size(39, 40);
            this.btn_NextMonth.TabIndex = 1;
            this.btn_NextMonth.TabStop = false;
            this.btn_NextMonth.Text = "›";
            this.btn_NextMonth.UseVisualStyleBackColor = false;
            this.btn_NextMonth.Click += new System.EventHandler(this.btn_NextMonth_Click);
            // 
            // btn_PrevMonth
            // 
            this.btn_PrevMonth.BackColor = System.Drawing.Color.White;
            this.btn_PrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PrevMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(210)))), ((int)(((byte)(254)))));
            this.btn_PrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrevMonth.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_PrevMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btn_PrevMonth.Location = new System.Drawing.Point(5, 5);
            this.btn_PrevMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_PrevMonth.Name = "btn_PrevMonth";
            this.btn_PrevMonth.Size = new System.Drawing.Size(39, 40);
            this.btn_PrevMonth.TabIndex = 2;
            this.btn_PrevMonth.TabStop = false;
            this.btn_PrevMonth.Text = "‹";
            this.btn_PrevMonth.UseVisualStyleBackColor = false;
            this.btn_PrevMonth.Click += new System.EventHandler(this.btn_PrevMonth_Click);
            // 
            // lbl_NavSec
            // 
            this.lbl_NavSec.AutoSize = true;
            this.lbl_NavSec.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lbl_NavSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lbl_NavSec.Location = new System.Drawing.Point(18, 19);
            this.lbl_NavSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NavSec.Name = "lbl_NavSec";
            this.lbl_NavSec.Size = new System.Drawing.Size(138, 20);
            this.lbl_NavSec.TabIndex = 18;
            this.lbl_NavSec.Text = "LỌC THEO THÁNG";
            // 
            // pnl_MTotal
            // 
            this.pnl_MTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pnl_MTotal.Controls.Add(this.lblTongSoDu);
            this.pnl_MTotal.Controls.Add(this.lbl_MTotalLbl);
            this.pnl_MTotal.Location = new System.Drawing.Point(363, 99);
            this.pnl_MTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_MTotal.Name = "pnl_MTotal";
            this.pnl_MTotal.Size = new System.Drawing.Size(270, 80);
            this.pnl_MTotal.TabIndex = 4;
            // 
            // lblTongSoDu
            // 
            this.lblTongSoDu.AutoSize = true;
            this.lblTongSoDu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongSoDu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(163)))));
            this.lblTongSoDu.Location = new System.Drawing.Point(13, 35);
            this.lblTongSoDu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongSoDu.Name = "lblTongSoDu";
            this.lblTongSoDu.Size = new System.Drawing.Size(46, 30);
            this.lblTongSoDu.TabIndex = 0;
            this.lblTongSoDu.Text = "0 VNĐ";
            // 
            // lbl_MTotalLbl
            // 
            this.lbl_MTotalLbl.AutoSize = true;
            this.lbl_MTotalLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lbl_MTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.lbl_MTotalLbl.Location = new System.Drawing.Point(13, 11);
            this.lbl_MTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MTotalLbl.Name = "lbl_MTotalLbl";
            this.lbl_MTotalLbl.Size = new System.Drawing.Size(145, 20);
            this.lbl_MTotalLbl.TabIndex = 1;
            this.lbl_MTotalLbl.Text = "TỔNG NGÂN SÁCH";
            // 
            // pnl_MTop
            // 
            this.pnl_MTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.pnl_MTop.Controls.Add(this.lbl_MTopVal);
            this.pnl_MTop.Controls.Add(this.lbl_MTopLbl);
            this.pnl_MTop.Location = new System.Drawing.Point(648, 99);
            this.pnl_MTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_MTop.Name = "pnl_MTop";
            this.pnl_MTop.Size = new System.Drawing.Size(270, 80);
            this.pnl_MTop.TabIndex = 3;
            // 
            // lbl_MTopVal
            // 
            this.lbl_MTopVal.AutoSize = true;
            this.lbl_MTopVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_MTopVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.lbl_MTopVal.Location = new System.Drawing.Point(13, 35);
            this.lbl_MTopVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MTopVal.Name = "lbl_MTopVal";
            this.lbl_MTopVal.Size = new System.Drawing.Size(35, 30);
            this.lbl_MTopVal.TabIndex = 0;
            this.lbl_MTopVal.Text = "—";
            // 
            // lbl_MTopLbl
            // 
            this.lbl_MTopLbl.AutoSize = true;
            this.lbl_MTopLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lbl_MTopLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lbl_MTopLbl.Location = new System.Drawing.Point(13, 11);
            this.lbl_MTopLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MTopLbl.Name = "lbl_MTopLbl";
            this.lbl_MTopLbl.Size = new System.Drawing.Size(174, 20);
            this.lbl_MTopLbl.TabIndex = 1;
            this.lbl_MTopLbl.Text = "DANH MỤC CAO NHẤT";
            // 
            // pnl_MCount
            // 
            this.pnl_MCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.pnl_MCount.Controls.Add(this.lbl_MCountVal);
            this.pnl_MCount.Controls.Add(this.lbl_MCountLbl);
            this.pnl_MCount.Location = new System.Drawing.Point(933, 99);
            this.pnl_MCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_MCount.Name = "pnl_MCount";
            this.pnl_MCount.Size = new System.Drawing.Size(270, 80);
            this.pnl_MCount.TabIndex = 2;
            // 
            // lbl_MCountVal
            // 
            this.lbl_MCountVal.AutoSize = true;
            this.lbl_MCountVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_MCountVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lbl_MCountVal.Location = new System.Drawing.Point(13, 35);
            this.lbl_MCountVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MCountVal.Name = "lbl_MCountVal";
            this.lbl_MCountVal.Size = new System.Drawing.Size(26, 30);
            this.lbl_MCountVal.TabIndex = 0;
            this.lbl_MCountVal.Text = "0";
            // 
            // lbl_MCountLbl
            // 
            this.lbl_MCountLbl.AutoSize = true;
            this.lbl_MCountLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lbl_MCountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.lbl_MCountLbl.Location = new System.Drawing.Point(13, 11);
            this.lbl_MCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MCountLbl.Name = "lbl_MCountLbl";
            this.lbl_MCountLbl.Size = new System.Drawing.Size(115, 20);
            this.lbl_MCountLbl.TabIndex = 1;
            this.lbl_MCountLbl.Text = "SỐ DANH MỤC";
            // 
            // pnl_ChartCard
            // 
            this.pnl_ChartCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ChartCard.BackColor = System.Drawing.Color.White;
            this.pnl_ChartCard.Controls.Add(this.budgetChart);
            this.pnl_ChartCard.Controls.Add(this.lbl_ChartTitle);
            this.pnl_ChartCard.Location = new System.Drawing.Point(363, 195);
            this.pnl_ChartCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_ChartCard.Name = "pnl_ChartCard";
            this.pnl_ChartCard.Size = new System.Drawing.Size(964, 293);
            this.pnl_ChartCard.TabIndex = 1;
            // 
            // budgetChart
            // 
            this.budgetChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -30;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.budgetChart.ChartAreas.Add(chartArea1);
            this.budgetChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.budgetChart.Legends.Add(legend1);
            this.budgetChart.Location = new System.Drawing.Point(0, 0);
            this.budgetChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.budgetChart.Name = "budgetChart";
            this.budgetChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "N0";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.budgetChart.Series.Add(series1);
            this.budgetChart.Size = new System.Drawing.Size(964, 293);
            this.budgetChart.TabIndex = 0;
            // 
            // lbl_ChartTitle
            // 
            this.lbl_ChartTitle.AutoSize = true;
            this.lbl_ChartTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lbl_ChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbl_ChartTitle.Location = new System.Drawing.Point(15, 13);
            this.lbl_ChartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChartTitle.Name = "lbl_ChartTitle";
            this.lbl_ChartTitle.Size = new System.Drawing.Size(228, 20);
            this.lbl_ChartTitle.TabIndex = 1;
            this.lbl_ChartTitle.Text = "NGÂN SÁCH THEO DANH MỤC";
            // 
            // pnl_TableCard
            // 
            this.pnl_TableCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_TableCard.BackColor = System.Drawing.Color.White;
            this.pnl_TableCard.Controls.Add(this.dgv_nganSach);
            this.pnl_TableCard.Controls.Add(this.pnl_TableHdr);
            this.pnl_TableCard.Location = new System.Drawing.Point(363, 504);
            this.pnl_TableCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_TableCard.Name = "pnl_TableCard";
            this.pnl_TableCard.Size = new System.Drawing.Size(964, 400);
            this.pnl_TableCard.TabIndex = 0;
            // 
            // dgv_nganSach
            // 
            this.dgv_nganSach.AllowUserToAddRows = false;
            this.dgv_nganSach.AllowUserToDeleteRows = false;
            this.dgv_nganSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nganSach.BackgroundColor = System.Drawing.Color.White;
            this.dgv_nganSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_nganSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_nganSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nganSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_nganSach.ColumnHeadersHeight = 34;
            this.dgv_nganSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nganSach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_nganSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nganSach.EnableHeadersVisualStyles = false;
            this.dgv_nganSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgv_nganSach.Location = new System.Drawing.Point(0, 56);
            this.dgv_nganSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_nganSach.Name = "dgv_nganSach";
            this.dgv_nganSach.ReadOnly = true;
            this.dgv_nganSach.RowHeadersVisible = false;
            this.dgv_nganSach.RowHeadersWidth = 62;
            this.dgv_nganSach.RowTemplate.Height = 34;
            this.dgv_nganSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nganSach.Size = new System.Drawing.Size(964, 344);
            this.dgv_nganSach.TabIndex = 1;
            this.dgv_nganSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nganSach_CellClick_1);
            // 
            // pnl_TableHdr
            // 
            this.pnl_TableHdr.BackColor = System.Drawing.Color.White;
            this.pnl_TableHdr.Controls.Add(this.lbl_RowCount);
            this.pnl_TableHdr.Controls.Add(this.lbl_TableTitle);
            this.pnl_TableHdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TableHdr.Location = new System.Drawing.Point(0, 0);
            this.pnl_TableHdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_TableHdr.Name = "pnl_TableHdr";
            this.pnl_TableHdr.Size = new System.Drawing.Size(964, 56);
            this.pnl_TableHdr.TabIndex = 2;
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_RowCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lbl_RowCount.Location = new System.Drawing.Point(1491, 17);
            this.lbl_RowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(0, 25);
            this.lbl_RowCount.TabIndex = 0;
            // 
            // lbl_TableTitle
            // 
            this.lbl_TableTitle.AutoSize = true;
            this.lbl_TableTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_TableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lbl_TableTitle.Location = new System.Drawing.Point(15, 13);
            this.lbl_TableTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TableTitle.Name = "lbl_TableTitle";
            this.lbl_TableTitle.Size = new System.Drawing.Size(229, 30);
            this.lbl_TableTitle.TabIndex = 1;
            this.lbl_TableTitle.Text = "Danh sách ngân sách";
            // 
            // FrmNganSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1342, 907);
            this.Controls.Add(this.pnl_TableCard);
            this.Controls.Add(this.pnl_ChartCard);
            this.Controls.Add(this.pnl_MCount);
            this.Controls.Add(this.pnl_MTop);
            this.Controls.Add(this.pnl_MTotal);
            this.Controls.Add(this.pnl_Sidebar);
            this.Controls.Add(this.pnl_Header);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1151, 781);
            this.Name = "FrmNganSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngân sách — Finance Manager";
            this.Load += new System.EventHandler(this.frm_nganSach_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Sidebar.ResumeLayout(false);
            this.pnl_Sidebar.PerformLayout();
            this.pnl_NavRow.ResumeLayout(false);
            this.pnl_MTotal.ResumeLayout(false);
            this.pnl_MTotal.PerformLayout();
            this.pnl_MTop.ResumeLayout(false);
            this.pnl_MTop.PerformLayout();
            this.pnl_MCount.ResumeLayout(false);
            this.pnl_MCount.PerformLayout();
            this.pnl_ChartCard.ResumeLayout(false);
            this.pnl_ChartCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).EndInit();
            this.pnl_TableCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nganSach)).EndInit();
            this.pnl_TableHdr.ResumeLayout(false);
            this.pnl_TableHdr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Sub;
        private System.Windows.Forms.Label lbl_Period;
        private System.Windows.Forms.Panel pnl_Sidebar;
        private System.Windows.Forms.Label lbl_NavSec;
        private System.Windows.Forms.Panel pnl_NavRow;
        private System.Windows.Forms.Button btn_PrevMonth;
        private System.Windows.Forms.Label lbl_PeriodNav;
        private System.Windows.Forms.Button btn_NextMonth;
        private System.Windows.Forms.Label lbl_FormSec;
        private System.Windows.Forms.Label lbl_DanhMuc;
        private System.Windows.Forms.ComboBox cbo_DanhMuc;
        private System.Windows.Forms.Label lbl_SoTien;
        private System.Windows.Forms.TextBox txt_soTien;
        private System.Windows.Forms.Label lbl_Thang;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.Label lbl_Nam;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Label lbl_ChartSec;
        private System.Windows.Forms.ComboBox cbo_ChartType;
        private System.Windows.Forms.Panel pnl_SideDiv;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel pnl_MTotal;
        private System.Windows.Forms.Label lbl_MTotalLbl;
        private System.Windows.Forms.Label lblTongSoDu;
        private System.Windows.Forms.Panel pnl_MTop;
        private System.Windows.Forms.Label lbl_MTopLbl;
        private System.Windows.Forms.Label lbl_MTopVal;
        private System.Windows.Forms.Panel pnl_MCount;
        private System.Windows.Forms.Label lbl_MCountLbl;
        private System.Windows.Forms.Label lbl_MCountVal;
        private System.Windows.Forms.Panel pnl_ChartCard;
        private System.Windows.Forms.Label lbl_ChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart budgetChart;
        private System.Windows.Forms.Panel pnl_TableCard;
        private System.Windows.Forms.Panel pnl_TableHdr;
        private System.Windows.Forms.Label lbl_TableTitle;
        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.DataGridView dgv_nganSach;
    }
}