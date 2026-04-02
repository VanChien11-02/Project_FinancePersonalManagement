using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
// using OfficeOpenXml; // Cài thư viện EPPlus từ NuGet rồi bỏ comment dòng này để xuất Excel
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmGiaoDich : Form
    {
        private string currentUserID;
        private string currentTransID = "";

        // Biến lưu trữ tháng đang xem trên UI
        private DateTime currentViewMonth = DateTime.Now;

        private static readonly Color C_Green = Color.FromArgb(15, 110, 80);
        private static readonly Color C_Blue = Color.FromArgb(24, 95, 165);
        private static readonly Color C_Red = Color.FromArgb(163, 45, 45);
        private static readonly Color C_Border = Color.FromArgb(220, 220, 220);

        public FrmGiaoDich(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
            dtp_NgayGD.ValueChanged += (s, e) => UpdateRemainingBudgetDisplay();
            cbo_DanhMuc.SelectedIndexChanged += (s, e) => UpdateRemainingBudgetDisplay();
            cbo_LoaiGD.SelectedIndexChanged += (s, e) => UpdateRemainingBudgetDisplay();
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
        private void FrmGiaoDich_Load(object sender, EventArgs e)
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

            // Cập nhật Label tháng năm
            if (lblThangNam != null)
                lblThangNam.Text = $"Tháng {currentViewMonth.Month}/{currentViewMonth.Year}";

            LoadData();
        }

        //  LOAD DATA 
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
                        cbo_TaiKhoan.DataSource = tkList;
                        cbo_TaiKhoan.DisplayMember = "AccountName";
                        cbo_TaiKhoan.ValueMember = "AccountID";

                        var tkListDest = db.Accounts.Where(a => a.UserID == currentUserID).ToList();
                        cbo_ChuyenDenTK.DataSource = tkListDest;
                        cbo_ChuyenDenTK.DisplayMember = "AccountName";
                        cbo_ChuyenDenTK.ValueMember = "AccountID";

                        if (tkList.Any())
                        {
                            cbo_TaiKhoan.SelectedIndex = 0;
                            var firstAcc = tkList[0];
                            txt_SoDu.Text = (firstAcc.Balance.HasValue ? firstAcc.Balance.Value.ToString("N0") : "0") + " VNĐ";
                        }
                    }

                    if (cbo_LoaiGD.Items.Count == 0)
                    {
                        cbo_LoaiGD.Items.Add("Chi tiêu");
                        cbo_LoaiGD.Items.Add("Thu nhập");
                        cbo_LoaiGD.Items.Add("Chuyển tiền");
                        cbo_LoaiGD.SelectedIndex = 0;
                    }

                    // Đổ dữ liệu Giao dịch lên DataGridView (Lọc theo tháng hiện tại)
                    var dsGiaoDich = (from t in db.Transactions
                                      join a in db.Accounts on t.AccountID equals a.AccountID
                                      join c in db.Categories on t.CategoryID equals c.CategoryID into cGroup
                                      from c in cGroup.DefaultIfEmpty()
                                      where t.UserID == currentUserID
                                         && t.TransDate.Value.Month == currentViewMonth.Month
                                         && t.TransDate.Value.Year == currentViewMonth.Year
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

                        ColorGridRows();
                    }

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
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ColorGridRows()
        {
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                if (row.Cells["Loai"].Value == null) continue;
                string loai = row.Cells["Loai"].Value.ToString();
                if (loai == "Income") row.DefaultCellStyle.ForeColor = C_Green;
                else if (loai == "Expense") row.DefaultCellStyle.ForeColor = C_Red;
                else row.DefaultCellStyle.ForeColor = C_Blue;
            }
        }

        //  COMBOBOX EVENTS
        private void cbo_TaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TaiKhoan.SelectedValue == null) return;
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
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
            string loaiGD = cbo_LoaiGD.SelectedItem.ToString();

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                if (loaiGD == "Chuyển tiền")
                {
                    cbo_ChuyenDenTK.Visible = true;
                    lbl_ChuyenDenTK.Visible = true;
                    cbo_DanhMuc.DataSource = null;
                    cbo_DanhMuc.Enabled = false;
                    if (txt_ConLai != null) txt_ConLai.Text = "";
                }
                else
                {
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
            UpdateRemainingBudgetDisplay();
        }

        // TÍNH TOÁN NGÂN SÁCH CÒN LẠI (ĐÃ FIX LỖI)
        private void UpdateRemainingBudgetDisplay()
        {
            try
            {
                if (txt_ConLai == null) return;

                // 1. Chỉ tính nếu là "Chi tiêu" và đã chọn Danh mục
                if (cbo_LoaiGD.SelectedItem == null || cbo_LoaiGD.SelectedItem.ToString() != "Chi tiêu" || cbo_DanhMuc.SelectedValue == null)
                {
                    txt_ConLai.Text = "";
                    return;
                }

                string categoryId = cbo_DanhMuc.SelectedValue.ToString();

                // LẤY THÁNG/NĂM TỪ DATETIMEPICKER (Đây là mấu chốt)
                int month = dtp_NgayGD.Value.Month;
                int year = dtp_NgayGD.Value.Year;

                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    // 2. Tìm ngân sách của tháng/năm ĐANG CHỌN trên dtp_NgayGD
                    var budgetRecord = db.Budgets.FirstOrDefault(b => b.UserID == currentUserID
                                                                   && b.CategoryID == categoryId
                                                                   && b.Month == month
                                                                   && b.Year == year);

                    if (budgetRecord == null)
                    {
                        // Nếu hiện cái này, nghĩa là bạn chưa vào Form Ngân Sách để lưu hạn mức cho tháng này
                        txt_ConLai.Text = "Chưa thiết lập NS";
                        return;
                    }

                    decimal budgetLimit = (decimal)budgetRecord.Amount;

                    // 3. Tính tổng các giao dịch đã thực hiện TRONG THÁNG ĐANG CHỌN
                    decimal alreadySpent = db.Transactions
                        .Where(t => t.UserID == currentUserID
                                 && t.CategoryID == categoryId
                                 && t.TransDate.Value.Month == month
                                 && t.TransDate.Value.Year == year
                                 && t.TransType == "Expense")
                        .Select(t => (decimal?)t.Amount).Sum() ?? 0m;

                    // 4. Hiển thị kết quả
                    decimal remaining = budgetLimit - alreadySpent;
                    txt_ConLai.Text = remaining.ToString("N0");
                }
            }
            catch (Exception)
            {
                txt_ConLai.Text = "Lỗi tính toán";
            }
        }

        private void cbo_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRemainingBudgetDisplay();
        }

        private void dtp_NgayGD_ValueChanged(object sender, EventArgs e)
        {
            UpdateRemainingBudgetDisplay();
        }

        //  CRUD BUTTONS (Đã khôi phục đầy đủ)
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

            // Cảnh báo ngân sách
            if (loaiGD == "Chi tiêu" && txt_ConLai != null && !string.IsNullOrEmpty(txt_ConLai.Text) &&txt_ConLai.Text != "Chưa thiết lập NS")
            {
                decimal.TryParse(txt_ConLai.Text.Replace(",", "").Replace(".", ""), out decimal remaining);
                if (soTien > remaining)
                {
                    var result = MessageBox.Show($"Số tiền bạn nhập ({soTien:N0}) đang vượt quá hạn mức ngân sách còn lại của tháng này ({remaining:N0}).\nBạn có chắc chắn muốn ghi nhận khoản chi này không?",
                                                 "Cảnh báo vượt hạn mức", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No) return;
                }
            }

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

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    string newTransID = "TXN0001";
                    var lastTrans = db.Transactions.OrderByDescending(t => t.TransID).FirstOrDefault();
                    if (lastTrans != null)
                    {
                        int lastNum = int.Parse(lastTrans.TransID.Substring(3));
                        newTransID = "TXN" + (lastNum + 1).ToString("D4");
                    }

                    var viNguon = db.Accounts.SingleOrDefault(a => a.AccountID == maTaiKhoanNguon);
                    if (viNguon == null) return;

                    if ((loaiGD == "Chi tiêu" || loaiGD == "Chuyển tiền") && soTien > viNguon.Balance)
                    {
                        MessageBox.Show($"Tài khoản này chỉ còn {viNguon.Balance.Value:N0} VNĐ.\nBạn không thể giao dịch số tiền lớn hơn số dư hiện có!",
                                        "Thiếu tiền", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_Tien.Focus();
                        return;
                    }

                    if (loaiGD == "Thu nhập" || loaiGD == "Chi tiêu")
                    {
                        string dbType = (loaiGD == "Thu nhập") ? "Income" : "Expense";
                        string danhMucID = cbo_DanhMuc.SelectedValue.ToString();

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

                        if (loaiGD == "Thu nhập") viNguon.Balance += soTien;
                        else viNguon.Balance -= soTien;
                    }
                    else if (loaiGD == "Chuyển tiền")
                    {
                        var viDich = db.Accounts.SingleOrDefault(a => a.AccountID == maTaiKhoanDich);
                        if (viDich == null) return;

                        viNguon.Balance -= soTien;
                        viDich.Balance += soTien;

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

                    db.SubmitChanges();
                    MessageBox.Show("Ghi chép giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    txt_Note.Clear();
                    txt_Tien.Focus();
                    txt_SoDu.Text = viNguon.Balance.Value.ToString("N0") + " VNĐ";
                    btn_Reset.PerformClick();

                    UpdateRemainingBudgetDisplay();
                    LoadData();
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

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var t = db.Transactions.SingleOrDefault(x => x.TransID == currentTransID);
                if (t != null)
                {
                    var oldAcc = db.Accounts.SingleOrDefault(a => a.AccountID == t.AccountID);
                    if (oldAcc != null)
                    {
                        if (t.TransType == "Income") oldAcc.Balance -= t.Amount;
                        else if (t.TransType == "Expense") oldAcc.Balance += t.Amount;
                    }

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

                    t.AccountID = newAccID;
                    t.CategoryID = cbo_DanhMuc.SelectedValue?.ToString();
                    t.TransType = (loaiGD == "Thu nhập") ? "Income" : "Expense";
                    t.Amount = soTien;
                    t.TransDate = dtp_NgayGD.Value.Date;
                    t.Note = txt_Note.Text.Trim();

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật giao dịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        var acc = db.Accounts.SingleOrDefault(a => a.AccountID == t.AccountID);
                        if (acc != null)
                        {
                            if (t.DebtID != null)
                            {
                                MessageBox.Show("Không xóa được giao dịch có liên quan đến khoản vay!", "Thông báo", MessageBoxButtons.OK);
                                return;
                            }
                            if (t.TransType == "Income") acc.Balance -= t.Amount;
                            else if (t.TransType == "Expense") acc.Balance += t.Amount;
                            else
                            {
                                MessageBox.Show("Không xóa được giao dịch chuyển tiền!", "Thông báo", MessageBoxButtons.OK);
                                return;
                            }
                        }

                        db.Transactions.DeleteOnSubmit(t);
                        db.SubmitChanges();
                        MessageBox.Show("Đã xóa và hoàn tiền vào ví thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (txt_ConLai != null) txt_ConLai.Clear();

            DateTime today = DateTime.Now;
            dtp_NgayGD.Value = DateTime.Now;
            dtp_DenNgay.Value = DateTime.Now;
            dtp_TuNgay.Value = new DateTime(today.Year, today.Month, 1);

            if (cbo_LoaiGD.Items.Count > 0) cbo_LoaiGD.SelectedIndex = 0;
            if (cbo_TaiKhoan.Items.Count > 0) cbo_TaiKhoan.SelectedIndex = 0;

            btn_Them.BackColor = C_Green;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMenu = Application.OpenForms.OfType<FrmMainMenu>().FirstOrDefault();
            if (frmMenu != null) frmMenu.RefreshMenu();

            FrmTaiKhoan frmTaiKhoan = Application.OpenForms.OfType<FrmTaiKhoan>().FirstOrDefault();
            if (frmTaiKhoan != null) frmTaiKhoan.RefreshTaiKhoan();

            FrmThongKe frmThongKe = Application.OpenForms.OfType<FrmThongKe>().FirstOrDefault();
            if (frmThongKe != null) frmThongKe.RefreshThongKe();

            this.Close();
        }

        // LỌC DỮ LIỆU
        private void btn_Loc_Click(object sender, EventArgs e)
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
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

        private void dgvGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvGiaoDich.Rows[e.RowIndex];
            currentTransID = row.Cells["MaGD"].Value.ToString();

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

        public void RefreshGiaoDich()
        {
            LoadData();
        }

        // ==========================================
        // CÁC TÍNH NĂNG MỚI (CHUYỂN THÁNG, EXCEL)
        // ==========================================

        private void btnThangTruoc_Click(object sender, EventArgs e)
        {
            currentViewMonth = currentViewMonth.AddMonths(-1);
            if (lblThangNam != null) lblThangNam.Text = $"Tháng {currentViewMonth.Month}/{currentViewMonth.Year}";
            LoadData();
        }

        private void btnThangSau_Click(object sender, EventArgs e)
        {
            currentViewMonth = currentViewMonth.AddMonths(1);
            if (lblThangNam != null) lblThangNam.Text = $"Tháng {currentViewMonth.Month}/{currentViewMonth.Year}";
            LoadData();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvGiaoDich.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
            sfd.FileName = $"GiaoDich_Thang_{currentViewMonth.Month}_{currentViewMonth.Year}.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đã thiết lập khung code Excel. Vui lòng cài gói EPPlus từ NuGet để chạy thực tế.", "Info");
            }
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã chuẩn bị sẵn logic gọi Report.\nBạn hãy thiết kế file .rpt và truyền DataSource từ danh sách hiện tại của dgvGiaoDich vào nhé!", "Crystal Reports");
        }
    }
}