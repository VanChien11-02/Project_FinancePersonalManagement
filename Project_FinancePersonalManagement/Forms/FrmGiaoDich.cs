using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
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
                    var danhMucList = db.Categories.Where(c => c.CategoryType == dbType && c.UserID == currentUserID).ToList();
                    cbo_DanhMuc.DataSource = danhMucList;
                    cbo_DanhMuc.DisplayMember = "CategoryName";
                    cbo_DanhMuc.ValueMember = "CategoryID";
                }
            }
            UpdateRemainingBudgetDisplay();
        }

        // TÍNH TOÁN NGÂN SÁCH CÒN LẠI 
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

        //  CRUD BUTTONS 
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string Tien = txt_Tien.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            if (!decimal.TryParse(Tien, out decimal soTien) || soTien <= 0)
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

            string Tien = txt_Tien.Text.Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
            if (!decimal.TryParse(Tien, out decimal soTien) || soTien <= 0) return;

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

        // CÁC TÍNH NĂNG CHUYỂN THÁNG, EXCEL

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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                sfd.FileName = $"BaoCaoGiaoDich_{DateTime.Now:ddMMyyyy}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("GiaoDich");

                            // 1. CHÈN LOGO GÓC TRÁI (A1)
                            string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.png");
                            if (File.Exists(logoPath))
                            {
                                var picture = worksheet.AddPicture(logoPath);
                                picture.MoveTo(worksheet.Cell("A1"));
                                picture.Scale(0.8); // Chỉnh tỷ lệ to/nhỏ của logo (0.8 = 80%)
                            }

                            //TẠO TIÊU ĐỀ VÀ THỜI GIAN (D2, D3)
                            // Dịch sang cột C để không bị đè bởi Logo
                            worksheet.Cell("D2").Value = "BÁO CÁO GIAO DỊCH TÀI CHÍNH";
                            worksheet.Cell("D2").Style.Font.Bold = true;
                            worksheet.Cell("D2").Style.Font.FontSize = 16;
                            worksheet.Cell("D2").Style.Font.FontColor = XLColor.FromHtml("#185FA5"); // Màu xanh đặc trưng của bạn

                            // Lấy ngày từ DateTimePicker có sẵn trên Form của bạn
                            string textThoiGian = $"Từ ngày {dtp_TuNgay.Value:dd/MM/yyyy} đến ngày {dtp_DenNgay.Value:dd/MM/yyyy}";
                            worksheet.Cell("D3").Value = textThoiGian;
                            worksheet.Cell("D3").Style.Font.Italic = true;

                            // ĐỔ DỮ LIỆU BẢNG (Bắt đầu từ dòng 6)
                            int startRow = 6;

                            // Header bảng
                            for (int i = 0; i < dgvGiaoDich.Columns.Count; i++)
                            {
                                var cell = worksheet.Cell(startRow, i + 1);
                                cell.Value = dgvGiaoDich.Columns[i].HeaderText;
                                cell.Style.Font.Bold = true;
                                cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                                cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // Dữ liệu bảng
                            int currentRow = startRow + 1;
                            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
                            {
                                if (row.IsNewRow) continue;
                                for (int j = 0; j < dgvGiaoDich.Columns.Count; j++)
                                {
                                    var cell = worksheet.Cell(currentRow, j + 1);
                                    cell.Value = row.Cells[j].Value?.ToString() ?? "";
                                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                                }
                                currentRow++;
                            }

                            worksheet.Columns().AdjustToContents(); // Tự động dãn cột cho đẹp
                            workbook.SaveAs(sfd.FileName);
                        }

                        //HỎI NGƯỜI DÙNG CÓ MUỐN MỞ FILE KHÔNG?
                        var result = MessageBox.Show(
                            "Đã xuất file Excel thành công!\nBạn có muốn mở file lên để xem ngay không?",
                            "Hoàn tất",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Lệnh mở file bằng ứng dụng mặc định của Windows (Excel)
                            Process.Start(new ProcessStartInfo()
                            {
                                FileName = sfd.FileName,
                                UseShellExecute = true // Bắt buộc = true để Windows tự tìm Excel mở file
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private enum LineType { Title, GroupHeader, SubGroupHeader, DataRowHeader, DataRow, SubGroupTotal, GroupTotal, EmptyLine }

        private class PrintLine
        {
            public LineType Type { get; set; }
            public string[] Texts { get; set; }
            public Brush TextColor { get; set; } = Brushes.Black;
        }

        private List<PrintLine> _printLines = new List<PrintLine>();
        private int _currentPrintLineIndex = 0;

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvGiaoDich.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. Chuẩn bị dữ liệu và tính toán Hạn mức (Budget) trước khi in
            PreparePrintData();

            // 2. Cấu hình PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = false; // In khổ dọc
            pd.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50); // Căn lề
            pd.PrintPage += new PrintPageEventHandler(this.PrintBaoCao_Page);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.WindowState = FormWindowState.Maximized; // Mở full màn hình cho dễ xem
            ppd.ShowDialog();
        }

        private void PreparePrintData()
        {
            _printLines.Clear();
            _currentPrintLineIndex = 0;

            // Lấy toàn bộ dữ liệu thô từ Grid
            var rawData = new List<dynamic>();
            foreach (DataGridViewRow row in dgvGiaoDich.Rows)
            {
                if (row.IsNewRow || row.Cells["MaGD"].Value == null) continue;
                rawData.Add(new
                {
                    MaGD = row.Cells["MaGD"].Value.ToString(),
                    TenTK = row.Cells["TenTK"].Value.ToString(),
                    TenDM = row.Cells["TenDM"].Value.ToString(),
                    Loai = row.Cells["Loai"].Value.ToString(),
                    SoTien = Convert.ToDecimal(row.Cells["SoTien"].Value),
                    Ngay = Convert.ToDateTime(row.Cells["Ngay"].Value),
                    GhiChu = row.Cells["GhiChu"].Value?.ToString() ?? ""
                });
            }

            // Kết nối DB để kiểm tra Hạn mức (Budget) cho các khoản Expense
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var allBudgets = db.Budgets.Where(b => b.UserID == currentUserID).ToList();
                var allCategories = db.Categories.Where(c => c.UserID == currentUserID).ToList();
                var allMonthExpenses = db.Transactions.Where(t => t.UserID == currentUserID && t.TransType == "Expense").ToList();

                _printLines.Add(new PrintLine { Type = LineType.Title, Texts = new[] { "BÁO CÁO GIAO DỊCH TÀI CHÍNH" } });
                _printLines.Add(new PrintLine { Type = LineType.EmptyLine });

                // Gom nhóm theo LOẠI GIAO DỊCH (Income, Expense, Transfer)
                var groupedByLoai = rawData.GroupBy(r => r.Loai).OrderBy(g => g.Key);

                foreach (var gLoai in groupedByLoai)
                {
                    string loaiText = gLoai.Key == "Income" ? "THU NHẬP" : (gLoai.Key == "Expense" ? "CHI TIÊU" : "CHUYỂN TIỀN");
                    _printLines.Add(new PrintLine { Type = LineType.GroupHeader, Texts = new[] { $"[+] {loaiText.ToUpper()}" } });

                    decimal totalLoai = 0;
                    // Gom nhóm tiếp theo DANH MỤC
                    var groupedByDM = gLoai.GroupBy(r => r.TenDM).OrderBy(g => g.Key);

                    foreach (var gDM in groupedByDM)
                    {
                        _printLines.Add(new PrintLine { Type = LineType.SubGroupHeader, Texts = new[] { $"  - Danh mục: {gDM.Key}" } });
                        _printLines.Add(new PrintLine { Type = LineType.DataRowHeader, Texts = new[] { "Ngày GD", "Mã GD", "Tài khoản", "Số tiền", "Ghi chú" } });

                        decimal totalDM = 0;
                        foreach (var item in gDM)
                        {
                            bool isOverBudget = false;

                            // KIỂM TRA VƯỢT HẠN MỨC (Chỉ áp dụng cho Chi tiêu)
                            if (item.Loai == "Expense")
                            {
                                int m = item.Ngay.Month;
                                int y = item.Ngay.Year;
                                var cat = allCategories.FirstOrDefault(c => c.CategoryName == item.TenDM && c.CategoryType == "Expense");

                                if (cat != null)
                                {
                                    var budget = allBudgets.FirstOrDefault(b => b.CategoryID == cat.CategoryID && b.Month == m && b.Year == y);
                                    if (budget != null)
                                    {
                                        decimal totalSpentInMonth = allMonthExpenses
                                            .Where(t => t.CategoryID == cat.CategoryID && t.TransDate.Value.Month == m && t.TransDate.Value.Year == y)
                                            .Sum(t => (decimal?)t.Amount) ?? 0;

                                        if (totalSpentInMonth > budget.Amount) isOverBudget = true; // Bị lố ngân sách!
                                    }
                                }
                            }

                            // Thêm dòng dữ liệu (Tô đỏ nếu lố ngân sách)
                            _printLines.Add(new PrintLine
                            {
                                Type = LineType.DataRow,
                                Texts = new string[] {
        ((DateTime)item.Ngay).ToString("dd/MM/yyyy"),
        item.MaGD.ToString(),
        item.TenTK.ToString(),
        ((decimal)item.SoTien).ToString("N0"),
        (item.GhiChu ?? "").ToString()
    },
                                TextColor = isOverBudget ? Brushes.Red : Brushes.Black
                            });
                            totalDM += item.SoTien;
                        }

                        totalLoai += totalDM;
                        _printLines.Add(new PrintLine { Type = LineType.SubGroupTotal, Texts = new[] { $"    >> Tổng {gDM.Key}: {totalDM:N0} VNĐ" } });
                        _printLines.Add(new PrintLine { Type = LineType.EmptyLine });
                    }

                    _printLines.Add(new PrintLine { Type = LineType.GroupTotal, Texts = new[] { $">> TỔNG CỘNG {loaiText}: {totalLoai:N0} VNĐ" } });
                    _printLines.Add(new PrintLine { Type = LineType.EmptyLine });
                    _printLines.Add(new PrintLine { Type = LineType.EmptyLine });
                }
            }
        }

        private void PrintBaoCao_Page(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fTitle = new Font("Arial", 18, FontStyle.Bold);
            Font fGroup = new Font("Arial", 12, FontStyle.Bold);
            Font fSubGroup = new Font("Arial", 11, FontStyle.Bold | FontStyle.Italic);
            Font fDataHead = new Font("Arial", 10, FontStyle.Bold);
            Font fData = new Font("Arial", 10);
            Font fTotal = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);

            float y = e.MarginBounds.Top;
            float left = e.MarginBounds.Left;
            float width = e.MarginBounds.Width;

            // CHIA TỶ LỆ CỘT ĐỘNG (Total = 100% width)
            // Ngày (15%), Mã GD (15%), TK (20%), Số tiền (20%), Ghi chú (30%)
            float[] colX = { left + 30, left + 30 + width * 0.15f, left + 30 + width * 0.30f, left + 30 + width * 0.50f, left + 30 + width * 0.70f };
            float[] colW = { width * 0.15f, width * 0.15f, width * 0.20f, width * 0.20f, width * 0.28f };

            while (_currentPrintLineIndex < _printLines.Count)
            {
                var line = _printLines[_currentPrintLineIndex];
                float lineHeight = 25; // Chiều cao mặc định mỗi dòng

                if (line.Type == LineType.Title)
                {
                    SizeF size = g.MeasureString(line.Texts[0], fTitle);
                    g.DrawString(line.Texts[0], fTitle, Brushes.Black, left + (width - size.Width) / 2, y);
                    lineHeight = 45;
                }
                else if (line.Type == LineType.GroupHeader)
                {
                    g.DrawString(line.Texts[0], fGroup, new SolidBrush(Color.FromArgb(24, 95, 165)), left, y);
                    lineHeight = 30;
                }
                else if (line.Type == LineType.SubGroupHeader)
                {
                    g.DrawString(line.Texts[0], fSubGroup, Brushes.Black, left, y);
                    lineHeight = 25;
                }
                else if (line.Type == LineType.DataRowHeader)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 3) // Cột Số tiền căn phải
                        {
                            StringFormat sf = new StringFormat() { Alignment = StringAlignment.Far };
                            g.DrawString(line.Texts[i], fDataHead, Brushes.Black, colX[i] + colW[i] - 10, y, sf);
                        }
                        else g.DrawString(line.Texts[i], fDataHead, Brushes.Black, colX[i], y);
                    }
                    g.DrawLine(Pens.Black, left + 30, y + 20, left + width, y + 20); // Dòng kẻ ngang
                    lineHeight = 25;
                }
                else if (line.Type == LineType.DataRow)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 3) // Cột Số tiền căn phải để thẳng hàng dấu phẩy
                        {
                            StringFormat sf = new StringFormat() { Alignment = StringAlignment.Far };
                            g.DrawString(line.Texts[i], fData, line.TextColor, colX[i] + colW[i] - 10, y, sf);
                        }
                        else
                        {
                            // Tự động cắt chuỗi nếu Ghi chú quá dài (Hiện dấu ...)
                            RectangleF rect = new RectangleF(colX[i], y, colW[i], 20);
                            StringFormat sf = new StringFormat() { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap };
                            g.DrawString(line.Texts[i], fData, line.TextColor, rect, sf);
                        }
                    }
                    lineHeight = 25;
                }
                else if (line.Type == LineType.SubGroupTotal)
                {
                    g.DrawString(line.Texts[0], fTotal, Brushes.DimGray, left + 30, y);
                    lineHeight = 25;
                }
                else if (line.Type == LineType.GroupTotal)
                {
                    g.DrawString(line.Texts[0], fGroup, new SolidBrush(Color.FromArgb(163, 45, 45)), left, y);
                    lineHeight = 30;
                }
                else if (line.Type == LineType.EmptyLine)
                {
                    lineHeight = 15;
                }

                y += lineHeight;
                _currentPrintLineIndex++;

                // NẾU CHẠY HẾT TRANG -> Bật cờ HasMorePages và thoát hàm để Windows nạp trang mới
                if (y > e.MarginBounds.Bottom - 30)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Nếu in hết List thì tắt cờ sang trang
            e.HasMorePages = false;
        }


    }
}