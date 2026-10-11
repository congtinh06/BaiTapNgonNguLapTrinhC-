using System.ComponentModel;
using System.Globalization;

namespace Bai4;

public partial class frmBai4 : Form
{
    // Bảng giá theo đề
    private const long GiaTienNghi = 10000;   // mỗi tiện nghi, tính một lần cho cả kỳ ở
    private const long GiaKaraoke = 50000;    // một lần
    private const long GiaAnSang = 15000;     // mỗi ngày

    private readonly Dictionary<RadioButton, long> giaPhong = new();

    // Đã bấm Thanh toán cho khách hiện tại chưa. Có rồi thì khóa lại, nếu không bấm
    // hai lần là cộng trùng một khách vào tổng.
    private bool daThanhToan;

    // Số liệu trong ngày, chờ bấm "Tổng Kết" mới ghi ra label và về 0.
    private long tongLuot;
    private long tongTien;

    public frmBai4()
    {
        InitializeComponent();

        giaPhong[rdoPhongDon] = 300000;
        giaPhong[rdoPhongDoi] = 350000;
        giaPhong[rdoPhongBa] = 400000;
    }

    private void frmBai4_Load(object? sender, EventArgs e)
    {
        DatLaiForm();
    }

    // ---------------------------------------------------------------- tiện ích dùng chung

    // Hình mẫu ghi "975000 VNĐ" (không có dấu chấm ngăn cách) nên mình làm giống vậy
    private static string DinhDangTien(long tien)
    {
        return tien + " VNĐ";
    }

    // Đưa form về trạng thái ban đầu. Dùng cho Form_Load và "Nhập mới".
    // Nút Tổng Kết chỉ mờ khi chưa có lượt nào để tổng kết: nếu trong ngày đã thanh toán
    // vài khách rồi mà bấm Nhập mới thì số liệu đó vẫn còn, nút phải giữ nguyên là sáng.
    private void DatLaiForm()
    {
        errorProvider1.Clear();
        txtHoTen.Clear();
        txtDiaChi.Clear();
        txtSoNgay.Clear();

        foreach (RadioButton r in grpLoaiPhong.Controls.OfType<RadioButton>())
            r.Checked = false;
        foreach (CheckBox c in grpTienNghi.Controls.OfType<CheckBox>())
            c.Checked = false;
        foreach (CheckBox c in grpDichVu.Controls.OfType<CheckBox>())
            c.Checked = false;

        lblThanhTien.Text = "";
        daThanhToan = false;
        pnlKhach.Enabled = true;

        btnThanhToan.Enabled = false;
        btnNhapMoi.Enabled = false;
        btnTongKet.Enabled = tongLuot > 0;

        ActiveControl = txtHoTen;
    }

    // Các hàm Loi... trả về câu báo lỗi, null là hợp lệ. Để một chỗ dùng cho hai việc:
    // bật/tắt nút Thanh toán (không báo gì) và báo lỗi bằng ErrorProvider.
    private string? LoiHoTen()
    {
        return string.IsNullOrWhiteSpace(txtHoTen.Text) ? "Họ và tên không được để trống" : null;
    }

    private string? LoiDiaChi()
    {
        return string.IsNullOrWhiteSpace(txtDiaChi.Text) ? "Địa chỉ không được để trống" : null;
    }

    private string? LoiSoNgay(out int soNgay)
    {
        soNgay = 0;
        string s = txtSoNgay.Text.Trim();

        if (s == "") return "Chưa nhập số ngày ở";
        // NumberStyles.None chỉ nhận chữ số: dán "-3" hay "2.5" vào đều bị loại
        if (!int.TryParse(s, NumberStyles.None, CultureInfo.InvariantCulture, out soNgay))
            return "Số ngày ở phải là số nguyên dương hợp lệ";
        if (soNgay <= 0) return "Số ngày ở phải lớn hơn 0";
        return null;
    }

    private bool DaChonPhong()
    {
        return grpLoaiPhong.Controls.OfType<RadioButton>().Any(r => r.Checked);
    }

    private void CapNhatNutThanhToan()
    {
        btnThanhToan.Enabled = !daThanhToan
            && LoiHoTen() == null && LoiDiaChi() == null && LoiSoNgay(out _) == null
            && DaChonPhong();
    }

