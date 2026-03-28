using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_FinancePersonalManagement
{
    public partial class frm_nganSach : Form
    {
        private string currentUserId;
        private string currentBudgetID = ""; // Dùng biến ẩn để quản lý Sửa/Xóa

        public frm_nganSach(string UserID)
        {
            InitializeComponent();
            currentUserId = UserID;
        }

        private void frm_nganSach_Load(object sender, EventArgs e)
        {
            // Mặc định gán tháng/năm hiện tại cho nhanh
            txt_thang.Text = DateTime.Now.Month.ToString();
            txt_nam.Text = DateTime.Now.Year.ToString();

            LoadComboBoxDanhMuc(); // Phải load ComboBox trước
            LoadData();
            LoadChart();
        }

        // LOAD COMBOBOX DANH MỤC
        void LoadComboBoxDanhMuc()
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                var danhMucList = db.Categories.Where(c => c.UserID == currentUserId).ToList();

                cbo_DanhMuc.DataSource = danhMucList;
                cbo_DanhMuc.DisplayMember = "CategoryName";
                cbo_DanhMuc.ValueMember = "CategoryID";     
            }
        }

        //LOAD DỮ LIỆU LÊN BẢNG 
        void LoadData()
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    var data = (from b in db.Budgets
                                join c in db.Categories on b.CategoryID equals c.CategoryID
                                where b.UserID == currentUserId
                                orderby b.Year descending, b.Month descending 
                                select new
                                {
                                    BudgetID = b.BudgetID,
                                    CategoryID = b.CategoryID, 
                                    CategoryName = c.CategoryName, 
                                    Amount = b.Amount,
                                    Month = b.Month,
                                    Year = b.Year
                                }).ToList();

                    dgv_nganSach.DataSource = data;

                    if (dgv_nganSach.Columns.Count > 0)
                    {
                        dgv_nganSach.Columns["BudgetID"].Visible = false; 
                        dgv_nganSach.Columns["CategoryID"].Visible = false; 

                        dgv_nganSach.Columns["CategoryName"].HeaderText = "Danh mục";

                        dgv_nganSach.Columns["Amount"].HeaderText = "Số tiền (Ngân sách)";
                        dgv_nganSach.Columns["Amount"].DefaultCellStyle.Format = "N0";

                        dgv_nganSach.Columns["Month"].HeaderText = "Tháng";
                        dgv_nganSach.Columns["Year"].HeaderText = "Năm";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void LoadChart()
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    var data = from b in db.Budgets
                               join c in db.Categories on b.CategoryID equals c.CategoryID
                               where b.UserID == currentUserId
                               group b by new { c.CategoryID, c.CategoryName } into g
                               select new
                               {
                                   CategoryName = g.Key.CategoryName,
                                   TotalAmount = g.Sum(x => x.Amount)
                               };

                    budgetChart.Series.Clear();

                    Series series = new Series("Ngân sách");
                    series.ChartType = SeriesChartType.Column;
                    series.IsValueShownAsLabel = true; 
                    series.LabelFormat = "N0";

                    foreach (var item in data)
                    {
                        series.Points.AddXY(item.CategoryName, item.TotalAmount);
                    }

                    budgetChart.Series.Add(series);
                    budgetChart.ChartAreas[0].AxisX.Title = "Danh mục";
                    budgetChart.ChartAreas[0].AxisY.Title = "Số tiền";
                }
                catch (Exception ex) { }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (cbo_DanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Danh mục!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txt_soTien.Text.Trim(), out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_thang.Text.Trim(), out int thang) || thang < 1 || thang > 12)
            {
                MessageBox.Show("Tháng phải từ 1 đến 12!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_nam.Text.Trim(), out int nam) || nam < 2000)
            {
                MessageBox.Show("Năm không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDM = cbo_DanhMuc.SelectedValue.ToString();

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                // Chặn việc tạo 2 ngân sách Ăn uống trong cùng 1 tháng/năm
                bool isExist = db.Budgets.Any(b => b.UserID == currentUserId && b.CategoryID == maDM && b.Month == thang && b.Year == nam);
                if (isExist)
                {
                    MessageBox.Show("Danh mục này đã có ngân sách trong tháng/năm này rồi!\nVui lòng chọn Sửa thay vì Thêm mới.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sinh ID (B001)
                string newBudgetID = "B001";
                var listIDs = db.Budgets.Where(b => b.BudgetID.StartsWith("B")).Select(b => b.BudgetID).ToList();
                if (listIDs.Count > 0)
                {
                    int maxNum = listIDs.Max(id => int.TryParse(id.Substring(3), out int num) ? num : 0);
                    newBudgetID = "B" + (maxNum + 1).ToString("D3");
                }

                Budget bd = new Budget
                {
                    BudgetID = newBudgetID,
                    UserID = currentUserId,
                    CategoryID = maDM,
                    Amount = soTien,
                    Month = thang,
                    Year = nam
                };

                db.Budgets.InsertOnSubmit(bd);
                db.SubmitChanges();

                MessageBox.Show("Thêm ngân sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_reset_Click(null, null);
                LoadData();
                LoadChart();
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentBudgetID)) return;

            if (!decimal.TryParse(txt_soTien.Text.Trim(), out decimal soTien) || soTien <= 0) return;
            if (!int.TryParse(txt_thang.Text.Trim(), out int thang) || thang < 1 || thang > 12) return;
            if (!int.TryParse(txt_nam.Text.Trim(), out int nam) || nam < 2000) return;

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                var bd = db.Budgets.SingleOrDefault(x => x.BudgetID == currentBudgetID);
                if (bd != null)
                {
                    bd.CategoryID = cbo_DanhMuc.SelectedValue.ToString();
                    bd.Amount = soTien;
                    bd.Month = thang;
                    bd.Year = nam;

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    LoadChart();
                    currentBudgetID = "";
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentBudgetID)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa ngân sách này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DB_SystemDataContext db = new DB_SystemDataContext())
                {
                    var bd = db.Budgets.SingleOrDefault(x => x.BudgetID == currentBudgetID);
                    if (bd != null)
                    {
                        db.Budgets.DeleteOnSubmit(bd);
                        db.SubmitChanges();

                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_reset_Click(null, null);
                        LoadData();
                        LoadChart();
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            currentBudgetID = "";
            txt_soTien.Clear();
            txt_thang.Text = DateTime.Now.Month.ToString();
            txt_nam.Text = DateTime.Now.Year.ToString();
            if (cbo_DanhMuc.Items.Count > 0) cbo_DanhMuc.SelectedIndex = 0;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Form_Menu frmMenu = Application.OpenForms.OfType<Form_Menu>().FirstOrDefault();
            if (frmMenu != null)
            {
                frmMenu.RefreshMenu();
            }

            form_TaiKhoan frmTaiKhoan = Application.OpenForms.OfType<form_TaiKhoan>().FirstOrDefault();
            if (frmTaiKhoan != null)
            {
                frmTaiKhoan.RefreshTaiKhoan();
            }

            form_ThongKe frmThongKe = Application.OpenForms.OfType<form_ThongKe>().FirstOrDefault();
            if (frmThongKe != null)
            {
                frmThongKe.RefreshThongKe();
            }
            form_GiaoDich frmGiaoDich = Application.OpenForms.OfType<form_GiaoDich>().FirstOrDefault();
            if (frmGiaoDich != null)
            {
                frmGiaoDich.RefreshGiaoDich();
            }
            this.Close();
        }

        private void dgv_nganSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_nganSach.Rows[e.RowIndex];

                currentBudgetID = row.Cells["BudgetID"].Value?.ToString();

                // Gán đúng ID vào ComboBox
                if (row.Cells["CategoryID"].Value != null)
                {
                    cbo_DanhMuc.SelectedValue = row.Cells["CategoryID"].Value.ToString();
                }

                txt_thang.Text = row.Cells["Month"].Value?.ToString();
                txt_nam.Text = row.Cells["Year"].Value?.ToString();

                // Ép kiểu bỏ dấu phẩy để nạp lên TextBox
                decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);
                txt_soTien.Text = amount.ToString("G0");
            }
        }
    }
}