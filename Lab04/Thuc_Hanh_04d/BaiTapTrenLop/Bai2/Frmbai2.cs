using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Bai2;

public partial class frmBai2 : Form
{
    // Mảng đang làm việc. Còn null nghĩa là chưa bấm "Nhập mảng".
    private MangSoNguyen? mang;

    // Đề chỉ vẽ một nút "Thực Hiện" nhưng có tới 5 nhóm chức năng (sắp xếp, tìm, xóa,
    // thêm, thay thế). Nên mình nhớ nhóm mà người dùng vừa đụng tới, nút này sẽ chạy nhóm đó.
    private enum Nhom { SapXep, TimKiem, Xoa, Them, ThayThe }
    private Nhom nhomHienTai = Nhom.SapXep;

    public frmBai2()
    {
        InitializeComponent();

        GanNhom(grpSapXep, Nhom.SapXep);
        GanNhom(grpTimKiem, Nhom.TimKiem);
        GanNhom(grpXoa, Nhom.Xoa);
        GanNhom(grpThem, Nhom.Them);
        GanNhom(grpThayThe, Nhom.ThayThe);

        // Đang gõ ở ô nhập mảng thì Enter phải là "Nhập mảng" chứ không phải "Thực Hiện"
        txtNhapMang.Enter += (s, e) => AcceptButton = btnNhapMang;

        CapNhatOTextBox();
    }

    // Gắn một sự kiện Enter chung cho GroupBox và mọi control con của nó.
    // Con trỏ nhảy vào bất kỳ ô nào trong nhóm thì nhóm đó thành "nhóm hiện tại".
    private void GanNhom(GroupBox nhomControl, Nhom nhom)
    {
        void ghiNho(object? s, EventArgs e)
        {
            nhomHienTai = nhom;
            AcceptButton = btnThucHien;
        }

        nhomControl.Enter += ghiNho;
        foreach (Control c in nhomControl.Controls)
            c.Enter += ghiNho;
    }

    // ---------------------------------------------------------------- tiện ích dùng chung

