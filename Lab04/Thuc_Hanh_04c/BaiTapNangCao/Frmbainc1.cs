namespace BaiNC1
{
    public partial class frmBaiNC1 : Form
    {
        // Ba trạng thái của một ghế. Lưu thẳng vào Tag của nút để khỏi phải
        // giữ thêm một mảng trạng thái riêng, đỡ bị lệch giữa màu và dữ liệu.
        private enum TrangThai { Trong, DangChon, DaBan }

        // Giá vé theo lô (đề cho 1000 / 1500 / 2000 mỗi vé)
        private const int GiaLoA = 1000;
        private const int GiaLoB = 1500;
        private const int GiaLoC = 2000;

        private readonly Color mauTrong = Color.White;
        private readonly Color mauDangChon = Color.Blue;
        private readonly Color mauDaBan = Color.Yellow;

        // Gom 15 nút vào mảng để duyệt bằng vòng for; chỉ số i ứng với ghế số i + 1
        private readonly Button[] dsGhe;

        public frmBaiNC1()
        {
            InitializeComponent();

            dsGhe = new Button[]
            {
                btnGhe1, btnGhe2, btnGhe3, btnGhe4, btnGhe5,
                btnGhe6, btnGhe7, btnGhe8, btnGhe9, btnGhe10,
                btnGhe11, btnGhe12, btnGhe13, btnGhe14, btnGhe15
            };

            // Mọi ghế ban đầu là ghế trống (màu trắng)
            foreach (Button ghe in dsGhe)
                DatTrangThai(ghe, TrangThai.Trong);

            // Cho sẵn vài ghế đã bán giống hình mẫu (2, 7, 9, 11) để thử được
            // trường hợp bấm vào ghế đã bán. Muốn rạp trống hoàn toàn thì xóa đoạn này.
            int[] daBanSan = { 2, 7, 9, 11 };
            foreach (int so in daBanSan)
                DatTrangThai(dsGhe[so - 1], TrangThai.DaBan);
        }

        // Đổi trạng thái và màu của một ghế cùng lúc, tránh quên đổi một trong hai
        private void DatTrangThai(Button ghe, TrangThai tt)
        {
            ghe.Tag = tt;
            switch (tt)
            {
                case TrangThai.Trong:
                    ghe.BackColor = mauTrong;
                    ghe.ForeColor = Color.Black;
                    break;
                case TrangThai.DangChon:
                    ghe.BackColor = mauDangChon;
                    // chữ trắng cho dễ đọc trên nền xanh đậm
                    ghe.ForeColor = Color.White;
                    break;
                case TrangThai.DaBan:
                    ghe.BackColor = mauDaBan;
                    ghe.ForeColor = Color.Black;
                    break;
            }
        }

        // Giá vé theo số ghế. Đề chỉ nói "3 lô nhỏ" mà không nói rõ ghế nào thuộc lô nào,
        // nên mình chia theo hàng: hàng 1 (1-5) lô A, hàng 2 (6-10) lô B, hàng 3 (11-15) lô C.
        private int LayGiaVe(int soGhe)
        {
            if (soGhe <= 5) return GiaLoA;
            if (soGhe <= 10) return GiaLoB;
            return GiaLoC;
        }

        // Một hàm dùng chung cho cả 15 nút ghế (sender cho biết nút nào được bấm)
        private void btnGhe_Click(object? sender, EventArgs e)
        {
            Button ghe = (Button)sender!;
            TrangThai tt = (TrangThai)ghe.Tag!;

            switch (tt)
            {
                case TrangThai.Trong:
                    DatTrangThai(ghe, TrangThai.DangChon);
                    break;
                case TrangThai.DangChon:
                    // bấm lại ghế đang chọn thì bỏ chọn
                    DatTrangThai(ghe, TrangThai.Trong);
                    break;
                case TrangThai.DaBan:
                    MessageBox.Show("Ghế số " + ghe.Text + " đã bán, vui lòng chọn ghế khác.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnChon_Click(object? sender, EventArgs e)
        {
            int tongTien = 0;
            int soVe = 0;

            // Duyệt một lượt: cộng tiền và đổi luôn ghế đang chọn sang đã bán
            for (int i = 0; i < dsGhe.Length; i++)
            {
                if ((TrangThai)dsGhe[i].Tag! == TrangThai.DangChon)
                {
                    tongTien += LayGiaVe(i + 1);
                    soVe++;
                    DatTrangThai(dsGhe[i], TrangThai.DaBan);
                }
            }

            // Chưa chọn ghế nào mà bấm Chọn thì báo, không đổi gì cả
            if (soVe == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thành tiền là số tiền của đợt vừa chọn (không cộng dồn các vé đã bán trước đó)
            lblTongTien.Text = tongTien.ToString("N0");
        }

        private void btnHuyBo_Click(object? sender, EventArgs e)
        {
            // Chỉ trả ghế đang chọn về trắng; ghế đã bán giữ nguyên màu vàng
            foreach (Button ghe in dsGhe)
            {
                if ((TrangThai)ghe.Tag! == TrangThai.DangChon)
                    DatTrangThai(ghe, TrangThai.Trong);
            }
            lblTongTien.Text = "0";
        }

        private void btnKetThuc_Click(object? sender, EventArgs e)
        {
            // Chỉ đóng form; việc hỏi xác nhận nằm ở FormClosing để bấm nút X cũng được hỏi
            Close();
        }

        private void frmBaiNC1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}