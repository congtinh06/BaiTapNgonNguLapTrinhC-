#nullable disable

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
            components = new System.ComponentModel.Container();
            lblTieuDe = new Label();
            lblCapTenKH = new Label();
            txtTenKH = new TextBox();
            lblCapSoKH = new Label();
            txtSoKH = new TextBox();
            chkSinhVien = new CheckBox();
            grpNuocUong = new GroupBox();
            grpThucAn = new GroupBox();
            rdoCafeDen = new RadioButton();
            rdoCafeDa = new RadioButton();
            rdoCafeSua = new RadioButton();
            rdoCafeKem = new RadioButton();
            rdoCafeSuaDa = new RadioButton();
            chkBanhMyTrung = new CheckBox();
            chkMyXaoBo = new CheckBox();
            chkBanhMyCa = new CheckBox();
            chkMyCay = new CheckBox();
            chkMyTomTrung = new CheckBox();
            btnTinhTien = new Button();
            btnNhapLai = new Button();
            btnThanhToan = new Button();
            btnThoat = new Button();
            lblCapTongKhach = new Label();
            lblTongKhach = new Label();
            lblCapTongTien = new Label();
            lblTongTien = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            grpNuocUong.SuspendLayout();
            grpThucAn.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Location = new Point(0, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.AutoSize = false;
            lblTieuDe.Size = new Size(460, 40);
            lblTieuDe.TabIndex = 9;
            lblTieuDe.ForeColor = Color.Chocolate;
            lblTieuDe.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Text = "CAFE SINH VIÊN";
            // 
            // lblCapTenKH
            // 
            lblCapTenKH.Location = new Point(15, 62);
            lblCapTenKH.Name = "lblCapTenKH";
            lblCapTenKH.AutoSize = true;
            lblCapTenKH.TabIndex = 10;
            lblCapTenKH.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapTenKH.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(190, 59);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(250, 23);
            txtTenKH.TabIndex = 0;
            txtTenKH.TextChanged += NhapLieu_Changed;
            txtTenKH.Validating += txtTenKH_Validating;
            // 
            // lblCapSoKH
            // 
            lblCapSoKH.Location = new Point(15, 92);
            lblCapSoKH.Name = "lblCapSoKH";
            lblCapSoKH.AutoSize = true;
            lblCapSoKH.TabIndex = 11;
            lblCapSoKH.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapSoKH.Text = "Số khách hàng";
            // 
            // txtSoKH
            // 
            txtSoKH.Location = new Point(190, 89);
            txtSoKH.Name = "txtSoKH";
            txtSoKH.Size = new Size(250, 23);
            txtSoKH.TabIndex = 1;
            txtSoKH.KeyPress += txtSoKH_KeyPress;
            txtSoKH.TextChanged += NhapLieu_Changed;
            txtSoKH.Validating += txtSoKH_Validating;
            // 
            // chkSinhVien
            // 
            chkSinhVien.Location = new Point(190, 120);
            chkSinhVien.Name = "chkSinhVien";
            chkSinhVien.AutoSize = true;
            chkSinhVien.TabIndex = 2;
            chkSinhVien.UseVisualStyleBackColor = true;
            chkSinhVien.Text = "Sinh viên ?";
            chkSinhVien.CheckedChanged += NhapLieu_Changed;
            // 
            // grpNuocUong
            // 
            grpNuocUong.Controls.Add(rdoCafeDen);
            grpNuocUong.Controls.Add(rdoCafeDa);
            grpNuocUong.Controls.Add(rdoCafeSua);
            grpNuocUong.Controls.Add(rdoCafeKem);
            grpNuocUong.Controls.Add(rdoCafeSuaDa);
            grpNuocUong.Location = new Point(15, 148);
            grpNuocUong.Name = "grpNuocUong";
            grpNuocUong.Size = new Size(205, 135);
            grpNuocUong.TabIndex = 3;
            grpNuocUong.TabStop = false;
            grpNuocUong.Text = "Nước uống";
            // 
            // grpThucAn
            // 
            grpThucAn.Controls.Add(chkBanhMyTrung);
            grpThucAn.Controls.Add(chkMyXaoBo);
            grpThucAn.Controls.Add(chkBanhMyCa);
            grpThucAn.Controls.Add(chkMyCay);
            grpThucAn.Controls.Add(chkMyTomTrung);
            grpThucAn.Location = new Point(230, 148);
            grpThucAn.Name = "grpThucAn";
            grpThucAn.Size = new Size(215, 135);
            grpThucAn.TabIndex = 4;
            grpThucAn.TabStop = false;
            grpThucAn.Text = "Thức ăn";
            // 
            // rdoCafeDen
            // 
            rdoCafeDen.Location = new Point(15, 28);
            rdoCafeDen.Name = "rdoCafeDen";
            rdoCafeDen.AutoSize = true;
            rdoCafeDen.TabIndex = 0;
            rdoCafeDen.UseVisualStyleBackColor = true;
            rdoCafeDen.Text = "Cafe đen";
            rdoCafeDen.CheckedChanged += NhapLieu_Changed;
            // 
            // rdoCafeDa
            // 
            rdoCafeDa.Location = new Point(110, 28);
            rdoCafeDa.Name = "rdoCafeDa";
            rdoCafeDa.AutoSize = true;
            rdoCafeDa.TabIndex = 1;
            rdoCafeDa.UseVisualStyleBackColor = true;
            rdoCafeDa.Text = "Cafe đá";
            rdoCafeDa.CheckedChanged += NhapLieu_Changed;
            // 
            // rdoCafeSua
            // 
            rdoCafeSua.Location = new Point(15, 58);
            rdoCafeSua.Name = "rdoCafeSua";
            rdoCafeSua.AutoSize = true;
            rdoCafeSua.TabIndex = 2;
            rdoCafeSua.UseVisualStyleBackColor = true;
            rdoCafeSua.Text = "Cafe sữa";
            rdoCafeSua.CheckedChanged += NhapLieu_Changed;
            // 
            // rdoCafeKem
            // 
            rdoCafeKem.Location = new Point(110, 58);
            rdoCafeKem.Name = "rdoCafeKem";
            rdoCafeKem.AutoSize = true;
            rdoCafeKem.TabIndex = 3;
            rdoCafeKem.UseVisualStyleBackColor = true;
            rdoCafeKem.Text = "Cafe kem";
            rdoCafeKem.CheckedChanged += NhapLieu_Changed;
            // 
            // rdoCafeSuaDa
            // 
            rdoCafeSuaDa.Location = new Point(15, 88);
            rdoCafeSuaDa.Name = "rdoCafeSuaDa";
            rdoCafeSuaDa.AutoSize = true;
            rdoCafeSuaDa.TabIndex = 4;
            rdoCafeSuaDa.UseVisualStyleBackColor = true;
            rdoCafeSuaDa.Text = "Cafe sữa đá";
            rdoCafeSuaDa.CheckedChanged += NhapLieu_Changed;
            // 
            // chkBanhMyTrung
            // 
            chkBanhMyTrung.Location = new Point(10, 28);
            chkBanhMyTrung.Name = "chkBanhMyTrung";
            chkBanhMyTrung.AutoSize = true;
            chkBanhMyTrung.TabIndex = 0;
            chkBanhMyTrung.UseVisualStyleBackColor = true;
            chkBanhMyTrung.Text = "Bánh mỳ trứng";
            chkBanhMyTrung.CheckedChanged += NhapLieu_Changed;
            // 
            // chkMyXaoBo
            // 
            chkMyXaoBo.Location = new Point(122, 28);
            chkMyXaoBo.Name = "chkMyXaoBo";
            chkMyXaoBo.AutoSize = true;
            chkMyXaoBo.TabIndex = 1;
            chkMyXaoBo.UseVisualStyleBackColor = true;
            chkMyXaoBo.Text = "Mỳ xào bò";
            chkMyXaoBo.CheckedChanged += NhapLieu_Changed;
            // 
            // chkBanhMyCa
            // 
            chkBanhMyCa.Location = new Point(10, 58);
            chkBanhMyCa.Name = "chkBanhMyCa";
            chkBanhMyCa.AutoSize = true;
            chkBanhMyCa.TabIndex = 2;
            chkBanhMyCa.UseVisualStyleBackColor = true;
            chkBanhMyCa.Text = "Bánh mỳ cá";
            chkBanhMyCa.CheckedChanged += NhapLieu_Changed;
            // 
            // chkMyCay
            // 
            chkMyCay.Location = new Point(122, 58);
            chkMyCay.Name = "chkMyCay";
            chkMyCay.AutoSize = true;
            chkMyCay.TabIndex = 3;
            chkMyCay.UseVisualStyleBackColor = true;
            chkMyCay.Text = "Mỳ cay";
            chkMyCay.CheckedChanged += NhapLieu_Changed;
            // 
            // chkMyTomTrung
            // 
            chkMyTomTrung.Location = new Point(10, 88);
            chkMyTomTrung.Name = "chkMyTomTrung";
            chkMyTomTrung.AutoSize = true;
            chkMyTomTrung.TabIndex = 4;
            chkMyTomTrung.UseVisualStyleBackColor = true;
            chkMyTomTrung.Text = "Mỳ tôm trứng";
            chkMyTomTrung.CheckedChanged += NhapLieu_Changed;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(15, 300);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(95, 32);
            btnTinhTien.TabIndex = 5;
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(120, 300);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(95, 32);
            btnNhapLai.TabIndex = 6;
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.CausesValidation = false;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(225, 300);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(105, 32);
            btnThanhToan.TabIndex = 7;
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(340, 300);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 32);
            btnThoat.TabIndex = 8;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.CausesValidation = false;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // lblCapTongKhach
            // 
            lblCapTongKhach.Location = new Point(15, 352);
            lblCapTongKhach.Name = "lblCapTongKhach";
            lblCapTongKhach.AutoSize = true;
            lblCapTongKhach.TabIndex = 12;
            lblCapTongKhach.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapTongKhach.Text = "Tổng khách hàng";
            // 
            // lblTongKhach
            // 
            lblTongKhach.Location = new Point(190, 347);
            lblTongKhach.Name = "lblTongKhach";
            lblTongKhach.AutoSize = false;
            lblTongKhach.Size = new Size(250, 26);
            lblTongKhach.TabIndex = 13;
            lblTongKhach.BorderStyle = BorderStyle.FixedSingle;
            lblTongKhach.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCapTongTien
            // 
            lblCapTongTien.Location = new Point(15, 384);
            lblCapTongTien.Name = "lblCapTongTien";
            lblCapTongTien.AutoSize = true;
            lblCapTongTien.TabIndex = 14;
            lblCapTongTien.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapTongTien.Text = "Tổng tiền thanh toán";
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(190, 379);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.AutoSize = false;
            lblTongTien.Size = new Size(250, 26);
            lblTongTien.TabIndex = 15;
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBai3
            // 
            AcceptButton = btnTinhTien;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(460, 420);
            Controls.Add(lblTieuDe);
            Controls.Add(lblCapTenKH);
            Controls.Add(txtTenKH);
            Controls.Add(lblCapSoKH);
            Controls.Add(txtSoKH);
            Controls.Add(chkSinhVien);
            Controls.Add(grpNuocUong);
            Controls.Add(grpThucAn);
            Controls.Add(btnTinhTien);
            Controls.Add(btnNhapLai);
            Controls.Add(btnThanhToan);
            Controls.Add(btnThoat);
            Controls.Add(lblCapTongKhach);
            Controls.Add(lblTongKhach);
            Controls.Add(lblCapTongTien);
            Controls.Add(lblTongTien);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh toán tiền";
            FormClosing += frmBai3_FormClosing;
            Load += frmBai3_Load;
            grpNuocUong.ResumeLayout(false);
            grpNuocUong.PerformLayout();
            grpThucAn.ResumeLayout(false);
            grpThucAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblCapTenKH;
        private TextBox txtTenKH;
        private Label lblCapSoKH;
        private TextBox txtSoKH;
        private CheckBox chkSinhVien;
        private GroupBox grpNuocUong;
        private GroupBox grpThucAn;
        private RadioButton rdoCafeDen;
        private RadioButton rdoCafeDa;
        private RadioButton rdoCafeSua;
        private RadioButton rdoCafeKem;
        private RadioButton rdoCafeSuaDa;
        private CheckBox chkBanhMyTrung;
        private CheckBox chkMyXaoBo;
        private CheckBox chkBanhMyCa;
        private CheckBox chkMyCay;
        private CheckBox chkMyTomTrung;
        private Button btnTinhTien;
        private Button btnNhapLai;
        private Button btnThanhToan;
        private Button btnThoat;
        private Label lblCapTongKhach;
        private Label lblTongKhach;
        private Label lblCapTongTien;
        private Label lblTongTien;
        private ErrorProvider errorProvider1;
    }
}