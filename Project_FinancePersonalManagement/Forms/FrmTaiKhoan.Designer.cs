namespace Project_FinancePersonalManagement
{
    partial class FrmTaiKhoan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.txt_TenNH = new System.Windows.Forms.TextBox();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongSoDu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSoDuTB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSoDuMin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSoDuMax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartCoCau = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cbo_LoaiTK = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCoCau)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số dư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên ngân hàng / Ví:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên tài khoản:";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.Location = new System.Drawing.Point(155, 156);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Size = new System.Drawing.Size(189, 26);
            this.txt_SoDu.TabIndex = 5;
            // 
            // txt_TenNH
            // 
            this.txt_TenNH.Location = new System.Drawing.Point(571, 159);
            this.txt_TenNH.Name = "txt_TenNH";
            this.txt_TenNH.Size = new System.Drawing.Size(189, 26);
            this.txt_TenNH.TabIndex = 6;
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Location = new System.Drawing.Point(155, 105);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(189, 26);
            this.txt_TenTK.TabIndex = 7;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(21, 268);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(465, 309);
            this.dgvTaiKhoan.TabIndex = 8;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(624, 201);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(104, 39);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(21, 201);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 39);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(171, 201);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 39);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblTongSoDu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(21, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 63);
            this.panel1.TabIndex = 13;
            // 
            // lblTongSoDu
            // 
            this.lblTongSoDu.AutoSize = true;
            this.lblTongSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoDu.Location = new System.Drawing.Point(24, 36);
            this.lblTongSoDu.Name = "lblTongSoDu";
            this.lblTongSoDu.Size = new System.Drawing.Size(81, 20);
            this.lblTongSoDu.TabIndex = 1;
            this.lblTongSoDu.Text = "000 VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng số dư:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.lblSoDuTB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(244, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 63);
            this.panel2.TabIndex = 14;
            // 
            // lblSoDuTB
            // 
            this.lblSoDuTB.AutoSize = true;
            this.lblSoDuTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblSoDuTB.Location = new System.Drawing.Point(26, 36);
            this.lblSoDuTB.Name = "lblSoDuTB";
            this.lblSoDuTB.Size = new System.Drawing.Size(81, 20);
            this.lblSoDuTB.TabIndex = 1;
            this.lblSoDuTB.Text = "000 VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số dư trung bình:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.lblSoDuMin);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(476, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 63);
            this.panel3.TabIndex = 15;
            // 
            // lblSoDuMin
            // 
            this.lblSoDuMin.AutoSize = true;
            this.lblSoDuMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblSoDuMin.Location = new System.Drawing.Point(24, 36);
            this.lblSoDuMin.Name = "lblSoDuMin";
            this.lblSoDuMin.Size = new System.Drawing.Size(81, 20);
            this.lblSoDuMin.TabIndex = 1;
            this.lblSoDuMin.Text = "000 VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số dư Min";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.HotPink;
            this.panel4.Controls.Add(this.lblSoDuMax);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(700, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 63);
            this.panel4.TabIndex = 16;
            // 
            // lblSoDuMax
            // 
            this.lblSoDuMax.AutoSize = true;
            this.lblSoDuMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblSoDuMax.Location = new System.Drawing.Point(29, 36);
            this.lblSoDuMax.Name = "lblSoDuMax";
            this.lblSoDuMax.Size = new System.Drawing.Size(81, 20);
            this.lblSoDuMax.TabIndex = 1;
            this.lblSoDuMax.Text = "000 VNĐ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số dư Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Loại tài khoản:";
            // 
            // chartCoCau
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCoCau.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCoCau.Legends.Add(legend2);
            this.chartCoCau.Location = new System.Drawing.Point(514, 268);
            this.chartCoCau.Name = "chartCoCau";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCoCau.Series.Add(series2);
            this.chartCoCau.Size = new System.Drawing.Size(388, 316);
            this.chartCoCau.TabIndex = 19;
            this.chartCoCau.Text = "chart1";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(476, 201);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(104, 39);
            this.btn_Reset.TabIndex = 20;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(571, 105);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(189, 28);
            this.cbo_LoaiTK.TabIndex = 21;
            this.cbo_LoaiTK.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiTK_SelectedIndexChanged);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(322, 201);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 39);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // form_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 616);
            this.Controls.Add(this.cbo_LoaiTK);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.chartCoCau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.txt_TenTK);
            this.Controls.Add(this.txt_TenNH);
            this.Controls.Add(this.txt_SoDu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "form_TaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.form_TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCoCau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SoDu;
        private System.Windows.Forms.TextBox txt_TenNH;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCoCau;
        private System.Windows.Forms.Label lblTongSoDu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoDuTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSoDuMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSoDuMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cbo_LoaiTK;
        private System.Windows.Forms.Button btn_Xoa;
    }
}