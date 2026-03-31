using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Project_FinancePersonalManagement
{
    public partial class form_GiaoDich : Form
    {
        private string currentUserID;
        private string currentTransID = "";

        private static readonly Color C_Green = Color.FromArgb(15, 110, 80);
        private static readonly Color C_Blue = Color.FromArgb(24, 95, 165);
        private static readonly Color C_Red = Color.FromArgb(163, 45, 45);
        private static readonly Color C_Border = Color.FromArgb(220, 220, 220);

        public form_GiaoDich(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
        }

        private void FilterBar_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
            {
                e.Graphics.DrawLine(pen, 0, 0, p.Width, 0);
                e.Graphics.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
            }
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
        }

        private void SummaryBar_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
                e.Graphics.DrawLine(pen, 0, 0, p.Width, 0);
        }

        private void StatCard_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
        }

        //  LOAD / RESIZE
        private void form_GiaoDich_Load(object sender, EventArgs e)
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
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

        //  LOAD DATA
        private void LoadData()
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                try
                {
                    // Accounts
                    if (cbo_TaiKhoan.DataSource == null)
                    {
                        var tkList = db.Accounts.Where(a => a.UserID == currentUserID).ToList();
                        cbo_TaiKhoan.DataSource = tkList;
                        cbo_TaiKhoan.DisplayMember = "AccountName";
                        cbo_TaiKhoan.ValueMember = "AccountID";

                        // Nạp cho ô "Chuyển đến tài khoản" (đích) - Phải tạo một List copy (ToList) để không bị đụng chạm với list trên
                        var tkListDest = db.Accounts.Where(a => a.UserID == currentUserID).ToList();
                        cbo_ChuyenDenTK.DataSource = tkListDest;
                        cbo_ChuyenDenTK.DisplayMember = "AccountName";
                        cbo_ChuyenDenTK.ValueMember = "AccountID";
                    }

                    // Transaction types
                    if (cbo_LoaiGD.Items.Count == 0)
                    {
                        cbo_LoaiGD.Items.Add("Chi tiêu");
                        cbo_LoaiGD.Items.Add("Thu nhập");
                        cbo_LoaiGD.Items.Add("Chuyển tiền");
                        cbo_LoaiGD.SelectedIndex = 0;
                    }

                    // Transaction list
                    var dsGiaoDich = (from t in db.Transactions
                                      join a in db.Accounts on t.AccountID equals a.AccountID
                                      join c in db.Categories on t.CategoryID equals c.CategoryID into cGroup
                                      from c in cGroup.DefaultIfEmpty()
                                      where t.UserID == currentUserID
                                      orderby t.TransID descending
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

                    dgvGiaoDich.DataSource = null;
                    dgvGiaoDich.Columns.Clear();
                    dgvGiaoDich.DataSource = dsGiaoDich;

                    if (dgvGiaoDich.Columns.Count > 0)
                    {
                        dgvGiaoDich.Columns["MaGD"].HeaderText = "Mã GD";
                        dgvGiaoDich.Columns["TenTK"].HeaderText = "Tài khoản";
                        dgvGiaoDich.Columns["TenDM"].HeaderText = "Danh mục";
                        dgvGiaoDich.Columns["Loai"].HeaderText = "Loại GD";
                        dgvGiaoDich.Columns["SoTien"].HeaderText = "Số tiền";
                        dgvGiaoDich.Columns["SoTien"].DefaultCellStyle.Format = "N0";
                        dgvGiaoDich.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvGiaoDich.Columns["Ngay"].HeaderText = "Ngày GD";
                        dgvGiaoDich.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvGiaoDich.Columns["GhiChu"].HeaderText = "Ghi chú";
                        dgvGiaoDich.Columns["TenTK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        // Color rows by type
                        ColorGridRows();
                    }

                    // Summary totals
                    decimal tongThu = dsGiaoDich.Where(x => x.Loai == "Income").Sum(x => (decimal?)x.SoTien) ?? 0;
                    decimal tongChi = dsGiaoDich.Where(x => x.Loai == "Expense").Sum(x => (decimal?)x.SoTien) ?? 0;
                    int cntThu = dsGiaoDich.Count(x => x.Loai == "Income");
                    int cntChi = dsGiaoDich.Count(x => x.Loai == "Expense");

                    lblTotalIncome.Text = tongThu.ToString("N0") + " VNĐ";
                    lblTotalExpense.Text = tongChi.ToString("N0") + " VNĐ";
                    lblChangeIncome.Text = cntThu + " giao dịch";
                    lblChangeExpense.Text = cntChi + " giao dịch";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Color each row green/red/blue based on transaction type
        private void ColorGridRows()
        {
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                if (row.Cells["Loai"].Value == null) continue;
                string loai = row.Cells["Loai"].Value.ToString();
                if (loai == "Income")
                    row.DefaultCellStyle.ForeColor = C_Green;
                else if (loai == "Expense")
                    row.DefaultCellStyle.ForeColor = C_Red;
                else
                    row.DefaultCellStyle.ForeColor = C_Blue;
            }
        }

        //  COMBOBOX EVENTS
        private void cbo_TaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TaiKhoan.SelectedValue == null) return;
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                string accID = cbo_TaiKhoan.SelectedValue.ToString();
                var acc = db.Accounts.SingleOrDefault(a => a.AccountID == accID);
                if (acc != null)
                    txt_SoDu.Text = acc.Balance.Value.ToString("N0") + " VNĐ";
            }
        }

        private void cbo_LoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_LoaiGD.SelectedItem == null) return;
            string loaiGD = cbo_LoaiGD.SelectedItem.ToString(); // Thu, Chi, hoặc Chuyển tiền

            using (DB_SystemDataContext db = new DB_SystemDataContext())
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
                    cbo_DanhMuc.Enabled = true;


                    string dbType = (loaiGD == "Thu nhập") ? "Income" : "Expense";
                    var danhMucList = db.Categories.Where(c => c.CategoryType == dbType).ToList();
                    cbo_DanhMuc.DataSource = danhMucList;
                    cbo_DanhMuc.DisplayMember = "CategoryName";
                    cbo_DanhMuc.ValueMember = "CategoryID";
                }
            }
        }

        //  CRUD BUTTONS
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
            using (DB_SystemDataContext db = new DB_SystemDataContext())
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

            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                var t = db.Transactions.SingleOrDefault(x => x.TransID == currentTransID);
                if (t != null)
                {
                    // Hoàn trả lại tiền của giao dịch CŨ
                    var oldAcc = db.Accounts.SingleOrDefault(a => a.AccountID == t.AccountID);
                    if (oldAcc != null)
                    {
                        if (t.TransType == "Income") oldAcc.Balance -= t.Amount;
                        else if (t.TransType == "Expense") oldAcc.Balance += t.Amount;
                    }

                    // Tính toán trừ/cộng cho số tiền MỚI và ví MỚI
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

                    // Cập nhật thông tin lưu vào CSDL
                    t.AccountID = newAccID;
                    t.CategoryID = cbo_DanhMuc.SelectedValue?.ToString();
                    t.TransType = (loaiGD == "Thu nhập") ? "Income" : "Expense";
                    t.Amount = soTien;
                    t.TransDate = dtp_NgayGD.Value.Date;
                    t.Note = txt_Note.Text.Trim();

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật giao dịch thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    currentTransID = "";
                    LoadData();
                    btn_Reset.PerformClick();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTransID))
            {
                MessageBox.Show("Vui lòng click chọn một giao dịch trong bảng để Xóa!", "Cảnh báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?\nTiền trong ví sẽ được hoàn lại tự động.",
                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DB_SystemDataContext db = new DB_SystemDataContext())
                {
                    var t = db.Transactions.SingleOrDefault(x => x.TransID == currentTransID);
                    if (t != null)
                    {
                        // Tìm ví tiền tương ứng để HOÀN TIỀN
                        var acc = db.Accounts.SingleOrDefault(a => a.AccountID == t.AccountID);
                        if (acc != null)
                        {
                            if (t.TransType == "Income") acc.Balance -= t.Amount;
                            else if (t.TransType == "Expense") acc.Balance += t.Amount;
                            else
                            {
                                MessageBox.Show("Không xóa được giao dịch chuyển tiền!", "Thông báo",
                                    MessageBoxButtons.OK);
                                return;
                            }
                        }

                        // Xóa lịch sử và Lưu lại
                        db.Transactions.DeleteOnSubmit(t);
                        db.SubmitChanges();
                        MessageBox.Show("Đã xóa và hoàn tiền vào ví thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        currentTransID = "";
                        LoadData();
                        btn_Reset.PerformClick();
                    }
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            currentTransID = "";
            txt_Tien.Clear();
            txt_Note.Clear();
            txt_SoDu.Clear();
            DateTime today = DateTime.Now;
            dtp_NgayGD.Value = DateTime.Now;
            dtp_DenNgay.Value = DateTime.Now;
            dtp_TuNgay.Value = new DateTime(today.Year, today.Month, 1);
            if (cbo_LoaiGD.Items.Count > 0)
                cbo_LoaiGD.SelectedIndex = 0;
            if (cbo_TaiKhoan.Items.Count > 0)
                cbo_TaiKhoan.SelectedIndex = 0;

            // Visual feedback: briefly highlight the Them button
            btn_Them.BackColor = C_Green;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
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
            this.Close();
        }

        //  FILTER
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            using (DB_SystemDataContext db = new DB_SystemDataContext())
            {
                DateTime tuNgay = dtp_TuNgay.Value.Date;
                DateTime denNgay = dtp_DenNgay.Value.Date;

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

                dgvGiaoDich.DataSource = dsLoc;
                ColorGridRows();

                decimal tongThu = dsLoc.Where(x => x.Loai == "Income").Sum(x => (decimal?)x.SoTien) ?? 0;
                decimal tongChi = dsLoc.Where(x => x.Loai == "Expense").Sum(x => (decimal?)x.SoTien) ?? 0;
                int cntThu = dsLoc.Count(x => x.Loai == "Income");
                int cntChi = dsLoc.Count(x => x.Loai == "Expense");

                lblTotalIncome.Text = tongThu.ToString("N0") + " VNĐ";
                lblTotalExpense.Text = tongChi.ToString("N0") + " VNĐ";
                lblChangeIncome.Text = cntThu + " giao dịch";
                lblChangeExpense.Text = cntChi + " giao dịch";
            }
        }

        //  GRID CELL CLICK – populate form fields
        private void dgvGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvGiaoDich.Rows[e.RowIndex];
            currentTransID = row.Cells["MaGD"].Value.ToString();

            // Populate account
            string tenTK = row.Cells["TenTK"].Value.ToString();
            foreach (dynamic item in cbo_TaiKhoan.Items)
                if (item.AccountName == tenTK) { cbo_TaiKhoan.SelectedItem = item; break; }

            txt_Tien.Text = row.Cells["SoTien"].Value.ToString();
            dtp_NgayGD.Value = Convert.ToDateTime(row.Cells["Ngay"].Value);
            txt_Note.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            string loaiGD = row.Cells["Loai"].Value.ToString();
            if (loaiGD == "Income") cbo_LoaiGD.SelectedItem = "Thu nhập";
            else if (loaiGD == "Expense") cbo_LoaiGD.SelectedItem = "Chi tiêu";
            else cbo_LoaiGD.SelectedItem = "Chuyển tiền";

            if (cbo_DanhMuc.Enabled)
                cbo_DanhMuc.Text = row.Cells["TenDM"].Value.ToString();
        }

        //  PUBLIC REFRESH
        public void RefreshGiaoDich()
        {
            LoadData();
        }
    }
}