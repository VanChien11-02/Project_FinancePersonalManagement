namespace Project_FinancePersonalManagement
{
    partial class Form_Menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menu_feature = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoảnNợKhoànVayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngânSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.status_user = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.time_clock = new System.Windows.Forms.Timer(this.components);
            this.panel_Balance = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.lblTitleBalance = new System.Windows.Forms.Label();
            this.panel_income = new System.Windows.Forms.Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblTitleIncome = new System.Windows.Forms.Label();
            this.panel_Expense = new System.Windows.Forms.Panel();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblTitleExpense = new System.Windows.Forms.Label();
            this.chartChiTieu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_feature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.status_user.SuspendLayout();
            this.panel_Balance.SuspendLayout();
            this.panel_income.SuspendLayout();
            this.panel_Expense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiTieu)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_feature
            // 
            this.menu_feature.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu_feature.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_feature.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.tàiKhoànToolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.khoảnNợKhoànVayToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.ngânSáchToolStripMenuItem});
            this.menu_feature.Location = new System.Drawing.Point(0, 0);
            this.menu_feature.Name = "menu_feature";
            this.menu_feature.Size = new System.Drawing.Size(1143, 33);
            this.menu_feature.TabIndex = 0;
            this.menu_feature.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngKíToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngKíToolStripMenuItem
            // 
            this.đăngKíToolStripMenuItem.Name = "đăngKíToolStripMenuItem";
            this.đăngKíToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.đăngKíToolStripMenuItem.Text = "Đăng kí";
            this.đăngKíToolStripMenuItem.Click += new System.EventHandler(this.đăngKíToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // tàiKhoànToolStripMenuItem
            // 
            this.tàiKhoànToolStripMenuItem.Name = "tàiKhoànToolStripMenuItem";
            this.tàiKhoànToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.tàiKhoànToolStripMenuItem.Text = "Tài khoàn";
            this.tàiKhoànToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoànToolStripMenuItem_Click);
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.giaoDịchToolStripMenuItem.Text = "Giao dịch";
            this.giaoDịchToolStripMenuItem.Click += new System.EventHandler(this.giaoDịchToolStripMenuItem_Click);
            // 
            // khoảnNợKhoànVayToolStripMenuItem
            // 
            this.khoảnNợKhoànVayToolStripMenuItem.Name = "khoảnNợKhoànVayToolStripMenuItem";
            this.khoảnNợKhoànVayToolStripMenuItem.Size = new System.Drawing.Size(234, 29);
            this.khoảnNợKhoànVayToolStripMenuItem.Text = "Khoản vay, khoản cho vay";
            this.khoảnNợKhoànVayToolStripMenuItem.Click += new System.EventHandler(this.khoảnNợKhoànVayToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // ngânSáchToolStripMenuItem
            // 
            this.ngânSáchToolStripMenuItem.Name = "ngânSáchToolStripMenuItem";
            this.ngânSáchToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.ngânSáchToolStripMenuItem.Text = "Ngân sách";
            this.ngânSáchToolStripMenuItem.Click += new System.EventHandler(this.ngânSáchToolStripMenuItem_Click);
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.Location = new System.Drawing.Point(25, 174);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.ReadOnly = true;
            this.dgv_Accounts.RowHeadersWidth = 62;
            this.dgv_Accounts.RowTemplate.Height = 28;
            this.dgv_Accounts.Size = new System.Drawing.Size(670, 339);
            this.dgv_Accounts.TabIndex = 4;
            // 
            // status_user
            // 
            this.status_user.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.status_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblUser,
            this.lblTime});
            this.status_user.Location = new System.Drawing.Point(0, 551);
            this.status_user.Name = "status_user";
            this.status_user.Size = new System.Drawing.Size(1143, 32);
            this.status_user.TabIndex = 8;
            this.status_user.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 25);
            this.lblStatus.Text = "Sẵn sàng";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(144, 25);
            this.lblUser.Text = "Chưa đăng nhập";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(203, 25);
            this.lblTime.Text = "dd/MM/yyyy HH:mm:ss";
            // 
            // time_clock
            // 
            this.time_clock.Enabled = true;
            this.time_clock.Interval = 1000;
            this.time_clock.Tick += new System.EventHandler(this.time_clock_Tick);
            // 
            // panel_Balance
            // 
            this.panel_Balance.BackColor = System.Drawing.Color.Turquoise;
            this.panel_Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Balance.Controls.Add(this.lblTotalBalance);
            this.panel_Balance.Controls.Add(this.lblTitleBalance);
            this.panel_Balance.Location = new System.Drawing.Point(25, 55);
            this.panel_Balance.Name = "panel_Balance";
            this.panel_Balance.Size = new System.Drawing.Size(351, 64);
            this.panel_Balance.TabIndex = 9;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalBalance.Location = new System.Drawing.Point(20, 30);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(124, 30);
            this.lblTotalBalance.TabIndex = 1;
            this.lblTotalBalance.Text = "000 VNĐ";
            // 
            // lblTitleBalance
            // 
            this.lblTitleBalance.AutoSize = true;
            this.lblTitleBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleBalance.Location = new System.Drawing.Point(21, 0);
            this.lblTitleBalance.Name = "lblTitleBalance";
            this.lblTitleBalance.Size = new System.Drawing.Size(111, 25);
            this.lblTitleBalance.TabIndex = 0;
            this.lblTitleBalance.Text = "Tổng số dư";
            // 
            // panel_income
            // 
            this.panel_income.BackColor = System.Drawing.Color.Lime;
            this.panel_income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_income.Controls.Add(this.lblTotalIncome);
            this.panel_income.Controls.Add(this.lblTitleIncome);
            this.panel_income.Location = new System.Drawing.Point(417, 55);
            this.panel_income.Name = "panel_income";
            this.panel_income.Size = new System.Drawing.Size(329, 64);
            this.panel_income.TabIndex = 10;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalIncome.Location = new System.Drawing.Point(20, 30);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(124, 30);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "000 VNĐ";
            // 
            // lblTitleIncome
            // 
            this.lblTitleIncome.AutoSize = true;
            this.lblTitleIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleIncome.Location = new System.Drawing.Point(21, 0);
            this.lblTitleIncome.Name = "lblTitleIncome";
            this.lblTitleIncome.Size = new System.Drawing.Size(144, 25);
            this.lblTitleIncome.TabIndex = 0;
            this.lblTitleIncome.Text = "Tổng thu tháng";
            // 
            // panel_Expense
            // 
            this.panel_Expense.BackColor = System.Drawing.Color.Tomato;
            this.panel_Expense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Expense.Controls.Add(this.lblTotalExpense);
            this.panel_Expense.Controls.Add(this.lblTitleExpense);
            this.panel_Expense.Location = new System.Drawing.Point(781, 55);
            this.panel_Expense.Name = "panel_Expense";
            this.panel_Expense.Size = new System.Drawing.Size(350, 64);
            this.panel_Expense.TabIndex = 10;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpense.Location = new System.Drawing.Point(29, 30);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(124, 30);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "000 VNĐ";
            // 
            // lblTitleExpense
            // 
            this.lblTitleExpense.AutoSize = true;
            this.lblTitleExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleExpense.Location = new System.Drawing.Point(30, 0);
            this.lblTitleExpense.Name = "lblTitleExpense";
            this.lblTitleExpense.Size = new System.Drawing.Size(142, 25);
            this.lblTitleExpense.TabIndex = 0;
            this.lblTitleExpense.Text = "Tổng chi tháng";
            // 
            // chartChiTieu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartChiTieu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartChiTieu.Legends.Add(legend2);
            this.chartChiTieu.Location = new System.Drawing.Point(735, 174);
            this.chartChiTieu.Name = "chartChiTieu";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartChiTieu.Series.Add(series2);
            this.chartChiTieu.Size = new System.Drawing.Size(396, 339);
            this.chartChiTieu.TabIndex = 11;
            this.chartChiTieu.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartChiTieu);
            this.Controls.Add(this.panel_Expense);
            this.Controls.Add(this.panel_income);
            this.Controls.Add(this.panel_Balance);
            this.Controls.Add(this.status_user);
            this.Controls.Add(this.dgv_Accounts);
            this.Controls.Add(this.menu_feature);
            this.MainMenuStrip = this.menu_feature;
            this.Name = "Form_Menu";
            this.Text = "Menu quản lý tài chính cá nhân";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.menu_feature.ResumeLayout(false);
            this.menu_feature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.status_user.ResumeLayout(false);
            this.status_user.PerformLayout();
            this.panel_Balance.ResumeLayout(false);
            this.panel_Balance.PerformLayout();
            this.panel_income.ResumeLayout(false);
            this.panel_income.PerformLayout();
            this.panel_Expense.ResumeLayout(false);
            this.panel_Expense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiTieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_feature;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoảnNợKhoànVayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngânSáchToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.StatusStrip status_user;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer time_clock;
        private System.Windows.Forms.Panel panel_Balance;
        private System.Windows.Forms.Panel panel_income;
        private System.Windows.Forms.Panel panel_Expense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChiTieu;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label lblTitleBalance;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTitleIncome;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblTitleExpense;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