    private static void ThongBao(string noiDung, MessageBoxIcon icon = MessageBoxIcon.Information)
    {
        MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, icon);
    }

    // Báo cho người dùng biết chưa có mảng. [MemberNotNullWhen] để compiler hiểu
    // là sau khi hàm này trả true thì biến mang chắc chắn khác null.
    [MemberNotNullWhen(true, nameof(mang))]
    private bool CoMang()
    {
        if (mang != null) return true;
        ThongBao("Bạn chưa nhập mảng. Hãy gõ dãy số rồi bấm \"Nhập mảng\".", MessageBoxIcon.Warning);
        txtNhapMang.Focus();
        return false;
    }

    // Đọc một số nguyên từ textbox, sai thì gắn lỗi vào ErrorProvider.
    // Dùng int.TryParse nên dán chữ vào (Ctrl+V) hay số quá lớn đều bị bắt ở đây.
    private bool DocSoNguyen(TextBox txt, string ten, out int giaTri)
    {
        giaTri = 0;
        string s = txt.Text.Trim();

        if (s == "")
        {
            errorProvider1.SetError(txt, $"Chưa nhập {ten}");
            txt.Focus();
            return false;
        }
        if (!int.TryParse(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out giaTri))
        {
            errorProvider1.SetError(txt, $"{ten} phải là số nguyên (trong khoảng -2147483648 đến 2147483647)");
            txt.Focus();
            return false;
        }
        return true;
    }

    // Vị trí tính từ 0. maxViTri là vị trí lớn nhất được phép
    // (xóa/tìm/thay: n - 1, còn thêm thì được phép bằng n tức là thêm vào cuối).
    private bool DocViTri(TextBox txt, int maxViTri, out int viTri)
    {
        if (!DocSoNguyen(txt, "vị trí", out viTri)) return false;

        if (viTri < 0 || viTri > maxViTri)
        {
            string loi = maxViTri < 0 ? "Mảng đang rỗng, không có vị trí nào" : $"Vị trí phải từ 0 đến {maxViTri}";
            errorProvider1.SetError(txt, loi);
            txt.Focus();
            return false;
        }
        return true;
    }

    // Đưa mảng lên ô "Kết quả mảng". Mảng đã đổi thì mấy kết quả cũ (tổng, max-min,
    // vị trí tìm được) không còn đúng nữa nên xóa luôn cho khỏi gây hiểu nhầm.
    private void CapNhatMang()
    {
        txtKetQuaMang.Text = (mang == null || mang.SoPhanTu == 0) ? "(mảng rỗng)" : mang.ToString();

        txtKetQuaTim.Clear();
        txtTongMang.Clear();
        txtTongChan.Clear();
        txtTongLe.Clear();
        txtMax.Clear();
        txtMin.Clear();
    }

    // Mỗi ô nhập chỉ mở khi radio tương ứng được chọn, tránh người dùng điền nhầm ô.
    private void CapNhatOTextBox()
    {
        txtTimGiaTri.Enabled = rdoTimGiaTri.Checked;
        txtTimViTri.Enabled = rdoTimViTri.Checked;

        txtXoaGiaTri.Enabled = rdoXoaGiaTri.Checked;
        txtXoaViTri.Enabled = rdoXoaViTri.Checked;

        txtThemGiaTri.Enabled = rdoThemGiaTri.Checked;
        txtThemViTri.Enabled = rdoThemGiaTri.Checked;

        txtThayGiaTri.Enabled = rdoThayGiaTri.Checked;
        txtThayViTri.Enabled = rdoThayViTri.Checked;
        txtSoThayThe.Enabled = rdoThayGiaTri.Checked || rdoThayViTri.Checked;
    }

    private void XoaTextBox(Control cha)
    {
        foreach (Control c in cha.Controls)
        {
            if (c is TextBox tb) tb.Clear();
            else if (c.HasChildren) XoaTextBox(c);
        }
    }

    // ---------------------------------------------------------------- chặn ký tự lạ

    // Ô nhập mảng: số, dấu cách, dấu phẩy, dấu trừ. Dấu trừ có đặt đúng chỗ hay không
    // thì để lúc bấm "Nhập mảng" kiểm tra (chặn ở đây thì phức tạp mà không đáng).
    private void txtNhapMang_KeyPress(object? sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        bool hopLe = char.IsControl(c) || (c >= '0' && c <= '9') || c == ' ' || c == ',' || c == '-';
        if (!hopLe) e.Handled = true;
    }

    // Các ô số nguyên: chỉ cho chữ số, và dấu trừ nếu nó nằm ở đầu ô và chưa có dấu trừ nào.
    private void txtSoNguyen_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (sender is not TextBox txt) return;

        char c = e.KeyChar;
        if (char.IsControl(c) || (c >= '0' && c <= '9')) return;

        if (c == '-')
        {
            // đang bôi đen luôn cả dấu '-' cũ thì gõ đè được
            bool daCoDauTru = txt.Text.Contains('-') && !(txt.SelectionStart == 0 && txt.SelectionLength > 0);
            if (txt.SelectionStart == 0 && !daCoDauTru) return;
        }
        e.Handled = true;
    }

    private void rdoNhom_CheckedChanged(object? sender, EventArgs e)
    {
        errorProvider1.Clear();
        CapNhatOTextBox();
    }

    // ---------------------------------------------------------------- nhập mảng, reset, thoát

    private void btnNhapMang_Click(object? sender, EventArgs e)
    {
        errorProvider1.Clear();

        if (!MangSoNguyen.TryParse(txtNhapMang.Text, out int[] ds, out string loi))
        {
            errorProvider1.SetError(txtNhapMang, loi);
            txtNhapMang.Focus();
            return;
        }

        mang = new MangSoNguyen(ds);
        CapNhatMang();
    }

    private void btnReset_Click(object? sender, EventArgs e)
    {
        mang = null;
        errorProvider1.Clear();
        XoaTextBox(this);

        rdoTang.Checked = true;
        rdoTimGiaTri.Checked = false;
        rdoTimViTri.Checked = false;
        rdoXoaGiaTri.Checked = false;
        rdoXoaViTri.Checked = false;
        rdoThemGiaTri.Checked = false;
        rdoThayGiaTri.Checked = false;
        rdoThayViTri.Checked = false;

        nhomHienTai = Nhom.SapXep;
        AcceptButton = btnNhapMang;
        txtNhapMang.Focus();
    }

    // Nút Thoát chỉ đóng form, còn hỏi Yes/No nằm hết ở FormClosing.
    // Làm vậy thì bấm dấu X hay Alt+F4 cũng được hỏi, không phải viết hai lần.
    private void btnThoat_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void frmBai2_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // Windows tắt máy thì đừng chặn, chỉ hỏi khi chính người dùng đóng
        if (e.CloseReason != CloseReason.UserClosing) return;

        DialogResult tl = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
            "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (tl == DialogResult.No)
            e.Cancel = true;
    }

    // ---------------------------------------------------------------- nút "Thực Hiện"

    private void btnThucHien_Click(object? sender, EventArgs e)
    {
        if (!CoMang()) return;
        errorProvider1.Clear();

        switch (nhomHienTai)
        {
            case Nhom.SapXep: XuLySapXep(mang); break;
            case Nhom.TimKiem: XuLyTimKiem(mang); break;
            case Nhom.Xoa: XuLyXoa(mang); break;
            case Nhom.Them: XuLyThem(mang); break;
            case Nhom.ThayThe: XuLyThayThe(mang); break;
        }
    }

    private void XuLySapXep(MangSoNguyen m)
    {
        if (rdoGiam.Checked) m.SapXepGiam();
        else m.SapXepTang();
        CapNhatMang();
    }

    private void XuLyTimKiem(MangSoNguyen m)
    {
        if (rdoTimGiaTri.Checked)
        {
            if (!DocSoNguyen(txtTimGiaTri, "giá trị cần tìm", out int giaTri)) return;

            int[] viTri = m.TimGiaTri(giaTri);
            if (viTri.Length == 0)
            {
                txtKetQuaTim.Clear();
                ThongBao($"Không có giá trị {giaTri} trong mảng.");
                return;
            }
            // Ô kết quả nhỏ nên chỉ ghi vị trí đầu tiên, các vị trí còn lại báo bằng MessageBox
            txtKetQuaTim.Text = viTri[0].ToString();
            ThongBao($"Giá trị {giaTri} xuất hiện {viTri.Length} lần, tại vị trí (tính từ 0): {string.Join(", ", viTri)}");
        }
        else if (rdoTimViTri.Checked)
        {
            if (!DocViTri(txtTimViTri, m.SoPhanTu - 1, out int viTri)) return;
            txtKetQuaTim.Text = m.LayGiaTri(viTri).ToString();
        }
        else
        {
            ThongBao("Hãy chọn \"Tìm giá trị cần tìm\" hoặc \"Tìm vị trí cần tìm\".", MessageBoxIcon.Warning);
        }
    }

    private void XuLyXoa(MangSoNguyen m)
    {
        if (!rdoXoaGiaTri.Checked && !rdoXoaViTri.Checked)
        {
            ThongBao("Hãy chọn xóa theo giá trị hay theo vị trí.", MessageBoxIcon.Warning);
            return;
        }
        // Dòng chữ đỏ "Cần sắp xếp tăng" trên form không phải để trang trí, nên chặn thật
        if (!m.DaSapXepTang())
        {
            ThongBao("Cần sắp xếp tăng mảng trước khi xóa.", MessageBoxIcon.Warning);
            return;
        }

        if (rdoXoaGiaTri.Checked)
        {
            if (!DocSoNguyen(txtXoaGiaTri, "giá trị cần xóa", out int giaTri)) return;

            int daXoa = m.XoaGiaTri(giaTri);
            if (daXoa == 0)
            {
                ThongBao($"Không có giá trị {giaTri} trong mảng để xóa.");
                return;
            }
        }
        else
        {
            if (!DocViTri(txtXoaViTri, m.SoPhanTu - 1, out int viTri)) return;
            m.XoaViTri(viTri);
        }
        CapNhatMang();
    }

    private void XuLyThem(MangSoNguyen m)
    {
        if (!rdoThemGiaTri.Checked)
        {
            ThongBao("Hãy chọn mục thêm giá trị trước.", MessageBoxIcon.Warning);
            return;
        }
        if (!m.DaSapXepTang())
        {
            ThongBao("Cần sắp xếp tăng mảng trước khi thêm.", MessageBoxIcon.Warning);
            return;
        }

        // đọc cả hai ô rồi mới thoát, để lỗi ở ô nào cũng hiện biểu tượng cùng lúc
        bool ok1 = DocSoNguyen(txtThemGiaTri, "giá trị cần thêm", out int giaTri);
        bool ok2 = DocViTri(txtThemViTri, m.SoPhanTu, out int viTri);
        if (!ok1 || !ok2) return;

        m.Them(giaTri, viTri);
        CapNhatMang();
    }

    private void XuLyThayThe(MangSoNguyen m)
    {
        if (!rdoThayGiaTri.Checked && !rdoThayViTri.Checked)
        {
            ThongBao("Hãy chọn thay thế theo giá trị hay theo vị trí.", MessageBoxIcon.Warning);
            return;
        }

        if (rdoThayGiaTri.Checked)
        {
            bool ok1 = DocSoNguyen(txtThayGiaTri, "giá trị cần thay thế", out int cu);
            bool ok2 = DocSoNguyen(txtSoThayThe, "số thay thế", out int moi);
            if (!ok1 || !ok2) return;

            int daThay = m.ThayTheGiaTri(cu, moi);
            if (daThay == 0)
            {
                ThongBao($"Không có giá trị {cu} trong mảng để thay thế.");
                return;
            }
        }
        else
        {
            bool ok1 = DocViTri(txtThayViTri, m.SoPhanTu - 1, out int viTri);
            bool ok2 = DocSoNguyen(txtSoThayThe, "số thay thế", out int moi);
            if (!ok1 || !ok2) return;

            m.ThayTheViTri(viTri, moi);
        }
        CapNhatMang();
    }

    // ---------------------------------------------------------------- Tổng, Max - Min

    private void btnTong_Click(object? sender, EventArgs e)
    {
        if (!CoMang()) return;

        txtTongMang.Text = mang.Tong().ToString();
        txtTongChan.Text = mang.TongChan().ToString();
        txtTongLe.Text = mang.TongLe().ToString();
    }

    private void btnTim_Click(object? sender, EventArgs e)
    {
        if (!CoMang()) return;

        // xóa hết phần tử rồi thì không còn gì để tìm max/min
        if (mang.SoPhanTu == 0)
        {
            ThongBao("Mảng đang rỗng nên không có giá trị lớn nhất / nhỏ nhất.", MessageBoxIcon.Warning);
            return;
        }
        txtMax.Text = mang.Max().ToString();
        txtMin.Text = mang.Min().ToString();
    }
}

