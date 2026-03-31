namespace Project_FinancePersonalManagement
{
    partial class FrmNganSach
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgv_nganSach = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.budgetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbo_DanhMuc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nganSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_nganSach
            // 
            this.dgv_nganSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nganSach.Location = new System.Drawing.Point(30, 305);
            this.dgv_nganSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_nganSach.Name = "dgv_nganSach";
            this.dgv_nganSach.RowHeadersWidth = 51;
            this.dgv_nganSach.RowTemplate.Height = 24;
            this.dgv_nganSach.Size = new System.Drawing.Size(856, 242);
            this.dgv_nganSach.TabIndex = 0;
            this.dgv_nganSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nganSach_CellClick_1);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(370, 28);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 29);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(370, 81);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(84, 29);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(370, 139);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(84, 29);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(370, 194);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(84, 29);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh mục:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số tiền:";
            // 
            // txt_soTien
            // 
            this.txt_soTien.Location = new System.Drawing.Point(171, 81);
            this.txt_soTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_soTien.Name = "txt_soTien";
            this.txt_soTien.Size = new System.Drawing.Size(172, 26);
            this.txt_soTien.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tháng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Năm:";
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(171, 127);
            this.txt_thang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(172, 26);
            this.txt_thang.TabIndex = 3;
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(171, 171);
            this.txt_nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(172, 26);
            this.txt_nam.TabIndex = 3;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(370, 246);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(84, 29);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // budgetChart
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = -45;
            chartArea2.Name = "ChartArea1";
            this.budgetChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.budgetChart.Legends.Add(legend2);
            this.budgetChart.Location = new System.Drawing.Point(492, 28);
            this.budgetChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.budgetChart.Name = "budgetChart";
            this.budgetChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.budgetChart.Series.Add(series2);
            this.budgetChart.Size = new System.Drawing.Size(394, 252);
            this.budgetChart.TabIndex = 4;
            this.budgetChart.Text = "chart1";
            // 
            // cbo_DanhMuc
            // 
            this.cbo_DanhMuc.FormattingEnabled = true;
            this.cbo_DanhMuc.Location = new System.Drawing.Point(171, 33);
            this.cbo_DanhMuc.Name = "cbo_DanhMuc";
            this.cbo_DanhMuc.Size = new System.Drawing.Size(171, 28);
            this.cbo_DanhMuc.TabIndex = 5;
            // 
            // frm_nganSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.cbo_DanhMuc);
            this.Controls.Add(this.budgetChart);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.txt_thang);
            this.Controls.Add(this.txt_soTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dgv_nganSach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_nganSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngân Sách";
            this.Load += new System.EventHandler(this.frm_nganSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nganSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_nganSach;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataVisualization.Charting.Chart budgetChart;
        private System.Windows.Forms.ComboBox cbo_DanhMuc;
    }
}