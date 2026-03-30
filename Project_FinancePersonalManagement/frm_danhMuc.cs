using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FinancePersonalManagement
{
    public partial class frm_danhMuc : Form
    {
        private string currentUserId;
        private string currentCategoryID = "";

        public frm_danhMuc(string UserID)
        {
            InitializeComponent();
            currentUserId = UserID;
        }


        private void frm_danhMuc_Load(object sender, EventArgs e)
        {
            rAll.Checked = true;
            LoadData();
        }

        // HÀM LOAD DỮ LIỆU & LỌC
        void LoadData()
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    var query = db.Categories.Where(c => c.UserID == currentUserId);

                    // Lọc theo RadioButton
                    if (rThuNhap.Checked) query = query.Where(c => c.CategoryType == "Income");
                    else if (rChiTieu.Checked) query = query.Where(c => c.CategoryType == "Expense");

                    var data = query.OrderByDescending(c => c.CategoryID)
                                    .Select(c => new
                                    {
                                        CategoryID = c.CategoryID,
                                        CategoryName = c.CategoryName,
                                        CategoryType = c.CategoryType == "Income" ? "Thu nhập" : "Chi tiêu",
                                        Note = c.Note
                                    }).ToList();

                    dgv_danhMuc.DataSource = data;

                    if (cbo_LoaiDM.Items.Count == 0)
                    {
                        cbo_LoaiDM.Items.Add("Expense");
                        cbo_LoaiDM.Items.Add("Income");
                        cbo_LoaiDM.SelectedIndex = 0;
                    }

                    // Trang trí bảng
                    if (dgv_danhMuc.Columns.Count > 0)
                    {
                        dgv_danhMuc.Columns["CategoryID"].HeaderText = "Mã danh mục";
                        dgv_danhMuc.Columns["CategoryName"].HeaderText = "Tên danh mục";
                        dgv_danhMuc.Columns["CategoryType"].HeaderText = "Loại danh mục";
                        dgv_danhMuc.Columns["Note"].HeaderText = "Ghi chú";

                        dgv_danhMuc.Columns["CategoryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tenDM = txt_tenDanhMuc.Text.Trim();
            string loaiDM = cbo_LoaiDM.SelectedItem.ToString();

            if (string.IsNullOrEmpty(tenDM) || string.IsNullOrEmpty(loaiDM))
            {
                MessageBox.Show("Vui lòng nhập đủ Tên và Loại danh mục!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    // Chặn trùng Tên danh mục (để tránh tạo 2 danh mục "Ăn uống")
                    bool isDuplicate = db.Categories.Any(c => c.UserID == currentUserId
                                                           && c.CategoryName.ToLower() == tenDM.ToLower()
                                                           && c.CategoryType == loaiDM);
                    if (isDuplicate)
                    {
                        MessageBox.Show("Danh mục này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Thuật toán Tự động sinh ID (C001, C002...)
                    string newCatID = "C001";
                    var listIDs = db.Categories.Where(c => c.CategoryID.StartsWith("C")).Select(c => c.CategoryID).ToList();
                    if (listIDs.Count > 0)
                    {
                        int maxNum = listIDs.Max(id => int.TryParse(id.Substring(3), out int num) ? num : 0);
                        newCatID = "C" + (maxNum + 1).ToString("D3");
                    }

                    Category newCategory = new Category()
                    {
                        CategoryID = newCatID,
                        UserID = currentUserId,
                        CategoryName = tenDM,
                        CategoryType = loaiDM,
                        Note = txt_ghiChu.Text.Trim()
                    };

                    db.Categories.InsertOnSubmit(newCategory);
                    db.SubmitChanges();

                    MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_reset_Click(null, null); // Xóa trắng các ô
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // SỬA DANH MỤC
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string id = currentCategoryID;
            if (string.IsNullOrEmpty(id)) return;

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                var c = db.Categories.SingleOrDefault(v => v.CategoryID == id);
                if (c != null)
                {
                    c.CategoryName = txt_tenDanhMuc.Text.Trim();
                    c.CategoryType = cbo_LoaiDM.SelectedItem.ToString();
                    c.Note = txt_ghiChu.Text.Trim();

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    currentCategoryID = "";
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string categoryID = currentCategoryID;
            if (string.IsNullOrEmpty(categoryID)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (DB_SystemDataContext db = new DB_SystemDataContext())
                {
                    try
                    {
                        var category = db.Categories.SingleOrDefault(c => c.CategoryID == categoryID);
                        if (category != null)
                        {
                            db.Categories.DeleteOnSubmit(category);
                            db.SubmitChanges();

                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_reset_Click(null, null);
                            LoadData();
                            currentCategoryID = "";
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        // Bắt lỗi nếu danh mục này đang có Giao dịch liên quan
                        MessageBox.Show("Không thể xóa danh mục này vì đang có Giao dịch (Thu/Chi) sử dụng nó!\nVui lòng xóa các giao dịch liên quan trước.",
                                        "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tenDanhMuc.Clear();
            cbo_LoaiDM.SelectedIndex = 0;
            txt_ghiChu.Clear();
            txt_tenDanhMuc.Focus();
            currentCategoryID = "";
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

        private void dgv_danhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_danhMuc.Rows[e.RowIndex];

                txt_tenDanhMuc.Text = row.Cells["CategoryName"].Value?.ToString();
                txt_ghiChu.Text = row.Cells["Note"].Value?.ToString();
                cbo_LoaiDM.SelectedItem = row.Cells["CategoryType"].Value?.ToString() == "Thu nhập" ? "Income" : "Expense";
                currentCategoryID = row.Cells["CategoryID"].Value?.ToString();

            }
        }

        private void rAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rAll.Checked) LoadData();
        }

        private void rThuNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rThuNhap.Checked) LoadData();
        }

        private void rChiTieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rChiTieu.Checked) LoadData();
        }
    }
}