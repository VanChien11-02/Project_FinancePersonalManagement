using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_FinancePersonalManagement.Data;

namespace Project_FinancePersonalManagement
{
    public partial class FrmVayNo : Form
    {
        private string currentUserID;
        private string currentDebtlID;
        public FrmVayNo(string UserID)
        {
            InitializeComponent();
            currentUserID = UserID;
        }

        private void LoadData()
        {
            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                try
                {
                    // NẠP COMBOBOX TÀI KHOẢN
                    if (cbo_TaiKhoan.DataSource == null)
                    {
                        var tkList = db.Accounts.Where(a => a.UserID == currentUserID).ToList();
                        cbo_TaiKhoan.DataSource = tkList;
                        cbo_TaiKhoan.DisplayMember = "AccountName";
                        cbo_TaiKhoan.ValueMember = "AccountID";
                    }

                    // KÉO DỮ LIỆU VÀ LỌC THEO RADIO BUTTON
                    var query = from d in db.Debts
                                join a in db.Accounts on d.AccountID equals a.AccountID
                                where d.UserID == currentUserID
                                select new { d, a };

                    if (rb_ChoMuon.Checked)
                        query = query.Where(x => x.d.DebtType == "Cho mượn");
                    else if (rb_DiVay.Checked)
                        query = query.Where(x => x.d.DebtType == "Đi vay");

                    // ĐỔ DỮ LIỆU LÊN BẢNG
                    var dsVayNo = query.OrderByDescending(x => x.d.StartDate)
                                       .Select(x => new
                                       {
                                           MaVay = x.d.DebtID,
                                           Loai = x.d.DebtType,
                                           Ten = x.d.PersonName,
                                           SoTien = x.d.Amount,
                                           LaiSuat = x.d.InterestRate,
                                           TienDaTra = x.d.PaidAmount,
                                           NgayVay = x.d.StartDate,
                                           HanTra = x.d.DueDate,
                                           TrangThai = x.d.Status == "Active" ? "Chưa thanh toán" : "Đã hoàn thành",
                                           TaiKhoan = x.a.AccountName
                                       }).ToList();

                    dgv_dsVayMuon.DataSource = null;
                    dgv_dsVayMuon.Columns.Clear();
                    dgv_dsVayMuon.DataSource = dsVayNo;

                    if (dgv_dsVayMuon.Columns.Count > 0)
                    {
                        //dgv_dsVayMuon.Columns["MaVay"].Visible = false;
                        dgv_dsVayMuon.Columns["MaVay"].HeaderText = "Mã khoản vay";
                        dgv_dsVayMuon.Columns["Loai"].HeaderText = "Loại";
                        dgv_dsVayMuon.Columns["Ten"].HeaderText = "Đối tác";
                        dgv_dsVayMuon.Columns["SoTien"].HeaderText = "Số tiền";
                        dgv_dsVayMuon.Columns["SoTien"].DefaultCellStyle.Format = "N0";
                        dgv_dsVayMuon.Columns["LaiSuat"].HeaderText = "Lãi suất (%)";
                        dgv_dsVayMuon.Columns["TienDaTra"].HeaderText = "Số tiền đã trả";
                        dgv_dsVayMuon.Columns["NgayVay"].HeaderText = "Ngày vay";
                        dgv_dsVayMuon.Columns["NgayVay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgv_dsVayMuon.Columns["HanTra"].HeaderText = "Hạn trả";
                        dgv_dsVayMuon.Columns["HanTra"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgv_dsVayMuon.Columns["TrangThai"].HeaderText = "Trạng thái";
                        dgv_dsVayMuon.Columns["TaiKhoan"].HeaderText = "Tài khoản";
                    }

                    // TÍNH TỔNG TIỀN (Chỉ tính những khoản 'Active')
                    var listActive = db.Debts.Where(d => d.UserID == currentUserID && d.Status == "Active").ToList();

                    decimal tongToiNo = listActive.Where(d => d.DebtType == "Đi vay").Sum(d => d.Amount);
                    decimal tongNguoiNoToi = listActive.Where(d => d.DebtType == "Cho mượn").Sum(d => d.Amount);

                    lblTotal_No.Text = $"{tongToiNo:N0} VNĐ";
                    lblTotal_ChoMuon.Text = $"{tongNguoiNoToi:N0} VNĐ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
            LoadData();
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
            
            FrmGiaoDich form_GiaoDich = Application.OpenForms.OfType<FrmGiaoDich>().FirstOrDefault();
            if (form_GiaoDich != null)
            {
                form_GiaoDich.RefreshGiaoDich();
            }
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Ten.Clear();
            txt_Tien.Clear();
            txt_LaiSuat.Clear();
            txt_Note.Clear();
            txt_TienCanThanhToan.Clear();
            txt_TienThanhToan.Clear();
            txt_SoDu.Clear();
            txt_TienThanhToan.Enabled = false;
            dtp_TuNgay.Value = DateTime.Now;
            dtp_DenNgay.Value = DateTime.Now;
            cbo_TaiKhoan.SelectedIndex = 0;
            rb_TatCa.Checked = true;
            rb_ToiVay.Checked = true;
        }

        private void dgv_dsVayMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_TienThanhToan.Enabled = true;
                DataGridViewRow row = dgv_dsVayMuon.Rows[e.RowIndex];

                // Lưu ngầm Mã khoản vay
                currentDebtlID = row.Cells["MaVay"].Value.ToString();

                // Đổ dữ liệu lên UI
                txt_Ten.Text = row.Cells["Ten"].Value.ToString();
                txt_Tien.Text = row.Cells["SoTien"].Value.ToString();
                txt_LaiSuat.Text = row.Cells["LaiSuat"].Value.ToString();
                dtp_TuNgay.Value = Convert.ToDateTime(row.Cells["NgayVay"].Value);

                if (row.Cells["HanTra"].Value != DBNull.Value && row.Cells["HanTra"].Value != null)
                    dtp_DenNgay.Value = Convert.ToDateTime(row.Cells["HanTra"].Value);

                string loai = row.Cells["Loai"].Value.ToString();
                if (loai == "Đi vay") rb_ToiVay.Checked = true;
                else rb_ToiChoMuon.Checked = true;

                cbo_TaiKhoan.Text = row.Cells["TaiKhoan"].Value.ToString();

                using (AppDatabaseDataContext db = new AppDatabaseDataContext())
                {
                    var d = db.Debts.SingleOrDefault(x => x.DebtID == currentDebtlID);
                    if (d != null)
                    {
                        // Thêm Math.Round để làm tròn số nguyên ngay từ lúc tính lãi
                        decimal tienLai = Math.Round(d.Amount * (decimal)(d.InterestRate / 100.0), 0);
                        decimal tongNo = d.Amount + tienLai;

                        decimal tienConLai = tongNo - d.PaidAmount;

                        txt_TienCanThanhToan.Text = tienConLai.ToString("N0");
                        txt_TienThanhToan.Text = tienConLai.ToString("N0");
                    }
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
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

                    // Kiểm tra: Nếu cho mượn mà ví không đủ tiền thì chặn lại
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

                    string newTransID = "TXN0001";
                    var listTransIDs = db.Transactions.Where(tx => tx.TransID.StartsWith("TXN")).Select(tx => tx.TransID).ToList();
                    if (listTransIDs.Count > 0)
                    {
                        int maxNum = listTransIDs.Max(id => int.TryParse(id.Substring(3), out int num) ? num : 0);
                        newTransID = "TXN" + (maxNum + 1).ToString("D4");
                    }

                    // TỰ ĐỘNG SINH GIAO DỊCH (TRANSACTION) KHI THÊM KHOẢN VAY
                    Transaction tThem = new Transaction();
                    tThem.TransID = newTransID;
                    tThem.UserID = currentUserID;
                    tThem.AccountID = maTK;
                    tThem.DebtID = newDebtID; // Gắn ID khoản vay vào để liên kết (Khóa ngoại)
                    tThem.CategoryID = null; // Bỏ qua danh mục vì đây là nghiệp vụ vay nợ

                    // Đi vay -> Tiền vào ví -> Income. Cho mượn -> Tiền ra khỏi ví -> Expense
                    tThem.TransType = (loaiVay == "Đi vay") ? "Income" : "Expense";
                    tThem.Amount = soTien;
                    tThem.TransDate = dtp_TuNgay.Value.Date;
                    tThem.Note = (loaiVay == "Đi vay" ? "Đi vay tiền từ: " : "Cho mượn tiền: ") + txt_Ten.Text.Trim();

                    db.Debts.InsertOnSubmit(d);
                    db.Transactions.InsertOnSubmit(tThem);
                    db.SubmitChanges();

                    MessageBox.Show("Thêm khoản vay/cho vay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Load lại bảng

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
            string loaiVayMoi = rb_ToiVay.Checked ? "Đi vay" : "Cho mượn";
            string maTKMoi = cbo_TaiKhoan.SelectedValue.ToString();

            using (AppDatabaseDataContext db = new AppDatabaseDataContext())
            {
                var d = db.Debts.SingleOrDefault(x => x.DebtID == currentDebtlID);
                if (d != null)
                {
                    // Không cho phép sửa nếu đã thanh toán xong
                    if (d.Status == "Finished")
                    {
                        MessageBox.Show("Khoản này đã tất toán (Finished), không thể sửa đổi số tiền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // BƯỚC A: Hoàn tiền của record CŨ
                    var oldAcc = db.Accounts.SingleOrDefault(a => a.AccountID == d.AccountID);
                    if (oldAcc != null)
                    {
                        if (d.DebtType == "Đi vay") oldAcc.Balance -= d.Amount;
                        else oldAcc.Balance += d.Amount;
                    }

                    // BƯỚC B: Tính toán tiền cho record MỚI
                    var newAcc = db.Accounts.SingleOrDefault(a => a.AccountID == maTKMoi);
                    if (newAcc != null)
                    {
                        if (loaiVayMoi == "Cho mượn" && soTien > newAcc.Balance)
                        {
                            MessageBox.Show("Ví mới không đủ tiền để cập nhật khoản cho mượn này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Dừng, không cho lưu
                        }

                        if (loaiVayMoi == "Đi vay") newAcc.Balance += soTien;
                        else newAcc.Balance -= soTien;
                    }

                    // BƯỚC C: Cập nhật CSDL
                    d.AccountID = maTKMoi;
                    d.PersonName = txt_Ten.Text.Trim();
                    d.Amount = soTien;
                    d.InterestRate = laiSuat;
                    d.StartDate = dtp_TuNgay.Value.Date;
                    d.DueDate = dtp_DenNgay.Value.Date;
                    d.DebtType = loaiVayMoi;

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

                        // ÍNH TOÁN LÀM TRÒN SỐ
                        decimal tienLai = Math.Round(d.Amount * (decimal)(d.InterestRate / 100.0), 0);
                        decimal tongNo = d.Amount + tienLai;
                        decimal tienConLai = Math.Round(tongNo - d.PaidAmount, 0);

                        if (tienThanhToan > tienConLai)
                        {
                            MessageBox.Show($"Chỉ còn nợ {tienConLai:N0} VNĐ. Bạn không thể thanh toán dư được!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // HẠCH TOÁN VÀO VÍ
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

                        string newTransID = "TXN0001";
                        // Lọc chuẩn xác tiền tố TXN
                        var listTransIDs = db.Transactions.Where(tx => tx.TransID.StartsWith("TXN")).Select(tx => tx.TransID).ToList();
                        if (listTransIDs.Count > 0)
                        {
                            int maxNum = listTransIDs.Max(id => int.TryParse(id.Substring(3), out int num) ? num : 0);
                            newTransID = "TXN" + (maxNum + 1).ToString("D4");
                        }

                        Transaction tTraNo = new Transaction();
                        tTraNo.TransID = newTransID;
                        tTraNo.UserID = currentUserID;
                        tTraNo.AccountID = acc.AccountID;
                        tTraNo.DebtID = d.DebtID;
                        tTraNo.CategoryID = null;
                        tTraNo.TransType = (d.DebtType == "Đi vay") ? "Expense" : "Income";
                        tTraNo.Amount = tienThanhToan;
                        tTraNo.TransDate = DateTime.Now.Date;
                        tTraNo.Note = (d.DebtType == "Đi vay" ? "Trả nợ cho: " : "Thu nợ từ: ") + d.PersonName;

                        db.Transactions.InsertOnSubmit(tTraNo);

                        // CẬP NHẬT KHOẢN NỢ & CHỐT SỔ
                        d.PaidAmount += tienThanhToan;

                        // Tránh sai số do làm tròn, nếu số dư còn lại < 1 VNĐ thì coi như tất toán
                        if ((tongNo - d.PaidAmount) < 1)
                        {
                            d.Status = "Finished";
                            d.PaidAmount = tongNo; // Ép chuẩn lại số dư
                            MessageBox.Show("Khoản nợ này đã được TẤT TOÁN toàn bộ!", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Đã ghi nhận thanh toán {tienThanhToan:N0} VNĐ.", "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        db.SubmitChanges();
                        txt_TienThanhToan.Clear();
                        txt_TienCanThanhToan.Clear();
                        currentDebtlID = "";
                        LoadData();
                        btn_Reset.PerformClick();
                    }
                }
            }
        }

        private void rb_TatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_TatCa.Checked)
            {
                lbl_title.Text = "danh sách vay/cho vay";
                LoadData();
            }
        }

        private void rb_DiVay_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_DiVay.Checked)
            {
                lbl_title.Text = "danh sách vay";
                LoadData();
            }
        }

        private void rb_ChoMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_ChoMuon.Checked)
            {
                lbl_title.Text = "danh sách cho mượn";
                LoadData();
            }
        }

        private void dgv_dsVayMuon_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_dsVayMuon.Rows)
            {
                string trangThai = row.Cells["TrangThai"].Value?.ToString();

                // Nếu đã trả xong -> TÔ MÀU XANH LÁ
                if (trangThai == "Đã hoàn thành")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else // Đang Active (Chưa thanh toán)
                {
                    // Lấy ngày Hạn trả ra để tính toán
                    DateTime hanTra = Convert.ToDateTime(row.Cells["HanTra"].Value);

                    // Tính số ngày còn lại (Hạn trả trừ đi Ngày hôm nay)
                    TimeSpan timeLeft = hanTra.Date - DateTime.Now.Date;

                    // Nếu số ngày còn lại <= 3 ngày (mà chưa trả) -> TÔ MÀU CAM (Sắp đến hạn hoặc Quá hạn)
                    if (timeLeft.TotalDays <= 3)
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                    }
                    // Còn dài ngày hơn 3 ngày -> TÔ MÀU ĐỎ NHẠT (Active bình thường)
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
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
    }
}
