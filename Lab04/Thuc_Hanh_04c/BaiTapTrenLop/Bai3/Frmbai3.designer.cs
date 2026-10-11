namespace Bai3
{
    partial class frmBai3
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
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            lblUCLN = new Label();
            txtUCLN = new TextBox();
            lblBCNN = new Label();
            txtBCNN = new TextBox();
            btnThucHien = new Button();
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
            lblTieuDe.Size = new Size(400, 34);
            lblTieuDe.Text = "Ước Số Chung - Bội Số Chung";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(40, 73);
            lblA.Name = "lblA";
            lblA.Text = "Nhập số a :";
            // 
            // txtA
            // 
            txtA.Location = new Point(215, 70);
            txtA.Name = "txtA";
            txtA.Size = new Size(140, 25);
            txtA.TabIndex = 0;
            txtA.KeyPress += ChiNhapSo_KeyPress;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(40, 108);
            lblB.Name = "lblB";
            lblB.Text = "Nhập số b :";
            // 
            // txtB
            // 
            txtB.Location = new Point(215, 105);
            txtB.Name = "txtB";
            txtB.Size = new Size(140, 25);
            txtB.TabIndex = 1;
            txtB.KeyPress += ChiNhapSo_KeyPress;
            // 
            // lblUCLN
            // 
            lblUCLN.AutoSize = true;
            lblUCLN.Location = new Point(40, 148);
            lblUCLN.Name = "lblUCLN";
            lblUCLN.Text = "Ước số chung lớn nhất :";
            // 
            // txtUCLN
            // 
            txtUCLN.Location = new Point(215, 145);
            txtUCLN.Name = "txtUCLN";
            txtUCLN.Size = new Size(140, 25);
            txtUCLN.ReadOnly = true;
            txtUCLN.TabStop = false;
            // 
            // lblBCNN
            // 
            lblBCNN.AutoSize = true;
            lblBCNN.Location = new Point(40, 183);
            lblBCNN.Name = "lblBCNN";
            lblBCNN.Text = "Bội số chung nhỏ nhất :";
            // 
            // txtBCNN
            // 
            txtBCNN.Location = new Point(215, 180);
            txtBCNN.Name = "txtBCNN";
            txtBCNN.Size = new Size(140, 25);
            txtBCNN.ReadOnly = true;
            txtBCNN.TabStop = false;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(25, 240);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(105, 34);
            btnThucHien.TabIndex = 2;
            btnThucHien.Text = "Thực Hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(150, 240);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(105, 34);
            btnTiepTuc.TabIndex = 3;
            btnTiepTuc.Text = "Tiếp Tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(275, 240);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(105, 34);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBai3
            // 
            AcceptButton = btnThucHien;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(lblTieuDe);
            Controls.Add(lblA);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(lblUCLN);
            Controls.Add(txtUCLN);
            Controls.Add(lblBCNN);
            Controls.Add(txtBCNN);
            Controls.Add(btnThucHien);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnThoat);
            Font = new Font("Tahoma", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ước Số - Bội Số";
            FormClosing += frmBai3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private TextBox txtB;
        private Label lblUCLN;
        private TextBox txtUCLN;
        private Label lblBCNN;
        private TextBox txtBCNN;
        private Button btnThucHien;
        private Button btnTiepTuc;
        private Button btnThoat;
    }
}