namespace Project_FinancePersonalManagement
{
    partial class FrmTaiKhoan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlOuter = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlStatStack = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubMax = new System.Windows.Forms.Label();
            this.lblSoDuMax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSubMin = new System.Windows.Forms.Label();
            this.lblSoDuMin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubTB = new System.Windows.Forms.Label();
            this.lblSoDuTB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTong = new System.Windows.Forms.Label();
            this.lblTongSoDu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlChartCard = new System.Windows.Forms.Panel();
            this.chartCoCau = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnlInputFields = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_LoaiTK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenNH = new System.Windows.Forms.TextBox();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.pnlLeftHeader = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlOuter.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlStatStack.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlChartCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCoCau)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.pnlInputCard.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlInputFields.SuspendLayout();
            this.pnlLeftHeader.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuter
            // 
            this.pnlOuter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlOuter.Controls.Add(this.pnlRight);
            this.pnlOuter.Controls.Add(this.pnlLeft);
            this.pnlOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuter.Location = new System.Drawing.Point(0, 0);
            this.pnlOuter.Name = "pnlOuter";
            this.pnlOuter.Size = new System.Drawing.Size(1022, 660);
            this.pnlOuter.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlRight.Controls.Add(this.panel5);
            this.pnlRight.Controls.Add(this.pnlStatStack);
            this.pnlRight.Controls.Add(this.pnlChartCard);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(520, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(502, 660);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlStatStack
            // 
            this.pnlStatStack.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatStack.Controls.Add(this.panel2);
            this.pnlStatStack.Controls.Add(this.panel1);
            this.pnlStatStack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatStack.Location = new System.Drawing.Point(12, 425);
            this.pnlStatStack.Name = "pnlStatStack";
            this.pnlStatStack.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pnlStatStack.Size = new System.Drawing.Size(490, 125);
            this.pnlStatStack.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblSubMax);
            this.panel4.Controls.Add(this.lblSoDuMax);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.panel4.Size = new System.Drawing.Size(245, 110);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblSubMax
            // 
            this.lblSubMax.AutoSize = true;
            this.lblSubMax.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubMax.ForeColor = System.Drawing.Color.Gray;
            this.lblSubMax.Location = new System.Drawing.Point(14, 52);
            this.lblSubMax.Name = "lblSubMax";
            this.lblSubMax.Size = new System.Drawing.Size(153, 21);
            this.lblSubMax.TabIndex = 0;
            this.lblSubMax.Text = "Tài khoản nhiều nhất";
            // 
            // lblSoDuMax
            // 
            this.lblSoDuMax.AutoSize = true;
            this.lblSoDuMax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoDuMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(110)))), ((int)(((byte)(20)))));
            this.lblSoDuMax.Location = new System.Drawing.Point(12, 28);
            this.lblSoDuMax.Name = "lblSoDuMax";
            this.lblSoDuMax.Size = new System.Drawing.Size(88, 32);
            this.lblSoDuMax.TabIndex = 1;
            this.lblSoDuMax.Text = "0 VNĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(14, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "SỐ DƯ CAO NHẤT";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblSubMin);
            this.panel3.Controls.Add(this.lblSoDuMin);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.panel3.Size = new System.Drawing.Size(242, 110);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblSubMin
            // 
            this.lblSubMin.AutoSize = true;
            this.lblSubMin.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubMin.ForeColor = System.Drawing.Color.Gray;
            this.lblSubMin.Location = new System.Drawing.Point(14, 52);
            this.lblSubMin.Name = "lblSubMin";
            this.lblSubMin.Size = new System.Drawing.Size(123, 21);
            this.lblSubMin.TabIndex = 0;
            this.lblSubMin.Text = "Tài khoản ít nhất";
            // 
            // lblSoDuMin
            // 
            this.lblSoDuMin.AutoSize = true;
            this.lblSoDuMin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoDuMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblSoDuMin.Location = new System.Drawing.Point(12, 28);
            this.lblSoDuMin.Name = "lblSoDuMin";
            this.lblSoDuMin.Size = new System.Drawing.Size(88, 32);
            this.lblSoDuMin.TabIndex = 1;
            this.lblSoDuMin.Text = "0 VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(14, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "SỐ DƯ THẤP NHẤT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblSubTB);
            this.panel2.Controls.Add(this.lblSoDuTB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(243, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.panel2.Size = new System.Drawing.Size(242, 113);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblSubTB
            // 
            this.lblSubTB.AutoSize = true;
            this.lblSubTB.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubTB.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTB.Location = new System.Drawing.Point(14, 52);
            this.lblSubTB.Name = "lblSubTB";
            this.lblSubTB.Size = new System.Drawing.Size(105, 21);
            this.lblSubTB.TabIndex = 0;
            this.lblSubTB.Text = "Mọi tài khoản";
            // 
            // lblSoDuTB
            // 
            this.lblSoDuTB.AutoSize = true;
            this.lblSoDuTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoDuTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblSoDuTB.Location = new System.Drawing.Point(12, 28);
            this.lblSoDuTB.Name = "lblSoDuTB";
            this.lblSoDuTB.Size = new System.Drawing.Size(88, 32);
            this.lblSoDuTB.TabIndex = 1;
            this.lblSoDuTB.Text = "0 VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(14, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "SỐ DƯ TRUNG BÌNH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSubTong);
            this.panel1.Controls.Add(this.lblTongSoDu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.panel1.Size = new System.Drawing.Size(245, 113);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.StatCard_Paint);
            // 
            // lblSubTong
            // 
            this.lblSubTong.AutoSize = true;
            this.lblSubTong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubTong.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTong.Location = new System.Drawing.Point(14, 52);
            this.lblSubTong.Name = "lblSubTong";
            this.lblSubTong.Size = new System.Drawing.Size(132, 21);
            this.lblSubTong.TabIndex = 0;
            this.lblSubTong.Text = "Toàn bộ tài khoản";
            // 
            // lblTongSoDu
            // 
            this.lblTongSoDu.AutoSize = true;
            this.lblTongSoDu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongSoDu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.lblTongSoDu.Location = new System.Drawing.Point(12, 28);
            this.lblTongSoDu.Name = "lblTongSoDu";
            this.lblTongSoDu.Size = new System.Drawing.Size(88, 32);
            this.lblTongSoDu.TabIndex = 1;
            this.lblTongSoDu.Text = "0 VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "TỔNG SỐ DƯ";
            // 
            // pnlChartCard
            // 
            this.pnlChartCard.BackColor = System.Drawing.Color.White;
            this.pnlChartCard.Controls.Add(this.chartCoCau);
            this.pnlChartCard.Controls.Add(this.lblChartTitle);
            this.pnlChartCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChartCard.Location = new System.Drawing.Point(12, 0);
            this.pnlChartCard.Name = "pnlChartCard";
            this.pnlChartCard.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlChartCard.Size = new System.Drawing.Size(490, 425);
            this.pnlChartCard.TabIndex = 1;
            this.pnlChartCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // chartCoCau
            // 
            this.chartCoCau.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.chartCoCau.ChartAreas.Add(chartArea6);
            this.chartCoCau.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chartCoCau.Legends.Add(legend6);
            this.chartCoCau.Location = new System.Drawing.Point(12, 8);
            this.chartCoCau.Name = "chartCoCau";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartCoCau.Series.Add(series6);
            this.chartCoCau.Size = new System.Drawing.Size(466, 409);
            this.chartCoCau.TabIndex = 0;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblChartTitle.Location = new System.Drawing.Point(12, 8);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(144, 28);
            this.lblChartTitle.TabIndex = 1;
            this.lblChartTitle.Text = "Cơ cấu tài sản";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnlLeft.Controls.Add(this.pnlGridCard);
            this.pnlLeft.Controls.Add(this.pnlInputCard);
            this.pnlLeft.Controls.Add(this.pnlLeftHeader);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(520, 660);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.dgvTaiKhoan);
            this.pnlGridCard.Controls.Add(this.lblGridTitle);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(0, 248);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(14, 8, 14, 14);
            this.pnlGridCard.Size = new System.Drawing.Size(520, 412);
            this.pnlGridCard.TabIndex = 0;
            this.pnlGridCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(236)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(14, 8);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 34;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(492, 390);
            this.dgvTaiKhoan.TabIndex = 0;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblGridTitle.Location = new System.Drawing.Point(14, 8);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(205, 28);
            this.lblGridTitle.TabIndex = 1;
            this.lblGridTitle.Text = "Danh sách tài khoản";
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.Controls.Add(this.pnlButtons);
            this.pnlInputCard.Controls.Add(this.pnlInputFields);
            this.pnlInputCard.Controls.Add(this.lblInputTitle);
            this.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInputCard.Location = new System.Drawing.Point(0, 52);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Padding = new System.Windows.Forms.Padding(14, 10, 14, 8);
            this.pnlInputCard.Size = new System.Drawing.Size(520, 196);
            this.pnlInputCard.TabIndex = 1;
            this.pnlInputCard.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btn_Them);
            this.pnlButtons.Controls.Add(this.btn_Sua);
            this.pnlButtons.Controls.Add(this.btn_Xoa);
            this.pnlButtons.Controls.Add(this.btn_Reset);
            this.pnlButtons.Location = new System.Drawing.Point(14, 154);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(547, 32);
            this.pnlButtons.TabIndex = 0;
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
            this.btn_Them.Size = new System.Drawing.Size(108, 32);
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
            this.btn_Sua.Location = new System.Drawing.Point(116, 0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(108, 32);
            this.btn_Sua.TabIndex = 1;
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
            this.btn_Xoa.Location = new System.Drawing.Point(232, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 32);
            this.btn_Xoa.TabIndex = 2;
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
            this.btn_Reset.Location = new System.Drawing.Point(328, 0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(101, 32);
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "Làm mới";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // pnlInputFields
            // 
            this.pnlInputFields.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInputFields.BackColor = System.Drawing.Color.Transparent;
            this.pnlInputFields.Controls.Add(this.label4);
            this.pnlInputFields.Controls.Add(this.txt_TenTK);
            this.pnlInputFields.Controls.Add(this.label5);
            this.pnlInputFields.Controls.Add(this.cbo_LoaiTK);
            this.pnlInputFields.Controls.Add(this.label2);
            this.pnlInputFields.Controls.Add(this.txt_SoDu);
            this.pnlInputFields.Controls.Add(this.label3);
            this.pnlInputFields.Controls.Add(this.txt_TenNH);
            this.pnlInputFields.Location = new System.Drawing.Point(14, 36);
            this.pnlInputFields.Name = "pnlInputFields";
            this.pnlInputFields.Size = new System.Drawing.Size(558, 110);
            this.pnlInputFields.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(0, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên tài khoản:";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenTK.Location = new System.Drawing.Point(108, 4);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(143, 31);
            this.txt_TenTK.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(269, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại:";
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(307, 4);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(158, 33);
            this.cbo_LoaiTK.TabIndex = 2;
            this.cbo_LoaiTK.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiTK_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(0, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số dư ban đầu:";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoDu.Location = new System.Drawing.Point(108, 40);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Size = new System.Drawing.Size(143, 31);
            this.txt_SoDu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(269, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngân hàng / Ví:";
            // 
            // txt_TenNH
            // 
            this.txt_TenNH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenNH.Location = new System.Drawing.Point(357, 40);
            this.txt_TenNH.Name = "txt_TenNH";
            this.txt_TenNH.Size = new System.Drawing.Size(134, 31);
            this.txt_TenNH.TabIndex = 4;
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.AutoSize = true;
            this.lblInputTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblInputTitle.Location = new System.Drawing.Point(14, 10);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(254, 28);
            this.lblInputTitle.TabIndex = 2;
            this.lblInputTitle.Text = "Tạo / chỉnh sửa tài khoản";
            // 
            // pnlLeftHeader
            // 
            this.pnlLeftHeader.BackColor = System.Drawing.Color.White;
            this.pnlLeftHeader.Controls.Add(this.btn_Thoat);
            this.pnlLeftHeader.Controls.Add(this.lblFormTitle);
            this.pnlLeftHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftHeader.Name = "pnlLeftHeader";
            this.pnlLeftHeader.Size = new System.Drawing.Size(520, 52);
            this.pnlLeftHeader.TabIndex = 2;
            this.pnlLeftHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.TopBar_Paint);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Thoat.ForeColor = System.Drawing.Color.LightBlue;
            this.btn_Thoat.Location = new System.Drawing.Point(748, 12);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(76, 28);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblFormTitle.Location = new System.Drawing.Point(18, 14);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(231, 36);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Quản lý tài khoản";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(12, 550);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(490, 110);
            this.panel5.TabIndex = 2;
            // 
            // FrmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1022, 660);
            this.Controls.Add(this.pnlOuter);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(860, 560);
            this.Name = "FrmTaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.form_TaiKhoan_Load);
            this.Resize += new System.EventHandler(this.FrmTaiKhoan_Resize);
            this.pnlOuter.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlStatStack.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlChartCard.ResumeLayout(false);
            this.pnlChartCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCoCau)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            this.pnlGridCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlInputFields.ResumeLayout(false);
            this.pnlInputFields.PerformLayout();
            this.pnlLeftHeader.ResumeLayout(false);
            this.pnlLeftHeader.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ─────────────────────────────────────
        private System.Windows.Forms.Panel pnlOuter;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlLeftHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Panel pnlInputFields;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_LoaiTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoDu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenNH;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Panel pnlChartCard;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCoCau;
        private System.Windows.Forms.Panel pnlStatStack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTongSoDu;
        private System.Windows.Forms.Label lblSubTong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSoDuTB;
        private System.Windows.Forms.Label lblSubTB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSoDuMin;
        private System.Windows.Forms.Label lblSubMin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSoDuMax;
        private System.Windows.Forms.Label lblSubMax;
        private System.Windows.Forms.Panel panel5;
    }
}