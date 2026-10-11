namespace Bai2
{
    partial class frmBai2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDe = new Label();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblSaoTenDangNhap = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSaoEmail = new Label();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblSaoMatKhau = new Label();
            lblXacNhan = new Label();
            txtXacNhan = new TextBox();
            btnDangKy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DodgerBlue;
            lblTieuDe.Location = new Point(0, 14);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(410, 34);
            lblTieuDe.Text = "Đăng ký tài khoản";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(20, 73);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(160, 70);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(180, 25);
            txtTenDangNhap.TabIndex = 1;
            txtTenDangNhap.TextChanged += txt_TextChanged;
            // 
            // lblSaoTenDangNhap
            // 
            lblSaoTenDangNhap.AutoSize = true;
            lblSaoTenDangNhap.Location = new Point(365, 73);
            lblSaoTenDangNhap.Name = "lblSaoTenDangNhap";
            lblSaoTenDangNhap.Text = "(*)";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 113);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Địa chỉ email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 25);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txt_TextChanged;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // lblSaoEmail
            // 
            lblSaoEmail.AutoSize = true;
            lblSaoEmail.Location = new Point(365, 113);
            lblSaoEmail.Name = "lblSaoEmail";
            lblSaoEmail.Text = "(*)";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(20, 153);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(160, 150);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(180, 25);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.TextChanged += txt_TextChanged;
            // 
            // lblSaoMatKhau
            // 
            lblSaoMatKhau.AutoSize = true;
            lblSaoMatKhau.Location = new Point(365, 153);
            lblSaoMatKhau.Name = "lblSaoMatKhau";
            lblSaoMatKhau.Text = "(*)";
            // 
            // lblXacNhan
            // 
            lblXacNhan.AutoSize = true;
            lblXacNhan.Location = new Point(20, 193);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.TabIndex = 6;
            lblXacNhan.Text = "Xác nhận mật khẩu";
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(160, 190);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(180, 25);
            txtXacNhan.TabIndex = 7;
            txtXacNhan.UseSystemPasswordChar = true;
            txtXacNhan.TextChanged += txt_TextChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.DodgerBlue;
            btnDangKy.Location = new Point(160, 235);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(180, 40);
            btnDangKy.TabIndex = 8;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBai2
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 300);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblSaoTenDangNhap);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSaoEmail);
            Controls.Add(lblMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(lblSaoMatKhau);
            Controls.Add(lblXacNhan);
            Controls.Add(txtXacNhan);
            Controls.Add(btnDangKy);
            Font = new Font("Tahoma", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            FormClosing += frmBai2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblSaoTenDangNhap;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSaoEmail;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblSaoMatKhau;
        private Label lblXacNhan;
        private TextBox txtXacNhan;
        private Button btnDangKy;
        private ErrorProvider errorProvider1;
    }
}