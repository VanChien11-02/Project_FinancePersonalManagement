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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.menu_feature.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu_feature.Size = new System.Drawing.Size(1016, 28);
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
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngKíToolStripMenuItem
            // 
            this.đăngKíToolStripMenuItem.Name = "đăngKíToolStripMenuItem";
            this.đăngKíToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đăngKíToolStripMenuItem.Text = "Đăng kí";
            this.đăngKíToolStripMenuItem.Click += new System.EventHandler(this.đăngKíToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // tàiKhoànToolStripMenuItem
            // 
            this.tàiKhoànToolStripMenuItem.Name = "tàiKhoànToolStripMenuItem";
            this.tàiKhoànToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoànToolStripMenuItem.Text = "Tài khoàn";
            this.tàiKhoànToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoànToolStripMenuItem_Click);
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.giaoDịchToolStripMenuItem.Text = "Giao dịch";
            this.giaoDịchToolStripMenuItem.Click += new System.EventHandler(this.giaoDịchToolStripMenuItem_Click);
            // 
            // khoảnNợKhoànVayToolStripMenuItem
            // 
            this.khoảnNợKhoànVayToolStripMenuItem.Name = "khoảnNợKhoànVayToolStripMenuItem";
            this.khoảnNợKhoànVayToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.khoảnNợKhoànVayToolStripMenuItem.Text = "Khoản vay, khoản cho vay";
            this.khoảnNợKhoànVayToolStripMenuItem.Click += new System.EventHandler(this.khoảnNợKhoànVayToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // ngânSáchToolStripMenuItem
            // 
            this.ngânSáchToolStripMenuItem.Name = "ngânSáchToolStripMenuItem";
            this.ngânSáchToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.ngânSáchToolStripMenuItem.Text = "Ngân sách";
            this.ngânSáchToolStripMenuItem.Click += new System.EventHandler(this.ngânSáchToolStripMenuItem_Click);
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.Location = new System.Drawing.Point(22, 139);
            this.dgv_Accounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.ReadOnly = true;
            this.dgv_Accounts.RowHeadersWidth = 62;
            this.dgv_Accounts.RowTemplate.Height = 28;
            this.dgv_Accounts.Size = new System.Drawing.Size(596, 271);
            this.dgv_Accounts.TabIndex = 4;
            // 
            // status_user
            // 
            this.status_user.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.status_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblUser,
            this.lblTime});
            this.status_user.Location = new System.Drawing.Point(0, 440);
            this.status_user.Name = "status_user";
            this.status_user.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.status_user.Size = new System.Drawing.Size(1016, 26);
            this.status_user.TabIndex = 8;
            this.status_user.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 20);
            this.lblStatus.Text = "Sẵn sàng";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(118, 20);
            this.lblUser.Text = "Chưa đăng nhập";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(163, 20);
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
            this.panel_Balance.Location = new System.Drawing.Point(22, 44);
            this.panel_Balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Balance.Name = "panel_Balance";
            this.panel_Balance.Size = new System.Drawing.Size(312, 52);
            this.panel_Balance.TabIndex = 9;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalBalance.Location = new System.Drawing.Point(18, 24);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(108, 26);
            this.lblTotalBalance.TabIndex = 1;
            this.lblTotalBalance.Text = "000 VNĐ";
            // 
            // lblTitleBalance
            // 
            this.lblTitleBalance.AutoSize = true;
            this.lblTitleBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleBalance.Location = new System.Drawing.Point(19, 0);
            this.lblTitleBalance.Name = "lblTitleBalance";
            this.lblTitleBalance.Size = new System.Drawing.Size(92, 20);
            this.lblTitleBalance.TabIndex = 0;
            this.lblTitleBalance.Text = "Tổng số dư";
            // 
            // panel_income
            // 
            this.panel_income.BackColor = System.Drawing.Color.Lime;
            this.panel_income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_income.Controls.Add(this.lblTotalIncome);
            this.panel_income.Controls.Add(this.lblTitleIncome);
            this.panel_income.Location = new System.Drawing.Point(371, 44);
            this.panel_income.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_income.Name = "panel_income";
            this.panel_income.Size = new System.Drawing.Size(293, 52);
            this.panel_income.TabIndex = 10;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalIncome.Location = new System.Drawing.Point(18, 24);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(108, 26);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "000 VNĐ";
            // 
            // lblTitleIncome
            // 
            this.lblTitleIncome.AutoSize = true;
            this.lblTitleIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleIncome.Location = new System.Drawing.Point(19, 0);
            this.lblTitleIncome.Name = "lblTitleIncome";
            this.lblTitleIncome.Size = new System.Drawing.Size(120, 20);
            this.lblTitleIncome.TabIndex = 0;
            this.lblTitleIncome.Text = "Tổng thu tháng";
            // 
            // panel_Expense
            // 
            this.panel_Expense.BackColor = System.Drawing.Color.Tomato;
            this.panel_Expense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Expense.Controls.Add(this.lblTotalExpense);
            this.panel_Expense.Controls.Add(this.lblTitleExpense);
            this.panel_Expense.Location = new System.Drawing.Point(694, 44);
            this.panel_Expense.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Expense.Name = "panel_Expense";
            this.panel_Expense.Size = new System.Drawing.Size(311, 52);
            this.panel_Expense.TabIndex = 10;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpense.Location = new System.Drawing.Point(26, 24);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(108, 26);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "000 VNĐ";
            // 
            // lblTitleExpense
            // 
            this.lblTitleExpense.AutoSize = true;
            this.lblTitleExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitleExpense.Location = new System.Drawing.Point(27, 0);
            this.lblTitleExpense.Name = "lblTitleExpense";
            this.lblTitleExpense.Size = new System.Drawing.Size(119, 20);
            this.lblTitleExpense.TabIndex = 0;
            this.lblTitleExpense.Text = "Tổng chi tháng";
            // 
            // chartChiTieu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartChiTieu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChiTieu.Legends.Add(legend1);
            this.chartChiTieu.Location = new System.Drawing.Point(653, 139);
            this.chartChiTieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartChiTieu.Name = "chartChiTieu";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartChiTieu.Series.Add(series1);
            this.chartChiTieu.Size = new System.Drawing.Size(352, 271);
            this.chartChiTieu.TabIndex = 11;
            this.chartChiTieu.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartChiTieu);
            this.Controls.Add(this.panel_Expense);
            this.Controls.Add(this.panel_income);
            this.Controls.Add(this.panel_Balance);
            this.Controls.Add(this.status_user);
            this.Controls.Add(this.dgv_Accounts);
            this.Controls.Add(this.menu_feature);
            this.MainMenuStrip = this.menu_feature;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

