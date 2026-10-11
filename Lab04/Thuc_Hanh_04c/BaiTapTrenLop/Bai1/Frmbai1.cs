using System.Globalization;

namespace BaiTapTrenLop
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        // Kiểm tra textbox có phải số hợp lệ không.
        // Sai thì gắn dấu lỗi (ErrorProvider) vào ô đó và trả về false, đúng thì xóa lỗi cũ.
        private bool KiemTraSo(TextBox txt, string ten)
        {
            string s = txt.Text.Trim();

            if (s.Length == 0)
            {
                errorProvider1.SetError(txt, "Chưa nhập " + ten);
                return false;
            }

            // Dùng CurrentCulture để khớp với dấu thập phân của máy (VN là dấu phẩy)
            if (!double.TryParse(s, NumberStyles.Float, CultureInfo.CurrentCulture, out _))
            {
                errorProvider1.SetError(txt, ten + " phải là số");
                return false;
            }

            errorProvider1.SetError(txt, "");
            return true;
        }

        // Mức 2: chặn ngay lúc gõ phím. Dùng chung cho cả txtA và txtB.
        // e.Handled = true nghĩa là bỏ qua phím vừa bấm, ký tự không hiện lên ô.
        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            char c = e.KeyChar;
            string dauThapPhan = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // Cho phép phím điều khiển (Backspace, Enter...) và chữ số
            if (char.IsControl(c) || char.IsDigit(c))
                return;

            // Dấu trừ: chỉ cho gõ ở đầu ô và chỉ một lần
            if (c == '-' && txt.SelectionStart == 0 && !txt.Text.Contains('-'))
                return;

            // Dấu thập phân: chỉ cho gõ một lần
            if (c.ToString() == dauThapPhan && !txt.Text.Contains(dauThapPhan))
                return;

            // Còn lại (chữ cái, ký tự đặc biệt...) thì chặn
            e.Handled = true;
        }

        // Mức 1: rời khỏi ô thì kiểm tra và báo lỗi bằng ErrorProvider
        private void txtA_Leave(object sender, EventArgs e)
        {
            KiemTraSo(txtA, "a");
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            KiemTraSo(txtB, "b");
        }

        // Người dùng sửa lại cho đúng thì tắt dấu lỗi luôn, không cần đợi rời ô
        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (double.TryParse(txt.Text.Trim(), NumberStyles.Float, CultureInfo.CurrentCulture, out _))
                errorProvider1.SetError(txt, "");
        }

        // Hàm tính chung cho 4 nút, truyền vào phép toán cần làm
        private void TinhToan(char phepToan)
        {
            // Kiểm tra cả hai ô (không dừng ở ô đầu) để cả hai cùng hiện lỗi nếu sai
            bool aOk = KiemTraSo(txtA, "a");
            bool bOk = KiemTraSo(txtB, "b");

            if (!aOk || !bOk)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, vui lòng nhập lại a và b là số!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Đưa con trỏ về ô bị lỗi (ưu tiên ô a)
                (aOk ? txtB : txtA).Focus();
                return;
            }

            double a = double.Parse(txtA.Text.Trim(), CultureInfo.CurrentCulture);
            double b = double.Parse(txtB.Text.Trim(), CultureInfo.CurrentCulture);
            double kq;

            switch (phepToan)
            {
                case '+': kq = a + b; break;
                case '-': kq = a - b; break;
                case '*': kq = a * b; break;
                default:
                    // Phép chia: b = 0 thì không tính được
                    if (b == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(txtB, "b phải khác 0");
                        txtB.Focus();
                        return;
                    }
                    kq = a / b;
                    break;
            }

            txtKetQua.Text = kq.ToString(CultureInfo.CurrentCulture);
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            TinhToan('+');
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            TinhToan('-');
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            TinhToan('*');
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            TinhToan('/');
        }

        // Hỏi xác nhận trước khi đóng form: chọn No thì hủy việc đóng
        private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}