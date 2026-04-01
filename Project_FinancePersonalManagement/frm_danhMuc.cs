using System;
using System.Drawing;
using System.Linq;
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

        // LOAD & LỌC DỮ LIỆU
        void LoadData()
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    var query = db.Categories.Where(c => c.UserID == currentUserId);

                    if (rThuNhap.Checked) query = query.Where(c => c.CategoryType == "Income");
                    else if (rChiTieu.Checked) query = query.Where(c => c.CategoryType == "Expense");

                    var data = query.OrderByDescending(c => c.CategoryID)
                                    .Select(c => new
                                    {
                                        c.CategoryID,
                                        c.CategoryName,
                                        CategoryType = c.CategoryType == "Income" ? "Thu nhập" : "Chi tiêu",
                                        c.Note
                                    }).ToList();

                    dgv_danhMuc.DataSource = data;

                    // Khởi tạo ComboBox một lần
                    if (cbo_LoaiDM.Items.Count == 0)
                    {
                        cbo_LoaiDM.Items.Add("Chi tiêu");
                        cbo_LoaiDM.Items.Add("Thu nhập");
                        cbo_LoaiDM.SelectedIndex = 0;
                    }

                    // Header & cột
                    if (dgv_danhMuc.Columns.Count > 0)
                    {
                        dgv_danhMuc.Columns["CategoryID"].HeaderText = "Mã danh mục";
                        dgv_danhMuc.Columns["CategoryID"].Width = 80;
                        dgv_danhMuc.Columns["CategoryID"].DefaultCellStyle.ForeColor = Color.FromArgb(107, 114, 128);
                        dgv_danhMuc.Columns["CategoryID"].DefaultCellStyle.Font = new Font("Segoe UI", 9F);

                        dgv_danhMuc.Columns["CategoryName"].HeaderText = "Tên danh mục";
                        dgv_danhMuc.Columns["CategoryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgv_danhMuc.Columns["CategoryName"].DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                        dgv_danhMuc.Columns["CategoryType"].HeaderText = "Loại danh mục";
                        dgv_danhMuc.Columns["CategoryType"].Width = 110;

                        dgv_danhMuc.Columns["Note"].HeaderText = "Ghi chú";
                        dgv_danhMuc.Columns["Note"].Width = 160;
                        dgv_danhMuc.Columns["Note"].DefaultCellStyle.ForeColor = Color.FromArgb(107, 114, 128);
                    }

                    lbl_RowCount.Text = $"Đang hiển thị {data.Count} danh mục";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // THÊM
        private void btn_them_Click(object sender, EventArgs e)
        {
            string tenDM = txt_tenDanhMuc.Text.Trim();
            string loaiDM = cbo_LoaiDM.SelectedItem?.ToString() == "Thu nhập" ? "Income" : "Expense";

            if (string.IsNullOrEmpty(tenDM) || string.IsNullOrEmpty(loaiDM))
            {
                MessageBox.Show("Vui lòng nhập đủ Tên và Loại danh mục!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    bool isDuplicate = db.Categories.Any(c => c.UserID == currentUserId
                                                           && c.CategoryName.ToLower() == tenDM.ToLower()
                                                           && c.CategoryType == loaiDM);
                    if (isDuplicate)
                    {
                        MessageBox.Show("Danh mục này đã tồn tại!", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Sinh ID an toàn theo số
                    var listIDs = db.Categories
                        .Where(c => c.CategoryID.StartsWith("C"))
                        .Select(c => c.CategoryID).ToList();

                    int maxNum = 0;
                    if (listIDs.Count > 0)
                        maxNum = listIDs.Max(id => int.TryParse(id.Substring(1), out int n) ? n : 0);

                    string newCatID = "C" + (maxNum + 1).ToString("D3");

                    db.Categories.InsertOnSubmit(new Category
                    {
                        CategoryID = newCatID,
                        UserID = currentUserId,
                        CategoryName = tenDM,
                        CategoryType = loaiDM,
                        Note = txt_ghiChu.Text.Trim()
                    });
                    db.SubmitChanges();

                    MessageBox.Show($"Thêm danh mục thành công! Mã: {newCatID}", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_reset_Click(null, null);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // SỬA
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentCategoryID)) return;

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                var c = db.Categories.SingleOrDefault(v => v.CategoryID == currentCategoryID);
                if (c != null)
                {
                    c.CategoryName = txt_tenDanhMuc.Text.Trim();
                    string loaiDM = cbo_LoaiDM.SelectedItem?.ToString() == "Thu nhập" ? "Income" : "Expense";
                    c.Note = txt_ghiChu.Text.Trim();
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    currentCategoryID = "";
                }
            }
        }

        // XOÁ
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentCategoryID)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    var category = db.Categories.SingleOrDefault(c => c.CategoryID == currentCategoryID);
                    if (category != null)
                    {
                        db.Categories.DeleteOnSubmit(category);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_reset_Click(null, null);
                        LoadData();
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show(
                        "Không thể xóa vì danh mục này đang có giao dịch liên quan!\nVui lòng xóa các giao dịch trước.",
                        "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        // RESET 
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_tenDanhMuc.Clear();
            txt_ghiChu.Clear();
            cbo_LoaiDM.SelectedIndex = 0;
            txt_tenDanhMuc.Focus();
            currentCategoryID = "";
            dgv_danhMuc.ClearSelection();
        }

        // THOÁT 
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            var frmMenu = Application.OpenForms.OfType<Form_Menu>().FirstOrDefault();
            frmMenu?.RefreshMenu();

            var frmTK = Application.OpenForms.OfType<form_TaiKhoan>().FirstOrDefault();
            frmTK?.RefreshTaiKhoan();

            var frmThongKe = Application.OpenForms.OfType<form_ThongKe>().FirstOrDefault();
            frmThongKe?.RefreshThongKe();

            var frmGD = Application.OpenForms.OfType<form_GiaoDich>().FirstOrDefault();
            frmGD?.RefreshGiaoDich();

            this.Close();
        }

        //CLICK HÀNG
        private void dgv_danhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgv_danhMuc.Rows[e.RowIndex];
            txt_tenDanhMuc.Text = row.Cells["CategoryName"].Value?.ToString();
            txt_ghiChu.Text = row.Cells["Note"].Value?.ToString();
            cbo_LoaiDM.SelectedItem = row.Cells["CategoryType"].Value?.ToString();
            currentCategoryID = row.Cells["CategoryID"].Value?.ToString();
        }

        // ── RADIO BUTTONS ────────────────────────────────────────────────
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

        // tô màu cell
        private void dgv_danhMuc_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgv_danhMuc.Columns[e.ColumnIndex].Name != "CategoryType") return;
            if (e.Value == null) return;

            string val = e.Value.ToString();
            if (val == "Thu nhập")
            {
                e.CellStyle.ForeColor = Color.FromArgb(6, 95, 70);
                e.CellStyle.BackColor = Color.FromArgb(209, 250, 229);
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                e.CellStyle.ForeColor = Color.FromArgb(153, 27, 27);
                e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                e.CellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}