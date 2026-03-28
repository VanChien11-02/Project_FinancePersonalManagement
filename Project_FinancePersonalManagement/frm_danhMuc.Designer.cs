namespace Project_FinancePersonalManagement
{
    partial class frm_danhMuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.rAll = new System.Windows.Forms.RadioButton();
            this.rThuNhap = new System.Windows.Forms.RadioButton();
            this.rChiTieu = new System.Windows.Forms.RadioButton();
            this.dgv_danhMuc = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenDanhMuc = new System.Windows.Forms.TextBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.cbo_LoaiDM = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc danh mục theo:";
            // 
            // rAll
            // 
            this.rAll.AutoSize = true;
            this.rAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rAll.Location = new System.Drawing.Point(338, 12);
            this.rAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rAll.Name = "rAll";
            this.rAll.Size = new System.Drawing.Size(86, 26);
            this.rAll.TabIndex = 1;
            this.rAll.TabStop = true;
            this.rAll.Text = "Tất cả";
            this.rAll.UseVisualStyleBackColor = true;
            this.rAll.CheckedChanged += new System.EventHandler(this.rAll_CheckedChanged);
            // 
            // rThuNhap
            // 
            this.rThuNhap.AutoSize = true;
            this.rThuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rThuNhap.Location = new System.Drawing.Point(338, 62);
            this.rThuNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rThuNhap.Name = "rThuNhap";
            this.rThuNhap.Size = new System.Drawing.Size(112, 26);
            this.rThuNhap.TabIndex = 1;
            this.rThuNhap.TabStop = true;
            this.rThuNhap.Text = "Thu nhập";
            this.rThuNhap.UseVisualStyleBackColor = true;
            this.rThuNhap.CheckedChanged += new System.EventHandler(this.rThuNhap_CheckedChanged);
            // 
            // rChiTieu
            // 
            this.rChiTieu.AutoSize = true;
            this.rChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rChiTieu.Location = new System.Drawing.Point(338, 111);
            this.rChiTieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rChiTieu.Name = "rChiTieu";
            this.rChiTieu.Size = new System.Drawing.Size(96, 26);
            this.rChiTieu.TabIndex = 1;
            this.rChiTieu.TabStop = true;
            this.rChiTieu.Text = "Chi tiêu";
            this.rChiTieu.UseVisualStyleBackColor = true;
            this.rChiTieu.CheckedChanged += new System.EventHandler(this.rChiTieu_CheckedChanged);
            // 
            // dgv_danhMuc
            // 
            this.dgv_danhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhMuc.Location = new System.Drawing.Point(94, 401);
            this.dgv_danhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_danhMuc.Name = "dgv_danhMuc";
            this.dgv_danhMuc.RowHeadersWidth = 51;
            this.dgv_danhMuc.RowTemplate.Height = 24;
            this.dgv_danhMuc.Size = new System.Drawing.Size(767, 249);
            this.dgv_danhMuc.TabIndex = 2;
            this.dgv_danhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhMuc_CellClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(747, 87);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(115, 50);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(747, 12);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(115, 50);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(746, 308);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(115, 50);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(747, 158);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(115, 50);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(746, 233);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(115, 50);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên danh mục:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại danh mục:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú:";
            // 
            // txt_tenDanhMuc
            // 
            this.txt_tenDanhMuc.Location = new System.Drawing.Point(222, 182);
            this.txt_tenDanhMuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenDanhMuc.Name = "txt_tenDanhMuc";
            this.txt_tenDanhMuc.Size = new System.Drawing.Size(228, 26);
            this.txt_tenDanhMuc.TabIndex = 5;
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(222, 257);
            this.txt_ghiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(228, 26);
            this.txt_ghiChu.TabIndex = 5;
            // 
            // cbo_LoaiDM
            // 
            this.cbo_LoaiDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiDM.FormattingEnabled = true;
            this.cbo_LoaiDM.Location = new System.Drawing.Point(222, 215);
            this.cbo_LoaiDM.Name = "cbo_LoaiDM";
            this.cbo_LoaiDM.Size = new System.Drawing.Size(228, 28);
            this.cbo_LoaiDM.TabIndex = 6;
            // 
            // frm_danhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 684);
            this.Controls.Add(this.cbo_LoaiDM);
            this.Controls.Add(this.txt_ghiChu);
            this.Controls.Add(this.txt_tenDanhMuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.dgv_danhMuc);
            this.Controls.Add(this.rChiTieu);
            this.Controls.Add(this.rThuNhap);
            this.Controls.Add(this.rAll);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_danhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục";
            this.Load += new System.EventHandler(this.frm_danhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rAll;
        private System.Windows.Forms.RadioButton rThuNhap;
        private System.Windows.Forms.RadioButton rChiTieu;
        private System.Windows.Forms.DataGridView dgv_danhMuc;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenDanhMuc;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.ComboBox cbo_LoaiDM;
    }
}