// Class lưu mảng một chiều số nguyên và các thao tác trên nó.
// Quy ước: vị trí (chỉ số) tính từ 0, giống mảng trong C#.
public class MangSoNguyen
{
    private int[] _mang;

    public MangSoNguyen()
    {
        _mang = Array.Empty<int>();
    }

    public MangSoNguyen(int[] ds)
    {
        // Sao chép ra mảng riêng, để bên ngoài sửa ds thì mảng của mình không bị đổi theo
        _mang = (int[])ds.Clone();
    }

    public int[] Mang
    {
        get { return (int[])_mang.Clone(); }
        set { _mang = (int[])value.Clone(); }
    }

    public int SoPhanTu
    {
        get { return _mang.Length; }
    }

    // Tách chuỗi "5 6 4,7" thành mảng số. Ngăn cách bằng dấu cách hoặc dấu phẩy.
    // Trả false kèm câu báo lỗi nếu có phần tử không phải số nguyên hoặc không có phần tử nào.
    public static bool TryParse(string chuoi, out int[] ds, out string loi)
    {
        ds = Array.Empty<int>();
        loi = "";

        string[] phan = chuoi.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (phan.Length == 0)
        {
            loi = "Chưa nhập phần tử nào";
            return false;
        }

        int[] tam = new int[phan.Length];
        for (int i = 0; i < phan.Length; i++)
        {
            if (!int.TryParse(phan[i], NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out tam[i]))
            {
                loi = $"\"{phan[i]}\" không phải số nguyên hợp lệ";
                return false;
            }
        }
        ds = tam;
        return true;
    }

