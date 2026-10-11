using System.ComponentModel;
using System.Globalization;

namespace Bai3;

public partial class frmBai3 : Form
{
    // Bảng giá gắn thẳng vào từng radio/checkbox. Đổi giá hay thêm món chỉ sửa ở đây,
    // mấy hàm tính tiền bên dưới cứ duyệt control là ra, không phải viết if từng món.
    private readonly Dictionary<Control, decimal> bangGia = new();

    private static readonly CultureInfo viVN = new CultureInfo("vi-VN");

    // Kết quả của lần "Tính tiền" gần nhất, chờ bấm "Thanh toán" mới cộng vào tổng
    private bool daTinhTien;
    private int soKhachHienTai;
    private decimal tienHienTai;

    // Tổng của cả ngày. Tiền dùng decimal để nhân 20% không bị lệch số lẻ.
    private long tongKhach;
    private decimal tongTien;

    public frmBai3()
    {
        InitializeComponent();

        bangGia[rdoCafeDen] = 20000m;
        bangGia[rdoCafeDa] = 25000m;
        bangGia[rdoCafeSua] = 25000m;
        bangGia[rdoCafeSuaDa] = 30000m;
        bangGia[rdoCafeKem] = 35000m;

        bangGia[chkBanhMyTrung] = 15000m;
        bangGia[chkBanhMyCa] = 15000m;
        bangGia[chkMyTomTrung] = 20000m;
        bangGia[chkMyXaoBo] = 30000m;
        bangGia[chkMyCay] = 50000m;
    }

    private void frmBai3_Load(object? sender, EventArgs e)
    {
        DatLaiForm();
    }

    // ---------------------------------------------------------------- tiện ích dùng chung

    private static string DinhDangTien(decimal tien)
    {
        return tien.ToString("N0", viVN) + "đ";
    }

    // Đưa form về như lúc vừa mở: xóa ô, bỏ chọn, 3 nút mờ, con trỏ ở ô tên.
    // Dùng chung cho Form_Load, "Nhập lại" và "Thanh toán" (xong một nhóm là sẵn sàng nhóm mới).
    // Hai ô tổng ở dưới không đụng tới vì đó là số liệu cả ngày.
    private void DatLaiForm()
    {
        errorProvider1.Clear();
        txtTenKH.Clear();
        txtSoKH.Clear();
        chkSinhVien.Checked = false;

        foreach (RadioButton r in grpNuocUong.Controls.OfType<RadioButton>())
            r.Checked = false;
        foreach (CheckBox c in grpThucAn.Controls.OfType<CheckBox>())
            c.Checked = false;

        daTinhTien = false;
        btnTinhTien.Enabled = false;
        btnNhapLai.Enabled = false;
        btnThanhToan.Enabled = false;

        ActiveControl = txtTenKH;
    }

    // Hai hàm kiểm tra trả về câu báo lỗi (null là hợp lệ). Tách riêng khỏi ErrorProvider
    // để dùng được ở hai chỗ: bật/tắt nút Tính tiền (im lặng) và báo lỗi cho người dùng.
    private string? LoiTen()
    {
        return string.IsNullOrWhiteSpace(txtTenKH.Text) ? "Tên khách hàng không được để trống" : null;
    }

    private string? LoiSoKhach(out int soKhach)
    {
        soKhach = 0;
        string s = txtSoKH.Text.Trim();

        if (s == "") return "Chưa nhập số khách hàng";
        // NumberStyles.None: chỉ nhận chữ số, dán "-5" hay "1.5" vào là bị loại
        if (!int.TryParse(s, NumberStyles.None, CultureInfo.InvariantCulture, out soKhach))
            return "Số khách hàng phải là số nguyên dương hợp lệ";
        if (soKhach <= 0) return "Số khách hàng phải lớn hơn 0";
        return null;
    }

    private bool DaChonNuoc()
    {
        return grpNuocUong.Controls.OfType<RadioButton>().Any(r => r.Checked);
    }

    private decimal LayTienNuoc(out string tenNuoc)
    {
        tenNuoc = "";
        foreach (RadioButton r in grpNuocUong.Controls.OfType<RadioButton>())
        {
            if (r.Checked)
            {
                tenNuoc = r.Text;
                return bangGia[r];
            }
        }
        return 0;
    }

    // Thức ăn là checkbox nên khách được gọi nhiều món, cộng dồn lại
    private decimal LayTienAn(List<string> dsMon)
    {
        decimal tong = 0;
        foreach (CheckBox c in grpThucAn.Controls.OfType<CheckBox>())
        {
            if (c.Checked)
            {
                tong += bangGia[c];
                dsMon.Add(c.Text);
            }
        }
        return tong;
    }

    // Nút Tính tiền chỉ sáng khi đã đủ: tên, số khách, và có chọn nước uống.
    // Thức ăn thì không bắt buộc (khách chỉ uống nước vẫn hợp lệ).
    private void CapNhatNutTinhTien()
    {
        btnTinhTien.Enabled = LoiTen() == null && LoiSoKhach(out _) == null && DaChonNuoc();
    }

