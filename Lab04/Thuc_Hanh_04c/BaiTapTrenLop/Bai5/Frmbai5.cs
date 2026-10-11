namespace Bai5
{
    public partial class frmBai5 : Form
    {
        // Cách đọc từng chữ số 0 đến 9
        private static readonly string[] chuSo =
            { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        public frmBai5()
        {
            InitializeComponent();
        }

        // Đọc số từ 1 đến 999 thành chữ. Tách thành hàng trăm, hàng chục, hàng đơn vị
        // rồi ghép từng phần lại, các trường hợp đặc biệt của tiếng Việt xử lý ở dưới
        private static string DocSo(int n)
        {
            int tram = n / 100;
            int chuc = n / 10 % 10;
            int donVi = n % 10;
            List<string> tu = new List<string>();

            if (tram > 0)
            {
                tu.Add(chuSo[tram]);
                tu.Add("trăm");
            }

            if (chuc == 0)
            {
                // Có hàng trăm mà hàng chục là 0 thì đọc "lẻ" (vd: 105 = một trăm lẻ năm)
                if (donVi > 0)
                {
                    if (tram > 0)
                        tu.Add("lẻ");
                    tu.Add(chuSo[donVi]);
                }
            }
            else if (chuc == 1)
            {
                // Hàng chục là 1 đọc "mười", số 5 ở đơn vị đọc "lăm" (vd: 15 = mười lăm)
                tu.Add("mười");
                if (donVi == 5)
                    tu.Add("lăm");
                else if (donVi > 0)
                    tu.Add(chuSo[donVi]);
            }
            else
            {
                // Từ 20 trở lên đọc "mươi"; đơn vị 1 đọc "mốt", 4 đọc "tư", 5 đọc "lăm"
                tu.Add(chuSo[chuc]);
                tu.Add("mươi");
                if (donVi == 1)
                    tu.Add("mốt");
                else if (donVi == 4)
                    tu.Add("tư");
                else if (donVi == 5)
                    tu.Add("lăm");
                else if (donVi > 0)
                    tu.Add(chuSo[donVi]);
            }

            // Viết hoa chữ cái đầu mỗi từ cho giống mẫu ("Hai Mươi Ba")
            return string.Join(" ", tu.Select(t => char.ToUpper(t[0]) + t.Substring(1)));
        }

        // Chỉ cho gõ chữ số (tối đa 3 chữ số do MaxLength của ô nhập đặt là 3)
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string s = txtSo.Text.Trim();

            if (s.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo.Focus();
                return;
            }

            // Phải là số nguyên trong khoảng 1 đến 999
            if (!int.TryParse(s, out int n) || n < 1 || n > 999)
            {
                MessageBox.Show("Vui lòng nhập một số nguyên từ 1 đến 999!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblKetQua.Text = "";
                txtSo.Focus();
                txtSo.SelectAll();
                return;
            }

            lblKetQua.Text = DocSo(n);
        }

        // Trả form về trạng thái ban đầu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo.Clear();
            lblKetQua.Text = "";
            txtSo.Focus();
        }

        // Đóng form, việc hỏi xác nhận nằm ở sự kiện FormClosing bên dưới
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}