namespace Project_FinancePersonalManagement
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_Filter = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelChart1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chartThuChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelChart2 = new System.Windows.Forms.Panel();
            this.lbl_DanhMuc = new System.Windows.Forms.Label();
            this.chartThuNhapThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelChart3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chartNoVay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThangTruoc = new System.Windows.Forms.Button();
            this.btnThangSau = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.panel_Filter.SuspendLayout();
            this.PanelChart1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuChi)).BeginInit();
            this.PanelChart2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuNhapThang)).BeginInit();
            this.PanelChart3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoVay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Filter
            // 
            this.panel_Filter.Controls.Add(this.btnInBaoCao);
            this.panel_Filter.Controls.Add(this.btn_Exit);
            this.panel_Filter.Controls.Add(this.btn_Filter);
            this.panel_Filter.Controls.Add(this.dtpDenNgay);
            this.panel_Filter.Controls.Add(this.label2);
            this.panel_Filter.Controls.Add(this.dtpTuNgay);
            this.panel_Filter.Controls.Add(this.label1);
            this.panel_Filter.Location = new System.Drawing.Point(31, 8);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(828, 50);
            this.panel_Filter.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(715, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 44);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Filter.FlatAppearance.BorderSize = 0;
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.Location = new System.Drawing.Point(484, 4);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(111, 44);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(328, 11);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(118, 24);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(72, 11);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(111, 24);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // PanelChart1
            // 
            this.PanelChart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart1.BackColor = System.Drawing.Color.White;
            this.PanelChart1.Controls.Add(this.label3);
            this.PanelChart1.Controls.Add(this.chartThuChi);
            this.PanelChart1.Location = new System.Drawing.Point(31, 83);
            this.PanelChart1.Name = "PanelChart1";
            this.PanelChart1.Size = new System.Drawing.Size(828, 208);
            this.PanelChart1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê thu nhập và chi tiêu";
            // 
            // chartThuChi
            // 
            this.chartThuChi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea4.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.BorderWidth = 0;
            chartArea4.Name = "ChartArea1";
            this.chartThuChi.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chartThuChi.Legends.Add(legend4);
            this.chartThuChi.Location = new System.Drawing.Point(0, 39);
            this.chartThuChi.Name = "chartThuChi";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chartThuChi.Series.Add(series5);
            this.chartThuChi.Series.Add(series6);
            this.chartThuChi.Size = new System.Drawing.Size(828, 166);
            this.chartThuChi.TabIndex = 0;
            this.chartThuChi.Text = "chart1";
            // 
            // PanelChart2
            // 
            this.PanelChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelChart2.BackColor = System.Drawing.Color.White;
            this.PanelChart2.Controls.Add(this.btnThangSau);
            this.PanelChart2.Controls.Add(this.btnThangTruoc);
            this.PanelChart2.Controls.Add(this.lbl_DanhMuc);
            this.PanelChart2.Controls.Add(this.chartThuNhapThang);
            this.PanelChart2.Location = new System.Drawing.Point(24, 311);
            this.PanelChart2.Name = "PanelChart2";
            this.PanelChart2.Size = new System.Drawing.Size(453, 270);
            this.PanelChart2.TabIndex = 2;
            // 
            // lbl_DanhMuc
            // 
            this.lbl_DanhMuc.AutoSize = true;
            this.lbl_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_DanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lbl_DanhMuc.Location = new System.Drawing.Point(13, 15);
            this.lbl_DanhMuc.Name = "lbl_DanhMuc";
            this.lbl_DanhMuc.Size = new System.Drawing.Size(268, 21);
            this.lbl_DanhMuc.TabIndex = 1;
            this.lbl_DanhMuc.Text = "Ngân sách và chi tiêu trong tháng";
            // 
            // chartThuNhapThang
            // 
            this.chartThuNhapThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea5.AxisX.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DimGray;
            chartArea5.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.BorderWidth = 0;
            chartArea5.Name = "ChartArea1";
            this.chartThuNhapThang.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartThuNhapThang.Legends.Add(legend5);
            this.chartThuNhapThang.Location = new System.Drawing.Point(0, 46);
            this.chartThuNhapThang.Name = "chartThuNhapThang";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartThuNhapThang.Series.Add(series7);
            this.chartThuNhapThang.Size = new System.Drawing.Size(453, 221);
            this.chartThuNhapThang.TabIndex = 0;
            this.chartThuNhapThang.Text = "chart2";
            // 
            // PanelChart3
            // 
            this.PanelChart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart3.BackColor = System.Drawing.Color.White;
            this.PanelChart3.Controls.Add(this.label5);
            this.PanelChart3.Controls.Add(this.chartNoVay);
            this.PanelChart3.Location = new System.Drawing.Point(481, 311);
            this.PanelChart3.Name = "PanelChart3";
            this.PanelChart3.Size = new System.Drawing.Size(395, 270);
            this.PanelChart3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thống kê Nợ/Vay";
            // 
            // chartNoVay
            // 
            this.chartNoVay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.BackColor = System.Drawing.Color.White;
            chartArea6.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.chartNoVay.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.chartNoVay.Legends.Add(legend6);
            this.chartNoVay.Location = new System.Drawing.Point(2, 46);
            this.chartNoVay.Name = "chartNoVay";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartNoVay.Series.Add(series8);
            this.chartNoVay.Size = new System.Drawing.Size(393, 221);
            this.chartNoVay.TabIndex = 0;
            this.chartNoVay.Text = "chart3";
            // 
            // btnThangTruoc
            // 
            this.btnThangTruoc.Location = new System.Drawing.Point(359, 3);
            this.btnThangTruoc.Name = "btnThangTruoc";
            this.btnThangTruoc.Size = new System.Drawing.Size(37, 31);
            this.btnThangTruoc.TabIndex = 2;
            this.btnThangTruoc.Text = "<";
            this.btnThangTruoc.UseVisualStyleBackColor = true;
            this.btnThangTruoc.Click += new System.EventHandler(this.btnThangTruoc_Click);
            // 
            // btnThangSau
            // 
            this.btnThangSau.Location = new System.Drawing.Point(402, 3);
            this.btnThangSau.Name = "btnThangSau";
            this.btnThangSau.Size = new System.Drawing.Size(39, 33);
            this.btnThangSau.TabIndex = 3;
            this.btnThangSau.Text = ">";
            this.btnThangSau.UseVisualStyleBackColor = true;
            this.btnThangSau.Click += new System.EventHandler(this.btnThangSau_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInBaoCao.FlatAppearance.BorderSize = 0;
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnInBaoCao.Location = new System.Drawing.Point(599, 3);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(111, 44);
            this.btnInBaoCao.TabIndex = 6;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(888, 597);
            this.Controls.Add(this.PanelChart3);
            this.Controls.Add(this.PanelChart2);
            this.Controls.Add(this.PanelChart1);
            this.Controls.Add(this.panel_Filter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê tài chính";
            this.Load += new System.EventHandler(this.form_ThongKe_Load);
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            this.PanelChart1.ResumeLayout(false);
            this.PanelChart1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuChi)).EndInit();
            this.PanelChart2.ResumeLayout(false);
            this.PanelChart2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThuNhapThang)).EndInit();
            this.PanelChart3.ResumeLayout(false);
            this.PanelChart3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNoVay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Filter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelChart1;
        private System.Windows.Forms.Panel PanelChart2;
        private System.Windows.Forms.Panel PanelChart3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuChi;
        private System.Windows.Forms.Label lbl_DanhMuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuNhapThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNoVay;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btnThangSau;
        private System.Windows.Forms.Button btnThangTruoc;
        private System.Windows.Forms.Button btnInBaoCao;
    }
}