namespace BaiTL1
{
    partial class frmBaiTL1
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
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.grpChon = new GroupBox();
            this.rdoBacNhat = new RadioButton();
            this.rdoBacHai = new RadioButton();
            this.lblNhapA = new Label();
            this.lblNhapB = new Label();
            this.lblNhapC = new Label();
            this.txtA = new TextBox();
            this.txtB = new TextBox();
            this.txtC = new TextBox();
            this.btnGiai = new Button();
            this.btnThoat = new Button();
            this.lblKetQua = new Label();
            this.txtKetQua = new TextBox();
            this.errorProvider1 = new ErrorProvider(this.components);
            this.grpChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 8);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(296, 36);
            this.lblTieuDe.TabIndex = 7;
            this.lblTieuDe.Text = "GIẢI PHƯƠNG TRÌNH";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpChon
            // 
            this.grpChon.Controls.Add(this.rdoBacNhat);
            this.grpChon.Controls.Add(this.rdoBacHai);
            this.grpChon.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.grpChon.Location = new System.Drawing.Point(15, 50);
            this.grpChon.Name = "grpChon";
            this.grpChon.Size = new System.Drawing.Size(266, 82);
            this.grpChon.TabIndex = 0;
            this.grpChon.TabStop = false;
            this.grpChon.Text = "Bạn vui lòng chọn";
            // 
            // rdoBacNhat
            // 
            this.rdoBacNhat.AutoSize = true;
            this.rdoBacNhat.Checked = true;
            this.rdoBacNhat.Location = new System.Drawing.Point(25, 24);
            this.rdoBacNhat.Name = "rdoBacNhat";
            this.rdoBacNhat.Size = new System.Drawing.Size(150, 20);
            this.rdoBacNhat.TabIndex = 0;
            this.rdoBacNhat.TabStop = true;
            this.rdoBacNhat.Text = "Phương trình bậc nhất";
            this.rdoBacNhat.UseVisualStyleBackColor = true;
            this.rdoBacNhat.CheckedChanged += new System.EventHandler(this.rdoBac_CheckedChanged);
            // 
            // rdoBacHai
            // 
            this.rdoBacHai.AutoSize = true;
            this.rdoBacHai.Location = new System.Drawing.Point(25, 50);
            this.rdoBacHai.Name = "rdoBacHai";
            this.rdoBacHai.Size = new System.Drawing.Size(140, 20);
            this.rdoBacHai.TabIndex = 1;
            this.rdoBacHai.Text = "Phương trình bậc hai";
            this.rdoBacHai.UseVisualStyleBackColor = true;
            this.rdoBacHai.CheckedChanged += new System.EventHandler(this.rdoBac_CheckedChanged);
            // 
            // lblNhapA
            // 
            this.lblNhapA.AutoSize = true;
            this.lblNhapA.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNhapA.Location = new System.Drawing.Point(15, 152);
            this.lblNhapA.Name = "lblNhapA";
            this.lblNhapA.Size = new System.Drawing.Size(60, 16);
            this.lblNhapA.TabIndex = 1;
            this.lblNhapA.Text = "Nhập a";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtA.Location = new System.Drawing.Point(85, 148);
            this.txtA.MaxLength = 15;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(115, 23);
            this.txtA.TabIndex = 2;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA.TextChanged += new System.EventHandler(this.txtHeSo_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeSo_KeyPress);
            // 
            // lblNhapB
            // 
            this.lblNhapB.AutoSize = true;
            this.lblNhapB.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNhapB.Location = new System.Drawing.Point(15, 184);
            this.lblNhapB.Name = "lblNhapB";
            this.lblNhapB.Size = new System.Drawing.Size(60, 16);
            this.lblNhapB.TabIndex = 3;
            this.lblNhapB.Text = "Nhập b";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtB.Location = new System.Drawing.Point(85, 180);
            this.txtB.MaxLength = 15;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(115, 23);
            this.txtB.TabIndex = 4;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB.TextChanged += new System.EventHandler(this.txtHeSo_TextChanged);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeSo_KeyPress);
            // 
            // lblNhapC
            // 
            this.lblNhapC.AutoSize = true;
            this.lblNhapC.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNhapC.Location = new System.Drawing.Point(15, 216);
            this.lblNhapC.Name = "lblNhapC";
            this.lblNhapC.Size = new System.Drawing.Size(60, 16);
            this.lblNhapC.TabIndex = 5;
            this.lblNhapC.Text = "Nhập c";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtC.Location = new System.Drawing.Point(85, 212);
            this.txtC.MaxLength = 15;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(115, 23);
            this.txtC.TabIndex = 6;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtC.TextChanged += new System.EventHandler(this.txtHeSo_TextChanged);
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeSo_KeyPress);
            this.lblNhapC.Enabled = false;
            this.txtC.Enabled = false;
            // 
            // btnGiai
            // 
            this.btnGiai.Enabled = false;
            this.btnGiai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnGiai.Location = new System.Drawing.Point(210, 146);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(71, 32);
            this.btnGiai.TabIndex = 8;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThoat.Location = new System.Drawing.Point(210, 186);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(71, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblKetQua.Location = new System.Drawing.Point(15, 255);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(60, 16);
            this.lblKetQua.TabIndex = 10;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.txtKetQua.Location = new System.Drawing.Point(85, 252);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(196, 62);
            this.txtKetQua.TabIndex = 11;
            this.txtKetQua.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBaiTL1
            // 
            this.AcceptButton = this.btnGiai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 330);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpChon);
            this.Controls.Add(this.lblNhapA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblNhapB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblNhapC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBaiTL1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giải phương trình bậc 1-2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaiTL1_FormClosing);
            this.Load += new System.EventHandler(this.frmBaiTL1_Load);
            this.grpChon.ResumeLayout(false);
            this.grpChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private GroupBox grpChon;
        private RadioButton rdoBacNhat;
        private RadioButton rdoBacHai;
        private Label lblNhapA;
        private Label lblNhapB;
        private Label lblNhapC;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Button btnGiai;
        private Button btnThoat;
        private Label lblKetQua;
        private TextBox txtKetQua;
        private ErrorProvider errorProvider1;
    }
}