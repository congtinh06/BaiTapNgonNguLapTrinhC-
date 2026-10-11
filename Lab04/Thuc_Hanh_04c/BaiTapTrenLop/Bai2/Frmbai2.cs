using System.Text.RegularExpressions;

namespace Bai2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        // Mẫu email đơn giản: phần tên + @ + tên miền + đuôi (vd: abc@gmail.com)
        private static readonly Regex mauEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        // Ô bắt buộc nhập: để trống thì hiện lỗi và trả về false
        private bool BatBuoc(TextBox txt, string ten)
        {
            if (txt.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txt, "Chưa nhập " + ten);
                return false;
            }
            errorProvider1.SetError(txt, "");
            return true;
        }

        // Email phải nhập và đúng định dạng
        private bool KiemTraEmail()
        {
            if (!BatBuoc(txtEmail, "địa chỉ email"))
                return false;

            if (!mauEmail.IsMatch(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Email không đúng định dạng (vd: abc@gmail.com)");
                return false;
            }
            return true;
        }

        // Xác nhận mật khẩu phải giống mật khẩu đã nhập
        private bool KiemTraXacNhan()
        {
            if (txtXacNhan.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhan, "Mật khẩu xác nhận không khớp");
                return false;
            }
            errorProvider1.SetError(txtXacNhan, "");
            return true;
        }

        // Kiểm tra email ngay khi người dùng nhập xong và rời khỏi ô
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            KiemTraEmail();
        }

        // Gõ lại thì tắt dấu lỗi cũ của ô đó, lỗi mới (nếu có) sẽ báo lại khi rời ô hoặc bấm Đăng ký
        private void txt_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, "");
        }

        // btnDangKy là AcceptButton của form nên nhấn Enter cũng chạy vào đây
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra hết các ô (không dừng ở ô lỗi đầu tiên) để ô nào sai cũng hiện dấu lỗi
            bool tenOk = BatBuoc(txtTenDangNhap, "tên đăng nhập");
            bool emailOk = KiemTraEmail();
            bool matKhauOk = BatBuoc(txtMatKhau, "mật khẩu");
            bool xacNhanOk = KiemTraXacNhan();

            if (!(tenOk && emailOk && matKhauOk && xacNhanOk))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin ở các ô có dấu lỗi!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Đưa con trỏ về ô sai đầu tiên
                if (!tenOk) txtTenDangNhap.Focus();
                else if (!emailOk) txtEmail.Focus();
                else if (!matKhauOk) txtMatKhau.Focus();
                else txtXacNhan.Focus();
                return;
            }

            // Dữ liệu hợp lệ: hiện thông tin của tất cả các textbox
            string s = "Tên đăng nhập: " + txtTenDangNhap.Text.Trim() + Environment.NewLine
                     + "Địa chỉ email: " + txtEmail.Text.Trim() + Environment.NewLine
                     + "Mật khẩu: " + txtMatKhau.Text + Environment.NewLine
                     + "Xác nhận mật khẩu: " + txtXacNhan.Text;
            MessageBox.Show(s, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hỏi xác nhận trước khi đóng form: chọn No thì hủy việc đóng
        private void frmBai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}