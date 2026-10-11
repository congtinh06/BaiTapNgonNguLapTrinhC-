namespace BaiVN1
{
    public partial class frmBaiVN1 : Form
    {
        // Tối đa 12 chữ số khi gõ một số. Chọn 12 để tích của hai số (tối đa ~1e24)
        // vẫn nằm trong khoảng của kiểu decimal, không bao giờ bị tràn khi tính.
        private const int MaxChuSo = 12;

        // Kết quả từ 1e15 trở lên thì không hiển thị vừa màn hình nữa, coi như tràn số
        private const decimal GioiHanKetQua = 1000000000000000m;

        private decimal soDau;               // toán hạng thứ nhất (số đã bấm trước phép toán)
        private char phepToan = ' ';         // ' ' nghĩa là chưa có phép toán nào đang chờ
        private bool nhapSoMoi = true;       // true: chữ số kế tiếp sẽ thay hẳn số trên màn hình

        public frmBaiVN1()
        {
            InitializeComponent();
            DatLai();
        }

        // Trả máy tính về trạng thái ban đầu (dùng cho nút C và khi gặp lỗi)
        private void DatLai()
        {
            soDau = 0;
            phepToan = ' ';
            nhapSoMoi = true;
            txtManHinh.Text = "0";
        }

        // Sau mỗi lần bấm nút, trả tiêu điểm về ô màn hình. Nếu không, nút vừa bấm
        // giữ tiêu điểm và nhấn Enter sẽ bấm lại chính nút đó chứ không phải dấu "=".
        private void GiuTieuDiem()
        {
            txtManHinh.Focus();
            txtManHinh.Select(0, 0);
        }

        // Đếm số chữ số trên màn hình (bỏ qua dấu trừ và dấu thập phân)
        private static int DemChuSo(string s)
        {
            int dem = 0;
            foreach (char c in s)
                if (char.IsDigit(c)) dem++;
            return dem;
        }

        // Một hàm dùng chung cho 10 nút số 0-9, chữ số lấy từ Text của nút
        private void btnSo_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender!;

            if (nhapSoMoi || txtManHinh.Text == "0")
            {
                // bắt đầu số mới, hoặc thay số 0 đứng đầu (tránh "05")
                txtManHinh.Text = btn.Text;
            }
            else if (DemChuSo(txtManHinh.Text) < MaxChuSo)
            {
                txtManHinh.Text += btn.Text;
            }
            // quá 12 chữ số thì lờ đi, không thêm nữa

            nhapSoMoi = false;
            GiuTieuDiem();
        }

        // Một hàm dùng chung cho 4 nút + - * /
        private void btnPhepToan_Click(object? sender, EventArgs e)
        {
            char op = ((Button)sender!).Text[0];

            // Đã có phép toán chờ và người dùng vừa gõ xong số thứ hai (vd 2 + 3 rồi bấm *):
            // tính luôn phép trước để hiện kết quả trung gian, giống máy tính bỏ túi thật.
            // Nếu chưa gõ số thứ hai (bấm hai dấu liên tiếp) thì chỉ đổi phép toán.
            if (phepToan != ' ' && !nhapSoMoi)
            {
                if (!Tinh())
                {
                    GiuTieuDiem();
                    return;
                }
            }

            soDau = decimal.Parse(txtManHinh.Text);
            phepToan = op;
            nhapSoMoi = true;
            GiuTieuDiem();
        }

        // Tính soDau (phép toán) số-trên-màn-hình rồi ghi kết quả lên màn hình.
        // Trả về false nếu có lỗi (chia cho 0, tràn số); lúc đó máy đã được đặt lại.
        private bool Tinh()
        {
            decimal b = decimal.Parse(txtManHinh.Text);
            decimal kq;

            switch (phepToan)
            {
                case '+':
                    kq = soDau + b;
                    break;
                case '-':
                    kq = soDau - b;
                    break;
                case '*':
                    kq = soDau * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DatLai();
                        return false;
                    }
                    kq = soDau / b;
                    break;
                default:
                    return true;   // không có phép toán thì không có gì để tính
            }

            if (Math.Abs(kq) >= GioiHanKetQua)
            {
                MessageBox.Show("Kết quả quá lớn, máy không hiển thị được.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DatLai();
                return false;
            }

            // Làm tròn 8 chữ số thập phân để 1/3 không dài lê thê. Làm tròn xong rồi
            // mới hiển thị nên số đọc lại từ màn hình đúng bằng số đang dùng để tính tiếp.
            kq = Math.Round(kq, 8, MidpointRounding.AwayFromZero);
            if (kq == 0) kq = 0;   // tránh hiện "-0"

            txtManHinh.Text = kq.ToString("0.########");
            return true;
        }

        private void btnBang_Click(object? sender, EventArgs e)
        {
            // Chưa có phép toán nào thì bấm "=" không làm gì
            if (phepToan != ' ')
            {
                // Nếu chưa gõ số thứ hai (vd bấm 5 + =) thì lấy luôn số trên màn hình làm số thứ hai
                if (Tinh())
                {
                    phepToan = ' ';
                    nhapSoMoi = true;   // gõ số tiếp theo sẽ bắt đầu phép tính mới
                }
            }
            GiuTieuDiem();
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            DatLai();
            GiuTieuDiem();
        }
    }
}