    // Tiền phòng tính theo ngày. Tiện nghi: mỗi cái 10.000đ một lần. Karaoke 50.000đ một lần.
    // Ăn sáng 15.000đ mỗi ngày. (Khớp hình mẫu: phòng đơn, 3 ngày, 3 tiện nghi, ăn sáng = 975000.)
    private long TinhTien(int soNgay)
    {
        long tien = 0;

        foreach (RadioButton r in grpLoaiPhong.Controls.OfType<RadioButton>())
            if (r.Checked) tien += giaPhong[r] * soNgay;

        tien += grpTienNghi.Controls.OfType<CheckBox>().Count(c => c.Checked) * GiaTienNghi;

        if (chkKaraoke.Checked) tien += GiaKaraoke;
        if (chkAnSang.Checked) tien += GiaAnSang * soNgay;

        return tien;
    }

    // ---------------------------------------------------------------- nhập liệu

    // Dùng chung cho mọi ô nhập, radio, checkbox
    private void NhapLieu_Changed(object? sender, EventArgs e)
    {
        if (sender is TextBox tb) errorProvider1.SetError(tb, "");
        CapNhatNutThanhToan();
    }

    // Rời ô mà sai thì hiện biểu tượng lỗi, không giữ con trỏ lại (không set e.Cancel)
    // để người dùng vẫn bấm được Nhập mới hoặc Thoát.
    private void txtHoTen_Validating(object? sender, CancelEventArgs e)
    {
        errorProvider1.SetError(txtHoTen, LoiHoTen() ?? "");
    }

    private void txtDiaChi_Validating(object? sender, CancelEventArgs e)
    {
        errorProvider1.SetError(txtDiaChi, LoiDiaChi() ?? "");
    }

    private void txtSoNgay_Validating(object? sender, CancelEventArgs e)
    {
        errorProvider1.SetError(txtSoNgay, LoiSoNgay(out _) ?? "");
    }

    // Chỉ cho gõ chữ số. Dán bằng Ctrl+V lọt qua đây, nhưng LoiSoNgay vẫn bắt lại.
    private void txtSoNgay_KeyPress(object? sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (!char.IsControl(c) && !(c >= '0' && c <= '9'))
            e.Handled = true;
    }

    // ---------------------------------------------------------------- các nút

    private void btnThanhToan_Click(object? sender, EventArgs e)
    {
        // Kiểm tra lại cho chắc phòng khi dữ liệu dán vào làm nút sáng nhầm
        string? loiTen = LoiHoTen();
        string? loiDiaChi = LoiDiaChi();
        string? loiNgay = LoiSoNgay(out int soNgay);
        errorProvider1.SetError(txtHoTen, loiTen ?? "");
        errorProvider1.SetError(txtDiaChi, loiDiaChi ?? "");
        errorProvider1.SetError(txtSoNgay, loiNgay ?? "");
        if (loiTen != null || loiDiaChi != null || loiNgay != null) return;

        if (!DaChonPhong())
        {
            MessageBox.Show("Bạn chưa chọn loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        long tien = TinhTien(soNgay);
        lblThanhTien.Text = DinhDangTien(tien);

        tongLuot++;
        tongTien += tien;

        // Khóa phần nhập để dữ liệu trên màn hình luôn khớp với số tiền đã ghi
        daThanhToan = true;
        pnlKhach.Enabled = false;
        btnThanhToan.Enabled = false;
        btnNhapMoi.Enabled = true;
        btnTongKet.Enabled = true;
        ActiveControl = btnNhapMoi;
    }

    private void btnNhapMoi_Click(object? sender, EventArgs e)
    {
        DatLaiForm();
    }

    private void btnTongKet_Click(object? sender, EventArgs e)
    {
        lblSoLuot.Text = tongLuot.ToString();
        lblTongTien.Text = DinhDangTien(tongTien);

        // Ghi ra rồi thì đếm lại từ 0 cho đợt thống kê sau (đề yêu cầu vậy)
        tongLuot = 0;
        tongTien = 0;
        btnTongKet.Enabled = false;
    }

    // Nút Thoát chỉ đóng form, hỏi Yes/No nằm ở FormClosing nên bấm dấu X cũng được hỏi.
    private void btnThoat_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void frmBai4_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // Windows tắt máy thì đừng chặn, chỉ hỏi khi chính người dùng đóng
        if (e.CloseReason != CloseReason.UserClosing) return;

        string hoi = "Bạn có chắc chắn muốn thoát khỏi chương trình?";
        // Còn lượt chưa tổng kết thì nhắc luôn, tránh mất số liệu trong ngày
        if (tongLuot > 0)
            hoi = $"Còn {tongLuot} lượt trả phòng chưa tổng kết (tổng {DinhDangTien(tongTien)}).\n" + hoi;

        DialogResult tl = MessageBox.Show(hoi, "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (tl == DialogResult.No)
            e.Cancel = true;
    }
}