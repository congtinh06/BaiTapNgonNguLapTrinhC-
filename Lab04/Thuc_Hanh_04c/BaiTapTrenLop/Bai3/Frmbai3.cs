namespace Bai3
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        // Tìm ước chung lớn nhất bằng thuật toán Euclid:
        // lấy a chia b lấy dư, rồi thay (a, b) bằng (b, số dư) cho đến khi b = 0
        private static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int du = a % b;
                a = b;
                b = du;
            }
            return a;
        }

        // Đọc một số nguyên dương từ textbox. Sai thì báo MessageBox và trả về false
        private bool DocSo(TextBox txt, string ten, out int so)
        {
            so = 0;
            string s = txt.Text.Trim();

            if (s.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số " + ten + "!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                return false;
            }

            // TryParse thất bại khi quá lớn (vượt int) hoặc không phải số
            if (!int.TryParse(s, out so) || so <= 0)
            {
                MessageBox.Show("Số " + ten + " phải là số nguyên dương (không quá 2147483647)!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                txt.SelectAll();
                return false;
            }
            return true;
        }

        // Chỉ cho gõ chữ số, dùng chung cho cả hai ô nhập
        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (!DocSo(txtA, "a", out int a))
                return;
            if (!DocSo(txtB, "b", out int b))
                return;

            int ucln = UCLN(a, b);

            // BCNN = a * b / UCLN. Chia trước rồi mới nhân, và dùng long vì
            // tích hai số int có thể vượt giới hạn của int
            long bcnn = (long)(a / ucln) * b;

            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        // Trả form về trạng thái ban đầu để nhập lần mới
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
            txtA.Focus();
        }

        // Đóng form, việc hỏi xác nhận nằm ở sự kiện FormClosing bên dưới
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}