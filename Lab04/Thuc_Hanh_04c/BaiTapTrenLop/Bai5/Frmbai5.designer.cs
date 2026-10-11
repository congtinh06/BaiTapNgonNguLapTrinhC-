namespace Bai5
{
    partial class frmBai5
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
            txtSo = new TextBox();
            btnThucHien = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Red;
            lblTieuDe.Location = new Point(0, 14);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(400, 34);
            lblTieuDe.Text = "Đọc Số Thành Chữ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNhap
            // 
            lblNhap.AutoSize = true;
            lblNhap.Location = new Point(20, 71);
            lblNhap.Name = "lblNhap";
            lblNhap.Text = "Nhập dãy số : ( từ 1 đến 999 )";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(265, 68);
            txtSo.MaxLength = 3;
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(110, 25);
            txtSo.TabIndex = 0;
            txtSo.KeyPress += txtSo_KeyPress;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(25, 115);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(105, 34);
            btnThucHien.TabIndex = 1;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(150, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(275, 115);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 34);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblKetQua
            // 
            lblKetQua.BackColor = Color.PeachPuff;
            lblKetQua.ForeColor = Color.Blue;
            lblKetQua.Location = new Point(25, 170);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(350, 32);
            lblKetQua.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmBai5
            // 
            AcceptButton = btnThucHien;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 225);
            Controls.Add(lblTieuDe);
            Controls.Add(lblNhap);
            Controls.Add(txtSo);
            Controls.Add(btnThucHien);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(lblKetQua);
            Font = new Font("Tahoma", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tâm Gà - Đọc Chữ Số";
            FormClosing += frmBai5_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblNhap;
        private TextBox txtSo;
        private Button btnThucHien;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblKetQua;
    }
}