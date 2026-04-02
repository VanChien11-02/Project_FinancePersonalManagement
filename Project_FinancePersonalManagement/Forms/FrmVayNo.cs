using Project_FinancePersonalManagement.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_FinancePersonalManagement
{
    public partial class FrmVayNo : Form
    {
        private string currentUserID;
        private string currentDebtlID;

        private static readonly Color C_Green = Color.FromArgb(15, 110, 80);
        private static readonly Color C_Blue = Color.FromArgb(24, 95, 165);
        private static readonly Color C_Red = Color.FromArgb(163, 45, 45);
        private static readonly Color C_Amber = Color.FromArgb(180, 110, 20);
        private static readonly Color C_Border = Color.FromArgb(220, 220, 220);

        // Row status colors (softer palette)
        private static readonly Color C_RowDone = Color.FromArgb(232, 247, 238);  // light green
        private static readonly Color C_RowOverdue = Color.FromArgb(255, 243, 224);  // light amber
        private static readonly Color C_RowActive = Color.FromArgb(254, 242, 242);  // light red

        public FrmVayNo(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
        }

        //  PAINT HANDLERS

        private void TabBar_Paint(object sender, PaintEventArgs e)
        {
            var p = (Panel)sender;
            using (var pen = new Pen(C_Border, 1f))
                e.Graphics.DrawLine(pen, 0, p.Height - 1, p.Width, p.Height - 1);
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
        private void form_KhoanVay_ChoVay_Load(object sender, EventArgs e)
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                bool hasAccounts = db.Accounts.Any(a => a.UserID == currentUserID);
                if (!hasAccounts)
                {
                    MessageBox.Show("Bạn chưa có tài khoản/ví nào!\nVui lòng vào mục [Tài khoản] để tạo mới trước khi ghi chép vay / cho vay.",
                             "Cảnh báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
            }

            rb_TatCa.Checked = true;
            rb_ToiVay.Checked = true;
            txt_SoDu.Enabled = false;
            txt_TienThanhToan.Enabled = false;
            txt_TienCanThanhToan.Enabled = false;

            // Style active tab
            UpdateTabStyle();
            LoadData();
        }

        // Update tab button forecolor when checked (Appearance=Button does most of it,
        // but we also want white text on the selected blue tab)
        private void UpdateTabStyle()
        {
            foreach (RadioButton rb in new[] { rb_TatCa, rb_DiVay, rb_ChoMuon, rb_ChuaThanhToan })
            {
                rb.ForeColor = rb.Checked ? Color.White : Color.FromArgb(60, 60, 60);
            }
        }

        //  LOAD DATA
        private void LoadData()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                // NẠP COMBOBOX TÀI KHOẢN
                if (cbo_TaiKhoan.DataSource == null)
                {
                    var tkList = db.Accounts.Where(a => a.UserID == currentUserID).ToList();
                    cbo_TaiKhoan.DataSource = tkList;
                    cbo_TaiKhoan.DisplayMember = "AccountName";
                    cbo_TaiKhoan.ValueMember = "AccountID";
                }
                try
                {
                    var query = from d in db.Debts
                                join a in db.Accounts on d.AccountID equals a.AccountID
                                where d.UserID == currentUserID
                                select new { d, a };

                    // Lọc theo các RadioButton
                    if (rb_ChoMuon.Checked)
                        query = query.Where(x => x.d.DebtType == "Cho mượn");
                    else if (rb_DiVay.Checked)
                        query = query.Where(x => x.d.DebtType == "Đi vay");
                    else if (rb_ChuaThanhToan.Checked)
                        query = query.Where(x => x.d.Status == "Active");

                    var dsVayNo = query.OrderByDescending(x => x.d.StartDate).ToList()
                        .Select(x => {
                            // Tính toán ngày còn lại
                            string ngayConLaiText = "";
                            if (x.d.Status == "Active" && x.d.DueDate.HasValue)
                            {
                                int days = (x.d.DueDate.Value.Date - DateTime.Now.Date).Days;
                                ngayConLaiText = days < 0 ? $"Quá hạn {Math.Abs(days)} ngày" : $"{days} ngày";
                            }
                            else if (x.d.Status == "Finished")
                            {
                                ngayConLaiText = "Done";
                            }

                            return new
                            {
                                MaVay = x.d.DebtID,
                                Loai = x.d.DebtType,
                                Ten = x.d.PersonName,
                                SoTien = x.d.Amount,
                                LaiSuat = x.d.InterestRate,
                                TienDaTra = x.d.PaidAmount,
                                NgayVay = x.d.StartDate,
                                HanTra = x.d.DueDate,
                                NgayConLai = ngayConLaiText, // CỘT MỚI ĐÂY
                                TrangThai = x.d.Status == "Active" ? "Chưa thanh toán" : "Đã hoàn thành",
                                TaiKhoan = x.a.AccountName,
                                GhiChu = db.Transactions.FirstOrDefault(t => t.DebtID == x.d.DebtID && (t.TransType == "Income" || t.TransType == "Expense"))?.Note ?? ""
                            };
                        }).ToList();

                    dgv_dsVayMuon.DataSource = dsVayNo;

                    if (dgv_dsVayMuon.Columns.Count > 0)
                    {
                        //dgv_dsVayMuon.Columns["MaVay"].Visible = false;
                        dgv_dsVayMuon.Columns["MaVay"].HeaderText = "Mã khoản vay";
                        dgv_dsVayMuon.Columns["Loai"].HeaderText = "Loại";
                        dgv_dsVayMuon.Columns["Ten"].HeaderText = "Đối tác";
                        dgv_dsVayMuon.Columns["SoTien"].HeaderText = "Số tiền";
                        dgv_dsVayMuon.Columns["SoTien"].DefaultCellStyle.Format = "N0";
                        dgv_dsVayMuon.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv_dsVayMuon.Columns["LaiSuat"].HeaderText = "Lãi suất (%)";
                        dgv_dsVayMuon.Columns["TienDaTra"].HeaderText = "Số tiền đã trả";
                        dgv_dsVayMuon.Columns["TienDaTra"].DefaultCellStyle.Format = "N0";
                        dgv_dsVayMuon.Columns["TienDaTra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgv_dsVayMuon.Columns["NgayVay"].HeaderText = "Ngày vay";
                        dgv_dsVayMuon.Columns["NgayVay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgv_dsVayMuon.Columns["HanTra"].HeaderText = "Hạn trả";
                        dgv_dsVayMuon.Columns["HanTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgv_dsVayMuon.Columns["TrangThai"].HeaderText = "Trạng thái";
                        dgv_dsVayMuon.Columns["TaiKhoan"].HeaderText = "Tài khoản";
                        dgv_dsVayMuon.Columns["NgayConLai"].HeaderText = "Còn lại";
                        dgv_dsVayMuon.Columns["NgayConLai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        dgv_dsVayMuon.Columns["GhiChu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    // TÍNH TỔNG TIỀN (Chỉ tính những khoản 'Active')
                    var listActive = db.Debts.Where(d => d.UserID == currentUserID && d.Status == "Active").ToList();
                    decimal tongNo = listActive.Where(d => d.DebtType == "Đi vay").Sum(d => d.Amount);
                    decimal tongChoMuon = listActive.Where(d => d.DebtType == "Cho mượn").Sum(d => d.Amount);

                    int cntNo = listActive.Count(d => d.DebtType == "Đi vay");
                    int cntChoMuon = listActive.Count(d => d.DebtType == "Cho mượn");

                    lblTotal_No.Text = tongNo.ToString("N0") + " VNĐ";
                    lblTotal_ChoMuon.Text = tongChoMuon.ToString("N0") + " VNĐ";
                    lblSubNo.Text = cntNo + " khoản nợ đang hoạt động";
                    lblSubChoMuon.Text = cntChoMuon + " khoản cho vay đang hoạt động";
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        //  GRID ROW COLORING
        private void dgv_dsVayMuon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_dsVayMuon.Rows)
            {
                string tt = row.Cells["TrangThai"].Value?.ToString();
                if (tt == "Đã hoàn thành")
                {
                    row.DefaultCellStyle.BackColor = C_RowDone;
                    row.DefaultCellStyle.ForeColor = C_Green;
                }
                else
                {
                    DateTime hanTra = Convert.ToDateTime(row.Cells["HanTra"].Value);
                    double daysLeft = (hanTra.Date - DateTime.Now.Date).TotalDays;
                    row.DefaultCellStyle.BackColor = (daysLeft <= 3) ? C_RowOverdue : C_RowActive;
                    row.DefaultCellStyle.ForeColor = (daysLeft <= 3) ? Color.FromArgb(120, 60, 0) : C_Red;
                }
            }
        }

        //  COMBOBOX / RADIO EVENTS
        private void cbo_TaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TaiKhoan.SelectedValue != null && cbo_TaiKhoan.SelectedValue is string maTK)
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var acc = db.Accounts.SingleOrDefault(a => a.AccountID == maTK);
                    if (acc != null)
                        txt_SoDu.Text = acc.Balance.Value.ToString("N0") + " VNĐ";
                }
            }
        }

        private void rb_TatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_TatCa.Checked) { lbl_title.Text = "Danh sach vay / cho vay"; UpdateTabStyle(); LoadData(); }
        }

        private void rb_DiVay_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_DiVay.Checked) { lbl_title.Text = "Danh sách vay"; UpdateTabStyle(); LoadData(); }
        }

        private void rb_ChoMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ChoMuon.Checked) { lbl_title.Text = "Danh sách cho mượn"; UpdateTabStyle(); LoadData(); }
        }

        private void rb_ChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ChuaThanhToan.Checked) { lbl_title.Text = "Danh sách chưa thanh toán"; UpdateTabStyle(); LoadData(); }
        }

        //  GRID CELL CLICK – fill form
        private void dgv_dsVayMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgv_dsVayMuon.Rows[e.RowIndex];

            currentDebtlID = row.Cells["MaVay"].Value.ToString();
            txt_Ten.Text = row.Cells["Ten"].Value.ToString();
            txt_Tien.Text = row.Cells["SoTien"].Value.ToString();
            txt_LaiSuat.Text = row.Cells["LaiSuat"].Value.ToString();
            dtp_TuNgay.Value = Convert.ToDateTime(row.Cells["NgayVay"].Value);
            if (row.Cells["HanTra"].Value != null) dtp_DenNgay.Value = Convert.ToDateTime(row.Cells["HanTra"].Value);

            // Ghi chú
            txt_Note.Text = row.Cells["GhiChu"].Value?.ToString() ?? "";

            string loai = row.Cells["Loai"].Value.ToString();
            if (loai == "Đi vay") rb_ToiVay.Checked = true;
            else rb_ToiChoMuon.Checked = true;

            cbo_TaiKhoan.Text = row.Cells["TaiKhoan"].Value.ToString();

            // TÍNH LẠI CÔNG THỨC TIỀN THANH TOÁN
            decimal tienDaTra = Convert.ToDecimal(row.Cells["TienDaTra"].Value);
            decimal soTienGoc = Convert.ToDecimal(row.Cells["SoTien"].Value);
            float laiSuat = Convert.ToSingle(row.Cells["LaiSuat"].Value);

            // KHÓA LOGIC BẢO VỆ DỮ LIỆU
            rb_ToiVay.Enabled = false; // Luôn khóa loại vay khi cập nhật
            rb_ToiChoMuon.Enabled = false;
            cbo_TaiKhoan.Enabled = (tienDaTra == 0); // Chỉ cho phép đổi ví nếu CHƯA TRẢ ĐỒNG NÀO
            txt_TienThanhToan.Enabled = true;

            // Tính lãi suất dựa trên THỜI GIAN THỰC TẾ (Từ lúc vay đến Hôm nay)
            DateTime ngayVay = dtp_TuNgay.Value.Date;
            double soNgayVayThucTe = (DateTime.Now.Date - ngayVay).TotalDays;
            if (soNgayVayThucTe <= 0) soNgayVayThucTe = 1;
            decimal soThang = (decimal)(soNgayVayThucTe / 30.0);

            decimal tienLai = Math.Round(soTienGoc * (decimal)(laiSuat / 100.0) * soThang, 0);
            decimal tongNo = soTienGoc + tienLai;
            decimal conLai = tongNo - tienDaTra;

            txt_TienCanThanhToan.Text = conLai.ToString("N0");
            txt_TienThanhToan.Text = conLai.ToString("N0");
        }

        //  CRUD BUTTONS
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Ten.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập Tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txt_Tien.Text.Trim(), out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền phải là số hợp lệ và lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float laiSuat = 0;
            if (!string.IsNullOrEmpty(txt_LaiSuat.Text) && !float.TryParse(txt_LaiSuat.Text.Trim(), out laiSuat))
            {
                MessageBox.Show("Lãi suất không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiVay = rb_ToiVay.Checked ? "Đi vay" : "Cho mượn";
            string maTK = cbo_TaiKhoan.SelectedValue.ToString();

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    var viNguon = db.Accounts.SingleOrDefault(a => a.AccountID == maTK);
                    if (viNguon == null) return;

                    if (loaiVay == "Cho mượn" && soTien > viNguon.Balance)
                    {
                        MessageBox.Show($"Tài khoản này chỉ còn {viNguon.Balance.Value:N0} VNĐ.\nBạn không đủ tiền để cho mượn khoản này!",
                                        "Thiếu tiền", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    // Tự động sinh mã ID (DEB001, DEB002...)
                    string newDebtID = "DEB001";
                    var listIDs = db.Debts.Where(de => de.DebtID.StartsWith("DEB")).Select(de => de.DebtID).ToList();
                    if (listIDs.Count > 0)
                    {
                        int maxNum = listIDs.Max(id => int.TryParse(id.Substring(3), out int num) ? num : 0);
                        newDebtID = "DEB" + (maxNum + 1).ToString("D3");
                    }

                    Debt d = new Debt();
                    d.DebtID = newDebtID;
                    d.UserID = currentUserID;
                    d.AccountID = maTK;
                    d.PersonName = txt_Ten.Text.Trim();
                    d.Amount = soTien;
                    d.InterestRate = laiSuat;
                    d.StartDate = dtp_TuNgay.Value.Date;
                    d.DueDate = dtp_DenNgay.Value.Date;
                    d.DebtType = loaiVay;
                    d.Status = "Active"; // Mặc định là chưa trả

                    // Đi vay thì Tăng tiền ví, Cho mượn thì Giảm tiền ví
                    if (loaiVay == "Đi vay") viNguon.Balance += soTien;
                    else viNguon.Balance -= soTien;

                    // LOGIC TỰ ĐỘNG TÌM HOẶC TẠO DANH MỤC CHO GIAO DỊCH VAY NỢ
                    string tenDanhMucAuto = (loaiVay == "Đi vay") ? "Đi vay" : "Cho mượn";
                    string loaiDanhMucAuto = (loaiVay == "Đi vay") ? "Income" : "Expense";
                    string assignedCategoryID = "";

                    // Kiểm tra xem danh mục "Đi vay" / "Cho mượn" này đã tồn tại trong CSDL của User chưa
                    var cat = db.Categories.FirstOrDefault(c => c.UserID == currentUserID
                                                             && c.CategoryName == tenDanhMucAuto
                                                             && c.CategoryType == loaiDanhMucAuto);

                    if (cat != null)
                    {
                        // Nếu đã có, lấy mã của nó ra dùng
                        assignedCategoryID = cat.CategoryID;
                    }
                    else
                    {
                        // Nếu chưa có, TỰ ĐỘNG TẠO MỚI danh mục này (mã C001, C002...)
                        assignedCategoryID = "C001";
                        var listCatIDs = db.Categories.Where(c => c.CategoryID.StartsWith("C")).Select(c => c.CategoryID).ToList();
                        if (listCatIDs.Count > 0)
                        {
                            // Lưu ý: Chuỗi bắt đầu bằng "C" nên lấy từ vị trí index 1 để cắt số (VD: "C005" -> cắt lấy "005")
                            int maxCatNum = listCatIDs.Max(id => id.Length > 1 && int.TryParse(id.Substring(1), out int num) ? num : 0);
                            assignedCategoryID = "C" + (maxCatNum + 1).ToString("D3");
                        }

                        Category newCat = new Category
                        {
                            CategoryID = assignedCategoryID,
                            UserID = currentUserID,
                            CategoryName = tenDanhMucAuto,
                            CategoryType = loaiDanhMucAuto,
                            Note = "Hệ thống tự động tạo cho nghiệp vụ Vay/Cho vay"
                        };
                        db.Categories.InsertOnSubmit(newCat);
                        // Hệ thống sẽ lưu Category này cùng lúc với Debt và Transaction ở lệnh SubmitChanges cuối cùng
                    }

                    // TỰ ĐỘNG SINH GIAO DỊCH (TRANSACTION) KHI THÊM KHOẢN VAY
                    string newTransID = "TXN0001";
                    var listTransIDs = db.Transactions.Where(tx => tx.TransID.StartsWith("TXN")).Select(tx => tx.TransID).ToList();
                    if (listTransIDs.Count > 0)
                    {
                        int maxNum = listTransIDs.Max(id => id.Length > 3 && int.TryParse(id.Substring(3), out int num) ? num : 0);
                        newTransID = "TXN" + (maxNum + 1).ToString("D4");
                    }

                    Transaction tThem = new Transaction
                    {
                        TransID = newTransID,
                        UserID = currentUserID,
                        AccountID = maTK,
                        DebtID = newDebtID,
                        CategoryID = assignedCategoryID, // <--- Đã gắn ID danh mục tự động vào đây thay vì null

                        TransType = loaiDanhMucAuto, // Income hoặc Expense
                        Amount = soTien,
                        TransDate = dtp_TuNgay.Value.Date,
                        Note = (loaiVay == "Đi vay" ? "Đi vay tiền từ: " : "Cho mượn tiền: ") + txt_Ten.Text.Trim()
                    };

                    db.Debts.InsertOnSubmit(d);
                    db.Transactions.InsertOnSubmit(tThem);
                    db.SubmitChanges(); // Lưu toàn bộ 3 bảng (Debt, Transaction, Category nếu có) xuống CSDL cùng lúc

                    MessageBox.Show("Thêm khoản vay/cho vay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    btn_Reset.PerformClick();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDebtlID)) return;
            if (!decimal.TryParse(txt_Tien.Text.Trim(), out decimal soTien) || soTien <= 0) return;
            float.TryParse(txt_LaiSuat.Text.Trim(), out float laiSuat);

            string maTKMoi = cbo_TaiKhoan.SelectedValue.ToString();

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var d = db.Debts.SingleOrDefault(x => x.DebtID == currentDebtlID);
                if (d != null)
                {
                    if (d.Status == "Finished")
                    {
                        MessageBox.Show("Khoản này đã tất toán, không thể sửa đổi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // KIỂM TRA LOGIC TIỀN GỐC
                    if (d.PaidAmount > 0 && soTien < d.PaidAmount)
                    {
                        MessageBox.Show($"Đối tác đã trả {d.PaidAmount:N0} VNĐ. Bạn không thể sửa số tiền gốc nhỏ hơn số tiền đã trả!", "Vô lý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var originalTrans = db.Transactions.FirstOrDefault(t => t.DebtID == currentDebtlID && (t.TransType == "Income" || t.TransType == "Expense"));

                    // Hạch toán lại ví (Nếu có đổi ví - Tất nhiên chỉ xảy ra khi PaidAmount == 0)
                    if (maTKMoi != d.AccountID)
                    {
                        var oldAcc = db.Accounts.SingleOrDefault(a => a.AccountID == d.AccountID);
                        var newAcc = db.Accounts.SingleOrDefault(a => a.AccountID == maTKMoi);

                        if (oldAcc != null && newAcc != null)
                        {
                            if (d.DebtType == "Cho mượn" && soTien > newAcc.Balance)
                            {
                                MessageBox.Show("Ví mới không đủ tiền để cấp khoản cho mượn này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            // Hoàn tiền ví cũ
                            if (d.DebtType == "Đi vay") oldAcc.Balance -= d.Amount;
                            else oldAcc.Balance += d.Amount;

                            // Trừ/Cộng tiền ví mới
                            if (d.DebtType == "Đi vay") newAcc.Balance += soTien;
                            else newAcc.Balance -= soTien;
                        }
                    }
                    else
                    {
                        // Nếu giữ nguyên ví, chỉ cần bù trừ khoảng chênh lệch
                        var acc = db.Accounts.SingleOrDefault(a => a.AccountID == d.AccountID);
                        decimal chenhLech = soTien - d.Amount; // Ví dụ: sửa từ 10tr -> 12tr (Chênh 2tr)
                        if (d.DebtType == "Đi vay") acc.Balance += chenhLech;
                        else acc.Balance -= chenhLech;
                    }

                    // Cập nhật Database
                    if (originalTrans != null)
                    {
                        originalTrans.AccountID = maTKMoi;
                        originalTrans.Amount = soTien;
                        originalTrans.Note = (d.DebtType == "Đi vay" ? "Đi vay tiền từ: " : "Cho mượn tiền: ") + txt_Ten.Text.Trim() + " - Ghi chú: " + txt_Note.Text.Trim();
                    }

                    d.AccountID = maTKMoi;
                    d.PersonName = txt_Ten.Text.Trim();
                    d.Amount = soTien;
                    d.InterestRate = laiSuat;
                    d.StartDate = dtp_TuNgay.Value.Date;
                    d.DueDate = dtp_DenNgay.Value.Date;

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    currentDebtlID = "";
                    LoadData();
                    btn_Reset.PerformClick();
                }
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDebtlID)) return;

            // Lấy số tiền (Xóa cả phẩy và chấm để tránh lỗi format)
            string strTienTra = txt_TienThanhToan.Text.Replace(",", "").Replace(".", "");
            if (!decimal.TryParse(strTienTra, out decimal tienThanhToan) || tienThanhToan <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền thanh toán hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Xác nhận thanh toán số tiền {tienThanhToan:N0} VNĐ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var d = db.Debts.SingleOrDefault(x => x.DebtID == currentDebtlID);
                    if (d != null && d.Status == "Active")
                    {
                        var acc = db.Accounts.SingleOrDefault(a => a.AccountID == cbo_TaiKhoan.SelectedValue.ToString());
                        if (acc == null) return;

                        // TÍNH LÃI SUẤT DỰA TRÊN NGÀY THỰC TẾ
                        DateTime ngayVay = d.StartDate ?? DateTime.Now;
                        double soNgayVayThucTe = (DateTime.Now.Date - ngayVay.Date).TotalDays;
                        if (soNgayVayThucTe <= 0) soNgayVayThucTe = 1;

                        decimal soThang = (decimal)(soNgayVayThucTe / 30.0);
                        decimal tienLai = Math.Round(d.Amount * (decimal)(d.InterestRate / 100.0) * soThang, 0);

                        decimal tongNo = d.Amount + tienLai;
                        decimal tienConLai = Math.Round(tongNo - d.PaidAmount, 0);

                        if (tienThanhToan > tienConLai)
                        {
                            MessageBox.Show($"Chỉ còn nợ {tienConLai:N0} VNĐ. Bạn không thể thanh toán dư được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // HẠCH TOÁN TIỀN VÀO VÍ
                        if (d.DebtType == "Đi vay")
                        {
                            if (acc.Balance < tienThanhToan)
                            {
                                MessageBox.Show("Ví của bạn không đủ tiền để trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            acc.Balance -= tienThanhToan;
                        }
                        else if (d.DebtType == "Cho mượn")
                        {
                            acc.Balance += tienThanhToan;
                        }

                        // LOGIC TỰ ĐỘNG TÌM HOẶC TẠO DANH MỤC CHO THANH TOÁN
                        // Đi vay -> Giờ mình lấy tiền trả ngta -> Trả nợ (Expense)
                        // Cho mượn -> Giờ mình thu tiền về -> Thu nợ (Income)
                        string tenDanhMucAuto = (d.DebtType == "Đi vay") ? "Trả nợ" : "Thu nợ";
                        string loaiDanhMucAuto = (d.DebtType == "Đi vay") ? "Expense" : "Income";
                        string assignedCategoryID = "";

                        var cat = db.Categories.FirstOrDefault(c => c.UserID == currentUserID
                                                                 && c.CategoryName == tenDanhMucAuto
                                                                 && c.CategoryType == loaiDanhMucAuto);
                        if (cat != null)
                        {
                            assignedCategoryID = cat.CategoryID;
                        }
                        else
                        {
                            // Tạo mới danh mục nếu chưa có
                            assignedCategoryID = "C001";
                            var listCatIDs = db.Categories.Where(c => c.CategoryID.StartsWith("C")).Select(c => c.CategoryID).ToList();
                            if (listCatIDs.Count > 0)
                            {
                                int maxCatNum = listCatIDs.Max(id => id.Length > 1 && int.TryParse(id.Substring(1), out int num) ? num : 0);
                                assignedCategoryID = "C" + (maxCatNum + 1).ToString("D3");
                            }

                            Category newCat = new Category
                            {
                                CategoryID = assignedCategoryID,
                                UserID = currentUserID,
                                CategoryName = tenDanhMucAuto,
                                CategoryType = loaiDanhMucAuto,
                                Note = "Hệ thống tự động tạo cho nghiệp vụ Thanh toán nợ"
                            };
                            db.Categories.InsertOnSubmit(newCat);
                        }

                        // TẠO GIAO DỊCH (TRANSACTION)
                        string newTransID = "TXN0001";
                        var listTransIDs = db.Transactions.Where(tx => tx.TransID.StartsWith("TXN")).Select(tx => tx.TransID).ToList();
                        if (listTransIDs.Count > 0)
                        {
                            int maxNum = listTransIDs.Max(id => id.Length > 3 && int.TryParse(id.Substring(3), out int num) ? num : 0);
                            newTransID = "TXN" + (maxNum + 1).ToString("D4");
                        }

                        Transaction tTraNo = new Transaction
                        {
                            TransID = newTransID,
                            UserID = currentUserID,
                            AccountID = acc.AccountID,
                            DebtID = d.DebtID,
                            CategoryID = assignedCategoryID, // <-- Gắn mã danh mục tự động vào đây
                            TransType = loaiDanhMucAuto,     // Expense hoặc Income chuẩn xác
                            Amount = tienThanhToan,
                            TransDate = DateTime.Now.Date,
                            Note = (d.DebtType == "Đi vay" ? "Trả nợ cho: " : "Thu nợ từ: ") + d.PersonName
                        };
                        db.Transactions.InsertOnSubmit(tTraNo);

                        // CẬP NHẬT KHOẢN NỢ & CHỐT SỔ
                        d.PaidAmount += tienThanhToan;

                        // Tránh sai số do làm tròn, nếu số dư còn lại < 1 VNĐ thì coi như tất toán
                        if ((tongNo - d.PaidAmount) < 1)
                        {
                            d.Status = "Finished";
                            d.PaidAmount = tongNo;
                            MessageBox.Show("Khoản nợ này đã được TẤT TOÁN toàn bộ!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Đưa thông báo trả góp vào ĐÚNG CHỖ (bên trong block kiểm tra d != null)
                            MessageBox.Show($"Đã ghi nhận thanh toán {tienThanhToan:N0} VNĐ.\nCòn nợ: {(tongNo - d.PaidAmount):N0} VNĐ", "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        db.SubmitChanges(); // Lưu toàn bộ (Danh mục mới, Giao dịch, Cập nhật nợ) 

                        txt_TienThanhToan.Clear();
                        txt_TienCanThanhToan.Clear();
                        currentDebtlID = "";
                        LoadData();
                        btn_Reset.PerformClick();
                    }
                }
            }
        }


        private void btn_Reset_Click(object sender, EventArgs e)
        {
            currentDebtlID = "";
            txt_Ten.Clear();
            txt_Tien.Clear();
            txt_LaiSuat.Clear();
            txt_Note.Clear();
            txt_TienCanThanhToan.Clear();
            txt_TienThanhToan.Clear();
            txt_TienThanhToan.Enabled = false;
            dtp_TuNgay.Value = DateTime.Now;
            dtp_DenNgay.Value = DateTime.Now;
            if (cbo_TaiKhoan.Items.Count > 0)
                cbo_TaiKhoan.SelectedIndex = 0;
            rb_TatCa.Checked = true;
            rb_ToiVay.Checked = true;

            // MỞ KHÓA LẠI CÁC CONTROL
            rb_ToiVay.Enabled = true;
            rb_ToiChoMuon.Enabled = true;
            cbo_TaiKhoan.Enabled = true;
        }

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            FrmMainMenu frmMenu = Application.OpenForms.OfType<FrmMainMenu>().FirstOrDefault();
            if (frmMenu != null) frmMenu.RefreshMenu();

            FrmTaiKhoan frmTK = Application.OpenForms.OfType<FrmTaiKhoan>().FirstOrDefault();
            if (frmTK != null) frmTK.RefreshTaiKhoan();

            FrmThongKe frmTK2 = Application.OpenForms.OfType<FrmThongKe>().FirstOrDefault();
            if (frmTK2 != null) frmTK2.RefreshThongKe();

            FrmGiaoDich frmGD = Application.OpenForms.OfType<FrmGiaoDich>().FirstOrDefault();
            if (frmGD != null) frmGD.RefreshGiaoDich();

            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentDebtlID))
            {
                MessageBox.Show("Vui lòng chọn một khoản vay/nợ để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ khoản vay này không?\nTất cả lịch sử thanh toán liên quan sẽ bị xóa và số tiền sẽ được hoàn lại vào ví.", "Cảnh báo nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var d = db.Debts.SingleOrDefault(x => x.DebtID == currentDebtlID);
                    if (d != null)
                    {
                        // Tìm tất cả các giao dịch liên quan (Gồm giao dịch tạo khoản vay và các lần thanh toán)
                        var relatedTrans = db.Transactions.Where(t => t.DebtID == currentDebtlID).ToList();

                        foreach (var t in relatedTrans)
                        {
                            var acc = db.Accounts.SingleOrDefault(a => a.AccountID == t.AccountID);
                            if (acc != null)
                            {
                                // ĐẢO NGƯỢC DÒNG TIỀN
                                // Nếu trước đây giao dịch đó cộng tiền (Income) thì giờ trừ đi.
                                if (t.TransType == "Income") acc.Balance -= t.Amount;
                                else if (t.TransType == "Expense") acc.Balance += t.Amount;
                            }
                            db.Transactions.DeleteOnSubmit(t);
                        }

                        db.Debts.DeleteOnSubmit(d);
                        db.SubmitChanges();

                        MessageBox.Show("Đã xóa khoản vay và hoàn tất thu hồi dòng tiền!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_Reset.PerformClick();
                        LoadData();
                    }
                }
            }
        }
    }
}