    // ---------------------------------------------------------------- sự kiện nhập liệu

    // Dùng chung cho mọi ô nhập, radio, checkbox. Có thay đổi gì sau khi đã tính tiền thì
    // kết quả cũ không còn đúng, nên khóa "Thanh toán" lại, bắt tính tiền lại cho chắc.
    private void NhapLieu_Changed(object? sender, EventArgs e)
    {
        if (sender is TextBox tb) errorProvider1.SetError(tb, "");

        daTinhTien = false;
        btnThanhToan.Enabled = false;
        CapNhatNutTinhTien();
    }

    // Báo lỗi khi rời ô. Chỉ hiện biểu tượng, không giữ con trỏ lại (không set e.Cancel)
    // để người dùng muốn bấm Nhập lại hay Thoát vẫn được.
    private void txtTenKH_Validating(object? sender, CancelEventArgs e)
    {
        errorProvider1.SetError(txtTenKH, LoiTen() ?? "");
    }

    private void txtSoKH_Validating(object? sender, CancelEventArgs e)
    {
        errorProvider1.SetError(txtSoKH, LoiSoKhach(out _) ?? "");
    }

    // Số khách chỉ cho gõ chữ số. Dán bằng Ctrl+V thì lọt qua đây,
    // nhưng LoiSoKhach ở trên vẫn bắt lại.
    private void txtSoKH_KeyPress(object? sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (!char.IsControl(c) && !(c >= '0' && c <= '9'))
            e.Handled = true;
    }

    // ---------------------------------------------------------------- các nút

    private void btnTinhTien_Click(object? sender, EventArgs e)
    {
        // Kiểm tra lại một lần nữa phòng khi dữ liệu dán vào làm nút sáng nhầm
        string? loiTen = LoiTen();
        string? loiSo = LoiSoKhach(out int soKhach);
        errorProvider1.SetError(txtTenKH, loiTen ?? "");
        errorProvider1.SetError(txtSoKH, loiSo ?? "");
        if (loiTen != null || loiSo != null) return;

        if (!DaChonNuoc())
        {
            MessageBox.Show("Bạn chưa chọn loại nước uống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        decimal tienNuoc = LayTienNuoc(out string tenNuoc);
        List<string> dsMon = new List<string>();
        decimal tienAn = LayTienAn(dsMon);

        // Mỗi khách gọi giống nhau (cùng nước, cùng các món), nên nhân với số khách.
        // Sinh viên giảm 20% trên toàn bộ hóa đơn.
        decimal tamTinh = (tienNuoc + tienAn) * soKhach;
        decimal giam = chkSinhVien.Checked ? tamTinh * 0.2m : 0m;
        decimal phaiTra = tamTinh - giam;

        soKhachHienTai = soKhach;
        tienHienTai = phaiTra;
        daTinhTien = true;
        btnNhapLai.Enabled = true;
        btnThanhToan.Enabled = true;

        List<string> dong = new List<string>
        {
            $"Khách hàng: {txtTenKH.Text.Trim()}",
            $"Số khách: {soKhach}",
            $"Nước uống: {tenNuoc} ({DinhDangTien(tienNuoc)})",
            dsMon.Count == 0
                ? "Thức ăn: không gọi"
                : $"Thức ăn: {string.Join(", ", dsMon)} ({DinhDangTien(tienAn)})",
            $"Tạm tính ({DinhDangTien(tienNuoc + tienAn)} x {soKhach}): {DinhDangTien(tamTinh)}"
        };
        if (chkSinhVien.Checked)
            dong.Add($"Giảm 20% (sinh viên): -{DinhDangTien(giam)}");
        dong.Add($"THÀNH TIỀN: {DinhDangTien(phaiTra)}");

        MessageBox.Show(string.Join("\n", dong), "Tính tiền", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnNhapLai_Click(object? sender, EventArgs e)
    {
        DatLaiForm();
    }

    private void btnThanhToan_Click(object? sender, EventArgs e)
    {
        if (!daTinhTien) return;

        tongKhach += soKhachHienTai;
        tongTien += tienHienTai;
        lblTongKhach.Text = tongKhach.ToString("N0", viVN);
        lblTongTien.Text = DinhDangTien(tongTien);

        DatLaiForm();
    }

    // Nút Thoát chỉ đóng form, việc hỏi Yes/No nằm ở FormClosing
    // nên bấm dấu X cũng được hỏi mà không phải viết hai lần.
    private void btnThoat_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void frmBai3_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // Windows tắt máy thì đừng chặn, chỉ hỏi khi chính người dùng đóng
        if (e.CloseReason != CloseReason.UserClosing) return;

        DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?",
            "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (tl == DialogResult.No)
            e.Cancel = true;
    }
}