    public bool HopLeViTri(int viTri)
    {
        return viTri >= 0 && viTri < _mang.Length;
    }

    public void SapXepTang()
    {
        Array.Sort(_mang);
    }

    public void SapXepGiam()
    {
        Array.Sort(_mang);
        Array.Reverse(_mang);
    }

    // Mảng rỗng hoặc một phần tử thì coi như đã tăng. Bằng nhau liền kề vẫn tính là tăng.
    public bool DaSapXepTang()
    {
        for (int i = 1; i < _mang.Length; i++)
            if (_mang[i] < _mang[i - 1]) return false;
        return true;
    }

    // Trả về mọi vị trí có giá trị này (mảng rỗng nghĩa là không tìm thấy)
    public int[] TimGiaTri(int giaTri)
    {
        List<int> ds = new List<int>();
        for (int i = 0; i < _mang.Length; i++)
            if (_mang[i] == giaTri) ds.Add(i);
        return ds.ToArray();
    }

    // Nơi gọi phải kiểm tra HopLeViTri trước, sai vị trí sẽ ném IndexOutOfRangeException
    public int LayGiaTri(int viTri)
    {
        return _mang[viTri];
    }

    // Xóa mọi phần tử bằng giá trị đó, trả về số phần tử đã xóa
    public int XoaGiaTri(int giaTri)
    {
        List<int> ds = new List<int>(_mang);
        int daXoa = ds.RemoveAll(x => x == giaTri);
        _mang = ds.ToArray();
        return daXoa;
    }

