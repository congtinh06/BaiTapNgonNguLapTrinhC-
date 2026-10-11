namespace BaiTapTrenLop
{
    partial class frmBai1
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
            lblA = new Label();
            lblB = new Label();
            lblKetQua = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(20, 22);
            lblA.Name = "lblA";
            lblA.Size = new Size(31, 18);
            lblA.TabIndex = 0;
            lblA.Text = "a =";
            // 
            // txtA
            // 
            txtA.BorderStyle = BorderStyle.FixedSingle;
            txtA.Location = new Point(70, 19);
            txtA.Name = "txtA";
            txtA.Size = new Size(110, 25);
            txtA.TabIndex = 1;
            txtA.TextChanged += txtSo_TextChanged;
            txtA.KeyPress += ChiNhapSo_KeyPress;
            txtA.Leave += txtA_Leave;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(215, 22);
            lblB.Name = "lblB";
            lblB.Size = new Size(32, 18);
            lblB.TabIndex = 2;
            lblB.Text = "b =";
            // 
            // txtB
            // 
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.Location = new Point(260, 19);
            txtB.Name = "txtB";
            txtB.Size = new Size(110, 25);
            txtB.TabIndex = 3;
            txtB.TextChanged += txtSo_TextChanged;
            txtB.KeyPress += ChiNhapSo_KeyPress;
            txtB.Leave += txtB_Leave;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new Point(20, 62);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(55, 18);
            lblKetQua.TabIndex = 4;
            lblKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            txtKetQua.BorderStyle = BorderStyle.FixedSingle;
            txtKetQua.Location = new Point(90, 59);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(280, 25);
            txtKetQua.TabStop = false;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(20, 105);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(80, 34);
            btnCong.TabIndex = 5;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(110, 105);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(80, 34);
            btnTru.TabIndex = 6;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(200, 105);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(80, 34);
            btnNhan.TabIndex = 7;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(290, 105);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(80, 34);
            btnChia.TabIndex = 8;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 161);
            Controls.Add(lblA);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cộng trừ nhân chia";
            FormClosing += frmBai1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private Label lblKetQua;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private ErrorProvider errorProvider1;
    }
}