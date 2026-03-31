using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmGiaoDich : Form
    {
        private string currentUserID;
        private string currentTransID = "";
        public FrmGiaoDich(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
        }

        private void cbo_LoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiGD.SelectedItem == null) return;

            string loaiGD = cbo_LoaiGD.SelectedItem.ToString(); // Thu, Chi, hoặc Chuyển tiền

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                if (loaiGD == "Chuyển tiền")
                {
                    // Mở ô Chuyển đến
                    cbo_ChuyenDenTK.Visible = true;
                    lbl_ChuyenDenTK.Visible = true;

                    // Khóa và xóa rỗng ô Danh mục (vì chuyển tiền không cần danh mục)
                    cbo_DanhMuc.DataSource = null;
                    cbo_DanhMuc.Enabled = false;
                }
                else
                {
                    // Khóa ô Chuyển đến (vì chỉ nhập thu/chi bình thường)
                    cbo_ChuyenDenTK.Visible = false;
                    lbl_ChuyenDenTK.Visible = false;

                    // Mở lại ô Danh mục và load dữ liệu tương ứng (Income/Expense)
                    cbo_DanhMuc.Enabled = true;

                    string dbType = (loaiGD == "Thu nhập") ? "Income" : "Expense";

                    var danhMucList = db.Categories.Where(c => c.CategoryType == dbType).ToList();
                    cbo_DanhMuc.DataSource = danhMucList;
                    cbo_DanhMuc.DisplayMember = "CategoryName";
                    cbo_DanhMuc.ValueMember = "CategoryID";
                }
            }
        }

        private void LoadData()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Nạp danh sách Tài khoản
                    if (cbo_TaiKhoan.DataSource == null)
                    {
                        var tkList = db.Accounts.Where(a => a.UserID == currentUserID).ToList();

                        // Nạp cho ô "Tài khoản" (nguồn)
                        cbo_TaiKhoan.DataSource = tkList;
                        cbo_TaiKhoan.DisplayMember = "AccountName";
                        cbo_TaiKhoan.ValueMember = "AccountID";

                        // Nạp cho ô "Chuyển đến tài khoản" (đích) - Phải tạo một List copy (ToList) để không bị đụng chạm với list trên
                        var tkListDest = db.Accounts.Where(a => a.UserID == currentUserID).ToList();
                        cbo_ChuyenDenTK.DataSource = tkListDest;
                        cbo_ChuyenDenTK.DisplayMember = "AccountName";
                        cbo_ChuyenDenTK.ValueMember = "AccountID";
                    }

                    // Nạp cứng 2 loại giao dịch
                    if (cbo_LoaiGD.Items.Count == 0)
                    {
                        cbo_LoaiGD.Items.Add("Chi tiêu");
                        cbo_LoaiGD.Items.Add("Thu nhập");
                        cbo_LoaiGD.Items.Add("Chuyển tiền");
                        cbo_LoaiGD.SelectedIndex = 0;
                    }

                    // Đổ dữ liệu Giao dịch lên DataGridView
                    var dsGiaoDich = (from t in db.Transactions
                                      join a in db.Accounts on t.AccountID equals a.AccountID
                                      // Dùng LEFT JOIN cho Category để không bị mất các giao dịch Chuyển tiền (vì nó NULL danh mục)
                                      join c in db.Categories on t.CategoryID equals c.CategoryID into cGroup
                                      from c in cGroup.DefaultIfEmpty()
                                      where t.UserID == currentUserID
                                      // ĐỔI SẮP XẾP: Xếp theo Mã giao dịch (TNX) giảm dần để cái mới nhất lên đầu
                                      orderby t.TransID descending
                                      select new
                                      {
                                          MaGD = t.TransID,
                                          TenTK = a.AccountName,
                                          TenDM = c != null ? c.CategoryName : "Chuyển tiền nội bộ", // Xử lý nếu danh mục bị NULL
                                          Loai = t.TransType,
                                          SoTien = t.Amount,
                                          Ngay = t.TransDate,
                                          GhiChu = t.Note,
                                      }).ToList();

                    dgvGiaoDich.DataSource = null;
                    dgvGiaoDich.Columns.Clear();
                    dgvGiaoDich.DataSource = dsGiaoDich;

                    if (dgvGiaoDich.Columns.Count > 0)
                    {
                        // dgvGiaoDich.Columns["MaGD"].Visible = false;
                        dgvGiaoDich.Columns["MaGD"].HeaderText = "Mã GD";
                        dgvGiaoDich.Columns["TenTK"].HeaderText = "Tài khoản";
                        dgvGiaoDich.Columns["TenDM"].HeaderText = "Danh mục";
                        dgvGiaoDich.Columns["Loai"].HeaderText = "Loại GD";
                        dgvGiaoDich.Columns["SoTien"].HeaderText = "Số tiền";
                        dgvGiaoDich.Columns["SoTien"].DefaultCellStyle.Format = "N0";
                        dgvGiaoDich.Columns["Ngay"].HeaderText = "Ngày GD";
                        dgvGiaoDich.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvGiaoDich.Columns["GhiChu"].HeaderText = "Ghi chú";
                    }

                    decimal tongThu = dsGiaoDich.Where(x => x.Loai == "Income").Sum(x => (decimal?)x.SoTien) ?? 0;
                    decimal tongChi = dsGiaoDich.Where(x => x.Loai == "Expense").Sum(x => (decimal?)x.SoTien) ?? 0;

                    lblTotalIncome.Text = tongThu.ToString("N0") + " VNĐ";
                    lblTotalExpense.Text = tongChi.ToString("N0") + " VNĐ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void form_GiaoDich_Load(object sender, EventArgs e)
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                bool hasAccounts = db.Accounts.Any(a => a.UserID == currentUserID);
                if (!hasAccounts)
                {
                    MessageBox.Show("Bạn chưa có tài khoản/ví nào!\nVui lòng vào mục [Tài khoản] để tạo mới trước khi ghi chép giao dịch.",
                             "Cảnh báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
            }
            DateTime today = DateTime.Today;
            dtp_NgayGD.Value = DateTime.Now;
            dtp_DenNgay.Value = DateTime.Now;
            dtp_TuNgay.Value = new DateTime(today.Year, today.Month, 1);
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_Tien.Text.Trim(), out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền phải là một con số lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Tien.Focus();
                return;
            }

            if (cbo_LoaiGD.SelectedItem == null || cbo_TaiKhoan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Tài khoản và Loại giao dịch!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiGD = cbo_LoaiGD.SelectedItem.ToString();
            string maTaiKhoanNguon = cbo_TaiKhoan.SelectedValue.ToString();
            DateTime ngayGD = dtp_NgayGD.Value.Date;
            string ghiChu = txt_Note.Text.Trim();

            // Logic chặn lỗi khi Chuyển tiền
            string maTaiKhoanDich = "";
            if (loaiGD == "Chuyển tiền")
            {
                if (cbo_ChuyenDenTK.SelectedValue == null) return;
                maTaiKhoanDich = cbo_ChuyenDenTK.SelectedValue.ToString();

                if (maTaiKhoanNguon == maTaiKhoanDich)
                {
                    MessageBox.Show("Tài khoản chuyển và Tài khoản nhận không được trùng nhau!", "Lỗi logic", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // XỬ LÝ DATABASE
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // Tự động sinh Mã Giao Dịch (TXN0001, TXN0002...)
                    string newTransID = "TXN0001"; // Mặc định là 4 số 0
                    var lastTrans = db.Transactions.OrderByDescending(t => t.TransID).FirstOrDefault();
                    if (lastTrans != null)
                    {
                        // Cắt 3 chữ cái đầu "TNX", lấy phần số đằng sau cộng lên 1
                        int lastNum = int.Parse(lastTrans.TransID.Substring(3));
                        newTransID = "TXN" + (lastNum + 1).ToString("D4"); // D4 sẽ format thành 4 chữ số (VD: 0002)
                    }

                    // Lấy Ví tiền (Account) ra để chuẩn bị cộng/trừ tiền
                    var viNguon = db.Accounts.SingleOrDefault(a => a.AccountID == maTaiKhoanNguon);
                    if (viNguon == null) return;

                    // Kiểm tra có vượt quá số dư không (CHI & CHUYỂN TIỀN)
                    if ((loaiGD == "Chi tiêu" || loaiGD == "Chuyển tiền") && soTien > viNguon.Balance)
                    {
                        MessageBox.Show($"Tài khoản này chỉ còn {viNguon.Balance.Value:N0} VNĐ.\nBạn không thể giao dịch số tiền lớn hơn số dư hiện có!",
                                        "Thiếu tiền", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_Tien.Focus();
                        return; // Dừng lại ngay, không cho ghi database
                    }

                    // THU HOẶC CHI
                    if (loaiGD == "Thu nhập" || loaiGD == "Chi tiêu")
                    {
                        string dbType = (loaiGD == "Thu nhập") ? "Income" : "Expense";
                        string danhMucID = cbo_DanhMuc.SelectedValue.ToString();

                        // Tạo lịch sử giao dịch
                        Transaction t = new Transaction();
                        t.TransID = newTransID;
                        t.UserID = currentUserID;
                        t.AccountID = maTaiKhoanNguon;
                        t.CategoryID = danhMucID;
                        t.TransType = dbType;
                        t.Amount = soTien;
                        t.TransDate = ngayGD;
                        t.Note = ghiChu;

                        db.Transactions.InsertOnSubmit(t);

                        // Hạch toán: Cộng/Trừ tiền vào Ví
                        if (loaiGD == "Thu nhập")
                            viNguon.Balance += soTien;
                        else
                            viNguon.Balance -= soTien;
                    }
                    // CHUYỂN TIỀN
                    else if (loaiGD == "Chuyển tiền")
                    {
                        var viDich = db.Accounts.SingleOrDefault(a => a.AccountID == maTaiKhoanDich);
                        if (viDich == null) return;

                        // Trừ tiền ví A, Cộng tiền ví B
                        viNguon.Balance -= soTien;
                        viDich.Balance += soTien;

                        // Ghi lại lịch sử
                        Transaction t = new Transaction();
                        t.TransID = newTransID;
                        t.UserID = currentUserID;
                        t.AccountID = maTaiKhoanNguon;
                        t.TransType = "Transfer";
                        t.Amount = soTien;
                        t.TransDate = ngayGD;
                        t.Note = $"Chuyển sang: {viDich.AccountName} - " + ghiChu;

                        db.Transactions.InsertOnSubmit(t);
                    }

                    //LÀM MỚI GIAO DIỆN
                    db.SubmitChanges(); // Đẩy toàn bộ thay đổi xuống SQL

                    MessageBox.Show("Ghi chép giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xóa rỗng các ô nhập liệu
                    txt_Note.Clear();
                    txt_Note.Clear();
                    txt_Tien.Focus();
                    txt_SoDu.Text = viNguon.Balance.Value.ToString("N0") + " VNĐ";

                    // Load lại bảng dữ liệu
                    LoadData();
                    // LoadTongThuChi(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu giao dịch: " + ex.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbo_TaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TaiKhoan.SelectedValue != null && cbo_TaiKhoan.SelectedValue is string maTK)
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var acc = db.Accounts.SingleOrDefault(a => a.AccountID == maTK);
                    if (acc != null)
                    {
                        txt_SoDu.Text = acc.Balance.Value.ToString("N0") + " VNĐ";
                    }
                }
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMenu = Application.OpenForms.OfType<FrmMainMenu>().FirstOrDefault();
            if (frmMenu != null)
            {
                frmMenu.RefreshMenu();
            }

            FrmTaiKhoan frmTaiKhoan = Application.OpenForms.OfType<FrmTaiKhoan>().FirstOrDefault();
            if (frmTaiKhoan != null)
            {
                frmTaiKhoan.RefreshTaiKhoan();
            }

            FrmThongKe frmThongKe = Application.OpenForms.OfType<FrmThongKe>().FirstOrDefault();
            if (frmThongKe != null)
            {
                frmThongKe.RefreshThongKe();
            }
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_SoDu.Clear();
            txt_Note.Clear();
            txt_Tien.Clear();
            txt_Tien.Focus();
            DateTime today = DateTime.Today;
            dtp_NgayGD.Value = DateTime.Now;
            dtp_DenNgay.Value = DateTime.Now;
            dtp_TuNgay.Value = new DateTime(today.Year, today.Month, 1);
            cbo_LoaiGD.SelectedIndex = 0;
            cbo_TaiKhoan.SelectedIndex = 0;
        }

        private void dgvGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiaoDich.Rows[e.RowIndex];
                // Lưu ngầm Mã GD để Sửa/Xóa
                currentTransID = row.Cells["MaGD"].Value.ToString();

                // Đổ dữ liệu lên các ô nhập liệu
                cbo_TaiKhoan.Text = row.Cells["TenTK"].Value.ToString();
                txt_Tien.Text = row.Cells["SoTien"].Value.ToString();
                dtp_NgayGD.Value = Convert.ToDateTime(row.Cells["Ngay"].Value);
                txt_Note.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

                // Chỉnh Loại giao dịch (Income -> Thu, Expense -> Chi)
                string loaiGD = row.Cells["Loai"].Value.ToString();
                if (loaiGD == "Income") cbo_LoaiGD.SelectedItem = "Thu nhập";
                else if (loaiGD == "Expense") cbo_LoaiGD.SelectedItem = "Chi tiêu";
                else cbo_LoaiGD.SelectedItem = "Chuyển tiền";

                // Sau khi loại giao dịch đổi, Danh mục sẽ được mở khóa, ta nạp tiếp tên danh mục
                if (cbo_DanhMuc.Enabled)
                {
                    cbo_DanhMuc.Text = row.Cells["TenDM"].Value.ToString();
                }
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                DateTime tuNgay = dtp_TuNgay.Value.Date;
                DateTime denNgay = dtp_DenNgay.Value.Date;

                // Lọc danh sách theo khoảng thời gian
                var dsLoc = (from t in db.Transactions
                             join a in db.Accounts on t.AccountID equals a.AccountID
                             join c in db.Categories on t.CategoryID equals c.CategoryID into cGroup
                             from c in cGroup.DefaultIfEmpty()
                             where t.UserID == currentUserID
                                   && t.TransDate >= tuNgay
                                   && t.TransDate <= denNgay
                             orderby t.TransDate descending, t.TransID descending
                             select new
                             {
                                 MaGD = t.TransID,
                                 TenTK = a.AccountName,
                                 TenDM = c != null ? c.CategoryName : "Chuyển tiền nội bộ",
                                 Loai = t.TransType,
                                 SoTien = t.Amount,
                                 Ngay = t.TransDate,
                                 GhiChu = t.Note,
                             }).ToList();

                dgvGiaoDich.DataSource = dsLoc; // Cập nhật lại bảng

                // Tính Tổng Thu và Tổng Chi trực tiếp từ danh sách vừa lọc
                decimal tongThu = dsLoc.Where(x => x.Loai == "Income").Sum(x => (decimal?)x.SoTien) ?? 0;
                decimal tongChi = dsLoc.Where(x => x.Loai == "Expense").Sum(x => (decimal?)x.SoTien) ?? 0;

                lblTotalIncome.Text = tongThu.ToString("N0") + " VNĐ";
                lblTotalExpense.Text = tongChi.ToString("N0") + " VNĐ";
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTransID))
            {
                MessageBox.Show("Vui lòng click chọn một giao dịch trong bảng để Xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?\nTiền trong ví sẽ được hoàn lại tự động.",
                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var t = db.Transactions.SingleOrDefault(x => x.TransID == currentTransID);
                    if (t != null)
                    {
                        // Tìm ví tiền tương ứng để HOÀN TIỀN
                        var acc = db.Accounts.SingleOrDefault(a => a.AccountID == t.AccountID);
                        if (acc != null)
                        {
                            if (t.TransType == "Income") acc.Balance -= t.Amount; // Hủy thu -> Trừ tiền
                            else if (t.TransType == "Expense") acc.Balance += t.Amount; // Hủy chi -> Trả lại tiền
                            else if (t.TransType == "Transfer") MessageBox.Show("Không xóa được giao dịch chuyển tiền", "Thông báo", MessageBoxButtons.OK);
                        }

                        // Xóa lịch sử và Lưu lại
                        db.Transactions.DeleteOnSubmit(t);
                        db.SubmitChanges();

                        MessageBox.Show("Đã xóa và hoàn tiền vào ví thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Làm mới giao diện
                        currentTransID = "";
                        // btn_Loc.PerformClick(); // Lọc và tính tổng lại
                        LoadData(); // Cập nhật lại các combobox nếu cần
                        btn_Reset.PerformClick();
                    }
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTransID)) return;

            string loaiGD = cbo_LoaiGD.SelectedItem.ToString();
            if (loaiGD == "Chuyển tiền")
            {
                MessageBox.Show("Với giao dịch Chuyển tiền, vui lòng XÓA đi và THÊM LẠI để đảm bảo chính xác số dư ở cả 2 ví nhé!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(txt_Tien.Text.Trim(), out decimal soTien) || soTien <= 0) return;

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var t = db.Transactions.SingleOrDefault(x => x.TransID == currentTransID);
                if (t != null)
                {
                    // BƯỚC A: Hoàn trả lại tiền của giao dịch CŨ
                    var oldAcc = db.Accounts.SingleOrDefault(a => a.AccountID == t.AccountID);
                    if (oldAcc != null)
                    {
                        if (t.TransType == "Income") oldAcc.Balance -= t.Amount;
                        else if (t.TransType == "Expense") oldAcc.Balance += t.Amount;
                    }

                    // BƯỚC B: Tính toán trừ/cộng cho số tiền MỚI và ví MỚI
                    string newAccID = cbo_TaiKhoan.SelectedValue.ToString();
                    var newAcc = db.Accounts.SingleOrDefault(a => a.AccountID == newAccID);
                    if (newAcc != null)
                    {
                        if (loaiGD == "Thu nhập") newAcc.Balance += soTien;
                        else if (loaiGD == "Chi tiêu")
                        {
                            if (newAcc.Balance < soTien)
                            {
                                MessageBox.Show("Số dư ví không đủ để cập nhật khoản chi này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            newAcc.Balance -= soTien;
                        }
                    }

                    // BƯỚC C: Cập nhật thông tin lưu vào CSDL
                    t.AccountID = newAccID;
                    t.CategoryID = cbo_DanhMuc.SelectedValue.ToString();
                    t.TransType = (loaiGD == "Thu") ? "Income" : "Expense";
                    t.Amount = soTien;
                    t.TransDate = dtp_NgayGD.Value.Date;
                    t.Note = txt_Note.Text.Trim();

                    db.SubmitChanges();
                    MessageBox.Show("Sửa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    currentTransID = "";
                    //btn_Loc.PerformClick();
                    LoadData();
                    btn_Reset.PerformClick();
                }
            }
        }

        public void RefreshGiaoDich()
        {
            LoadData();
        }
    }
}
