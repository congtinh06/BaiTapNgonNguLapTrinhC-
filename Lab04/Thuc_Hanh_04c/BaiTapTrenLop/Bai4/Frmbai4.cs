namespace Bai4
{
    public partial class frmBai4 : Form
    {
        // Lưu dãy số đã nhập (mỗi lần bấm Nhập thêm một phần tử)
        private List<int> day = new List<int>();

        public frmBai4()
        {
            InitializeComponent();
        }

        // Chỉ cho gõ chữ số và dấu trừ ở đầu ô (dãy số nguyên bất kỳ, có thể âm)
        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (char.IsControl(c) || char.IsDigit(c))
                return;

            if (c == '-' && txtNhap.SelectionStart == 0 && !txtNhap.Text.Contains('-'))
                return;

            e.Handled = true;
        }

        // Thêm số vừa nhập vào dãy rồi hiện cả dãy ra ô "Dãy vừa nhập"
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhap.Text.Trim(), out int so))
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhap.Focus();
                txtNhap.SelectAll();
                return;
            }

            day.Add(so);
            txtDay.Text = string.Join(" ", day);

            // Dãy đã thay đổi nên kết quả tổng cũ không còn đúng, xóa đi chờ tính lại
            txtTong.Clear();
            txtChan.Clear();
            txtLe.Clear();

            // Chuẩn bị nhập số kế tiếp
            txtNhap.Clear();
            txtNhap.Focus();
        }

        // Tính tổng cả dãy, tổng các số chẵn và tổng các số lẻ
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (day.Count == 0)
            {
                MessageBox.Show("Chưa có số nào trong dãy, hãy nhập số trước!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Focus();
                return;
            }

            // Dùng long để cộng nhiều số lớn không bị tràn
            long tong = 0, tongChan = 0, tongLe = 0;

            foreach (int so in day)
            {
                tong += so;

                // Số chẵn chia 2 dư 0. Số lẻ âm chia 2 dư -1 nên xét "khác 0" chứ không xét "bằng 1"
                if (so % 2 == 0)
                    tongChan += so;
                else
                    tongLe += so;
            }

            txtTong.Text = tong.ToString();
            txtChan.Text = tongChan.ToString();
            txtLe.Text = tongLe.ToString();
        }

        // Trả form về trạng thái ban đầu
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            day.Clear();
            txtNhap.Clear();
            txtDay.Clear();
            txtTong.Clear();
            txtChan.Clear();
            txtLe.Clear();
            txtNhap.Focus();
        }

        // Đóng form, việc hỏi xác nhận nằm ở sự kiện FormClosing bên dưới
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}