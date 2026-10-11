namespace Bai4
{
    partial class frmBai4
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
            lblTieuDe = new Label();
            lblNhap = new Label();
            txtNhap = new TextBox();
            btnNhap = new Button();
            lblDay = new Label();
            txtDay = new TextBox();
            lblTong = new Label();
            txtTong = new TextBox();
            lblChan = new Label();
            txtChan = new TextBox();
            lblLe = new Label();
            txtLe = new TextBox();
            btnTinhTong = new Button();
            btnTiepTuc = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Red;
            lblTieuDe.Location = new Point(0, 14);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(420, 34);
            lblTieuDe.Text = "Nhập Dãy Số và Tính Tổng";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNhap
            // 
            lblNhap.AutoSize = true;
            lblNhap.Location = new Point(20, 68);
            lblNhap.Name = "lblNhap";
            lblNhap.Text = "Nhập số :";
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(150, 65);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(90, 25);
            txtNhap.TabIndex = 0;
            txtNhap.KeyPress += txtNhap_KeyPress;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(260, 62);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(100, 30);
            btnNhap.TabIndex = 1;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Location = new Point(20, 108);
            lblDay.Name = "lblDay";
            lblDay.Text = "Dãy vừa nhập :";
            // 
            // txtDay
            // 
            txtDay.Location = new Point(150, 105);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(250, 25);
            txtDay.ReadOnly = true;
            txtDay.TabStop = false;
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Location = new Point(20, 148);
            lblTong.Name = "lblTong";
            lblTong.Text = "Tổng các phần tử trong dãy :";
            // 
            // txtTong
            // 
            txtTong.Location = new Point(230, 145);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(170, 25);
            txtTong.ReadOnly = true;
            txtTong.TabStop = false;
            // 
            // lblChan
            // 
            lblChan.AutoSize = true;
            lblChan.Location = new Point(20, 188);
            lblChan.Name = "lblChan";
            lblChan.Text = "Tổng chẵn :";
            // 
            // txtChan
            // 
            txtChan.Location = new Point(110, 185);
            txtChan.Name = "txtChan";
            txtChan.Size = new Size(100, 25);
            txtChan.ReadOnly = true;
            txtChan.TabStop = false;
            // 
            // lblLe
            // 
            lblLe.AutoSize = true;
            lblLe.Location = new Point(235, 188);
            lblLe.Name = "lblLe";
            lblLe.Text = "Tổng lẻ :";
            // 
            // txtLe
            // 
            txtLe.Location = new Point(300, 185);
            txtLe.Name = "txtLe";
            txtLe.Size = new Size(100, 25);
            txtLe.ReadOnly = true;
            txtLe.TabStop = false;
            // 
            // btnTinhTong
            // 
            btnTinhTong.Location = new Point(20, 240);
            btnTinhTong.Name = "btnTinhTong";
            btnTinhTong.Size = new Size(120, 36);
            btnTinhTong.TabIndex = 2;
            btnTinhTong.Text = "Tính Tổng";
            btnTinhTong.UseVisualStyleBackColor = true;
            btnTinhTong.Click += btnTinhTong_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(150, 240);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(120, 36);
            btnTiepTuc.TabIndex = 3;
            btnTiepTuc.Text = "Tiếp Tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(280, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 36);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBai4
            // 
            AcceptButton = btnNhap;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 300);
            Controls.Add(lblTieuDe);
            Controls.Add(lblNhap);
            Controls.Add(txtNhap);
            Controls.Add(btnNhap);
            Controls.Add(lblDay);
            Controls.Add(txtDay);
            Controls.Add(lblTong);
            Controls.Add(txtTong);
            Controls.Add(lblChan);
            Controls.Add(txtChan);
            Controls.Add(lblLe);
            Controls.Add(txtLe);
            Controls.Add(btnTinhTong);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnThoat);
            Font = new Font("Tahoma", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dãy số và Tính Tổng";
            FormClosing += frmBai4_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblNhap;
        private TextBox txtNhap;
        private Button btnNhap;
        private Label lblDay;
        private TextBox txtDay;
        private Label lblTong;
        private TextBox txtTong;
        private Label lblChan;
        private TextBox txtChan;
        private Label lblLe;
        private TextBox txtLe;
        private Button btnTinhTong;
        private Button btnTiepTuc;
        private Button btnThoat;
    }
}