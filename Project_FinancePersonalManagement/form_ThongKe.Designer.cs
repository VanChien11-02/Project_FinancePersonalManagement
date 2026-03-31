namespace Project_FinancePersonalManagement
{
    partial class form_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label4 = new System.Windows.Forms.Label();
            this.chartThuNhapThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelChart3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chartNoVay = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.panel_Filter.Controls.Add(this.btn_Exit);
            this.panel_Filter.Controls.Add(this.btn_Filter);
            this.panel_Filter.Controls.Add(this.dtpDenNgay);
            this.panel_Filter.Controls.Add(this.label2);
            this.panel_Filter.Controls.Add(this.dtpTuNgay);
            this.panel_Filter.Controls.Add(this.label1);
            this.panel_Filter.Location = new System.Drawing.Point(28, 6);
            this.panel_Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(736, 40);
            this.panel_Filter.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(641, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 38);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Filter.Location = new System.Drawing.Point(529, 0);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(101, 38);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(364, 7);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(146, 22);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(81, 8);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(170, 22);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // PanelChart1
            // 
            this.PanelChart1.Controls.Add(this.label3);
            this.PanelChart1.Controls.Add(this.chartThuChi);
            this.PanelChart1.Location = new System.Drawing.Point(28, 66);
            this.PanelChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelChart1.Name = "PanelChart1";
            this.PanelChart1.Size = new System.Drawing.Size(736, 166);
            this.PanelChart1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thống kê thu nhập và chi tiêu";
            // 
            // chartThuChi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThuChi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThuChi.Legends.Add(legend1);
            this.chartThuChi.Location = new System.Drawing.Point(0, 31);
            this.chartThuChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartThuChi.Name = "chartThuChi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chartThuChi.Series.Add(series1);
            this.chartThuChi.Series.Add(series2);
            this.chartThuChi.Size = new System.Drawing.Size(736, 134);
            this.chartThuChi.TabIndex = 0;
            this.chartThuChi.Text = "chart1";
            // 
            // PanelChart2
            // 
            this.PanelChart2.Controls.Add(this.label4);
            this.PanelChart2.Controls.Add(this.chartThuNhapThang);
            this.PanelChart2.Location = new System.Drawing.Point(28, 249);
            this.PanelChart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelChart2.Name = "PanelChart2";
            this.PanelChart2.Size = new System.Drawing.Size(368, 216);
            this.PanelChart2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thu nhập theo tháng";
            // 
            // chartThuNhapThang
            // 
            chartArea2.Name = "ChartArea1";
            this.chartThuNhapThang.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartThuNhapThang.Legends.Add(legend2);
            this.chartThuNhapThang.Location = new System.Drawing.Point(0, 32);
            this.chartThuNhapThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartThuNhapThang.Name = "chartThuNhapThang";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartThuNhapThang.Series.Add(series3);
            this.chartThuNhapThang.Size = new System.Drawing.Size(368, 184);
            this.chartThuNhapThang.TabIndex = 0;
            this.chartThuNhapThang.Text = "chart2";
            // 
            // PanelChart3
            // 
            this.PanelChart3.Controls.Add(this.label5);
            this.PanelChart3.Controls.Add(this.chartNoVay);
            this.PanelChart3.Location = new System.Drawing.Point(413, 249);
            this.PanelChart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelChart3.Name = "PanelChart3";
            this.PanelChart3.Size = new System.Drawing.Size(348, 216);
            this.PanelChart3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thống kê Nợ/Vay";
            // 
            // chartNoVay
            // 
            chartArea3.Name = "ChartArea1";
            this.chartNoVay.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartNoVay.Legends.Add(legend3);
            this.chartNoVay.Location = new System.Drawing.Point(2, 34);
            this.chartNoVay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartNoVay.Name = "chartNoVay";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartNoVay.Series.Add(series4);
            this.chartNoVay.Size = new System.Drawing.Size(348, 182);
            this.chartNoVay.TabIndex = 0;
            this.chartNoVay.Text = "chart3";
            // 
            // form_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 478);
            this.Controls.Add(this.PanelChart3);
            this.Controls.Add(this.PanelChart2);
            this.Controls.Add(this.PanelChart1);
            this.Controls.Add(this.panel_Filter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_ThongKe";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuNhapThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNoVay;
        private System.Windows.Forms.Button btn_Exit;
    }
}