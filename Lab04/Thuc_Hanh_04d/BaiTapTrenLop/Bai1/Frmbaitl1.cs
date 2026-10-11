using System.Globalization;

namespace BaiTL1
{
    public partial class frmBaiTL1 : Form
    {
        public frmBaiTL1()
        {
            InitializeComponent();
        }

        // Đọc số theo cài đặt vùng của máy (dấu thập phân là "." hay ","), cùng quy ước
        // với lúc hiển thị kết quả. Chỉ cho dấu âm và dấu thập phân, không nhận "1e5"
        // hay khoảng trắng, vì dán bằng Ctrl+V có thể đưa những thứ đó vào ô nhập.
        private static bool LaSoHopLe(string s, out double v)
        {
            return double.TryParse(s,
                NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                CultureInfo.CurrentCulture, out v);
        }

        // Nút Giải chỉ sáng khi các ô cần thiết đã có số hợp lệ
        private void CapNhatNutGiai()
        {
            bool duDuLieu = LaSoHopLe(txtA.Text, out _) && LaSoHopLe(txtB.Text, out _);
            if (rdoBacHai.Checked)
                duDuLieu = duDuLieu && LaSoHopLe(txtC.Text, out _);
            btnGiai.Enabled = duDuLieu;
        }

        private void frmBaiTL1_Load(object? sender, EventArgs e)
        {
            // Mới mở form: đang ở bậc nhất nên ô c bị mờ, ô nhập còn trống nên nút Giải mờ
            rdoBac_CheckedChanged(sender, e);
        }

        // Dùng chung cho cả hai radio button (một cái được chọn thì cái kia bị bỏ chọn
        // nên sự kiện chạy hai lần, nhưng làm lại cũng không sao)
        private void rdoBac_CheckedChanged(object? sender, EventArgs e)
        {
            bool bacHai = rdoBacHai.Checked;

            // Bậc nhất không có hệ số c nên làm mờ cả nhãn lẫn ô nhập
            lblNhapC.Enabled = bacHai;
            txtC.Enabled = bacHai;
            if (!bacHai)
            {
                txtC.Clear();
                errorProvider1.SetError(txtC, "");
            }

            txtKetQua.Clear();
            CapNhatNutGiai();
        }

        // Chặn ký tự lạ ngay lúc gõ, dùng chung cho 3 ô a, b, c
        private void txtHeSo_KeyPress(object? sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender!;
            string dauThapPhan = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string kyTu = e.KeyChar.ToString();

            // Phím điều khiển (Backspace, Ctrl+C, ...) và chữ số thì cho qua
            if (char.IsControl(e.KeyChar) || (e.KeyChar >= '0' && e.KeyChar <= '9'))
                return;

            // Dấu âm: chỉ ở đầu ô và chỉ một dấu (trừ khi đang bôi đen luôn dấu cũ để thay)
            if (e.KeyChar == '-' && txt.SelectionStart == 0 &&
                (!txt.Text.Contains('-') || txt.SelectedText.Contains('-')))
                return;

            // Dấu thập phân: chỉ một dấu
            if (kyTu == dauThapPhan &&
                (!txt.Text.Contains(dauThapPhan) || txt.SelectedText.Contains(dauThapPhan)))
                return;

            e.Handled = true;
        }

        // Kiểm tra lại mỗi khi nội dung đổi, vì KeyPress không bắt được Ctrl+V
        private void txtHeSo_TextChanged(object? sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender!;
            string s = txt.Text;

            // Ô trống hoặc mới gõ mỗi dấu "-" là đang nhập dở, chưa báo lỗi
            if (s == "" || s == "-" || LaSoHopLe(s, out _))
                errorProvider1.SetError(txt, "");
            else
                errorProvider1.SetError(txt, "Giá trị phải là một số");

            // Số liệu đã đổi thì kết quả cũ không còn đúng nữa
            txtKetQua.Clear();
            CapNhatNutGiai();
        }

        // Báo lỗi bằng cả ErrorProvider lẫn MessageBox, rồi đưa con trỏ về ô sai
        private void BaoLoi(TextBox txt, string thongBao)
        {
            errorProvider1.SetError(txt, thongBao);
            MessageBox.Show(thongBao, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt.Focus();
            txt.SelectAll();
        }

        private void btnGiai_Click(object? sender, EventArgs e)
        {
            // Kiểm tra lại lần nữa phòng khi dữ liệu dán vào lọt qua các bước trước
            if (!LaSoHopLe(txtA.Text, out double a))
            {
                BaoLoi(txtA, "Hệ số a phải là một số.");
                return;
            }
            if (!LaSoHopLe(txtB.Text, out double b))
            {
                BaoLoi(txtB, "Hệ số b phải là một số.");
                return;
            }
            double c = 0;
            if (rdoBacHai.Checked && !LaSoHopLe(txtC.Text, out c))
            {
                BaoLoi(txtC, "Hệ số c phải là một số.");
                return;
            }

            // Bậc hai mà a = 0 thì không còn là bậc hai, bắt nhập lại a
            if (rdoBacHai.Checked && a == 0)
            {
                BaoLoi(txtA, "Phương trình bậc hai cần a khác 0.");
                return;
            }

            PhuongTrinhBacHai pt = new PhuongTrinhBacHai(a, b, c);
            txtKetQua.Text = rdoBacHai.Checked ? pt.GiaiBacHai() : pt.GiaiBacNhat();

            // Giải xong thì nút Giải mờ đi (sáng lại khi người dùng sửa số liệu)
            btnGiai.Enabled = false;
            txtA.Focus();
            txtA.SelectAll();
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            // Chỉ đóng form; việc hỏi xác nhận nằm ở FormClosing để bấm nút X cũng được hỏi
            Close();
        }

        private void frmBaiTL1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}