    public bool XoaViTri(int viTri)
    {
        if (!HopLeViTri(viTri)) return false;

        List<int> ds = new List<int>(_mang);
        ds.RemoveAt(viTri);
        _mang = ds.ToArray();
        return true;
    }

    // viTri = SoPhanTu nghĩa là thêm vào cuối mảng
    public bool Them(int giaTri, int viTri)
    {
        if (viTri < 0 || viTri > _mang.Length) return false;

        List<int> ds = new List<int>(_mang);
        ds.Insert(viTri, giaTri);
        _mang = ds.ToArray();
        return true;
    }

    // Các hàm tổng trả về long: cộng nhiều số int gần 2 tỷ lại sẽ tràn int
    public long Tong()
    {
        long t = 0;
        foreach (int x in _mang) t += x;
        return t;
    }

    public long TongChan()
    {
        long t = 0;
        foreach (int x in _mang)
            if (x % 2 == 0) t += x;
        return t;
    }

    // Số lẻ âm có x % 2 == -1 chứ không phải 1, nên so với 0 thay vì so với 1
    public long TongLe()
    {
        long t = 0;
        foreach (int x in _mang)
            if (x % 2 != 0) t += x;
        return t;
    }

    public int Max()
    {
        if (_mang.Length == 0) throw new InvalidOperationException("Mảng rỗng");
        int m = _mang[0];
        foreach (int x in _mang)
            if (x > m) m = x;
        return m;
    }

    public int Min()
    {
        if (_mang.Length == 0) throw new InvalidOperationException("Mảng rỗng");
        int m = _mang[0];
        foreach (int x in _mang)
            if (x < m) m = x;
        return m;
    }

    // Thay mọi phần tử bằng giá trị cũ, trả về số phần tử đã thay
    public int ThayTheGiaTri(int giaTriCu, int giaTriMoi)
    {
        int dem = 0;
        for (int i = 0; i < _mang.Length; i++)
        {
            if (_mang[i] == giaTriCu)
            {
                _mang[i] = giaTriMoi;
                dem++;
            }
        }
        return dem;
    }

    public bool ThayTheViTri(int viTri, int giaTriMoi)
    {
        if (!HopLeViTri(viTri)) return false;
        _mang[viTri] = giaTriMoi;
        return true;
    }

    public override string ToString()
    {
        return string.Join(" ", _mang);
    }
}