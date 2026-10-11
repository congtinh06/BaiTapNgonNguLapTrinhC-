#nullable disable

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
            components = new System.ComponentModel.Container();
            lblTieuDe = new Label();
            pnlKhach = new Panel();
            lblHoTenCap = new Label();
            txtHoTen = new TextBox();
            lblDiaChiCap = new Label();
            txtDiaChi = new TextBox();
            lblSoNgayCap = new Label();
            txtSoNgay = new TextBox();
            grpLoaiPhong = new GroupBox();
            grpTienNghi = new GroupBox();
            grpDichVu = new GroupBox();
            rdoPhongDon = new RadioButton();
            rdoPhongDoi = new RadioButton();
            rdoPhongBa = new RadioButton();
            chkTivi = new CheckBox();
            chkInternet = new CheckBox();
            chkMayNuocNong = new CheckBox();
            chkKaraoke = new CheckBox();
            chkAnSang = new CheckBox();
            btnThanhToan = new Button();
            btnNhapMoi = new Button();
            lblThanhTienCap = new Label();
            lblThanhTien = new Label();
            btnTongKet = new Button();
            grpTongKet = new GroupBox();
            lblSoLuotCap = new Label();
            lblSoLuot = new Label();
            lblTongTienCap = new Label();
            lblTongTien = new Label();
            btnThoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlKhach.SuspendLayout();
            grpLoaiPhong.SuspendLayout();
            grpTienNghi.SuspendLayout();
            grpDichVu.SuspendLayout();
            grpTongKet.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Location = new Point(10, 8);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.AutoSize = false;
            lblTieuDe.Size = new Size(640, 38);
            lblTieuDe.TabIndex = 5;
            lblTieuDe.BorderStyle = BorderStyle.FixedSingle;
            lblTieuDe.ForeColor = Color.OrangeRed;
            lblTieuDe.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            // 
            // pnlKhach
            // 
            pnlKhach.Controls.Add(lblHoTenCap);
            pnlKhach.Controls.Add(txtHoTen);
            pnlKhach.Controls.Add(lblDiaChiCap);
            pnlKhach.Controls.Add(txtDiaChi);
            pnlKhach.Controls.Add(lblSoNgayCap);
            pnlKhach.Controls.Add(txtSoNgay);
            pnlKhach.Controls.Add(grpLoaiPhong);
            pnlKhach.Controls.Add(grpTienNghi);
            pnlKhach.Controls.Add(grpDichVu);
            pnlKhach.Location = new Point(10, 55);
            pnlKhach.Name = "pnlKhach";
            pnlKhach.Size = new Size(385, 250);
            pnlKhach.TabIndex = 0;
            // 
            // lblHoTenCap
            // 
            lblHoTenCap.Location = new Point(25, 17);
            lblHoTenCap.Name = "lblHoTenCap";
            lblHoTenCap.AutoSize = true;
            lblHoTenCap.TabIndex = 0;
            lblHoTenCap.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(100, 13);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(270, 23);
            txtHoTen.TabIndex = 1;
            txtHoTen.TextChanged += NhapLieu_Changed;
            txtHoTen.Validating += txtHoTen_Validating;
            // 
            // lblDiaChiCap
            // 
            lblDiaChiCap.Location = new Point(37, 47);
            lblDiaChiCap.Name = "lblDiaChiCap";
            lblDiaChiCap.AutoSize = true;
            lblDiaChiCap.TabIndex = 2;
            lblDiaChiCap.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(100, 43);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(270, 23);
            txtDiaChi.TabIndex = 3;
            txtDiaChi.TextChanged += NhapLieu_Changed;
            txtDiaChi.Validating += txtDiaChi_Validating;
            // 
            // lblSoNgayCap
            // 
            lblSoNgayCap.Location = new Point(24, 82);
            lblSoNgayCap.Name = "lblSoNgayCap";
            lblSoNgayCap.AutoSize = true;
            lblSoNgayCap.TabIndex = 4;
            lblSoNgayCap.Text = "Số ngày ở:";
            // 
            // txtSoNgay
            // 
            txtSoNgay.Location = new Point(100, 78);
            txtSoNgay.Name = "txtSoNgay";
            txtSoNgay.Size = new Size(100, 23);
            txtSoNgay.TabIndex = 5;
            txtSoNgay.KeyPress += txtSoNgay_KeyPress;
            txtSoNgay.TextChanged += NhapLieu_Changed;
            txtSoNgay.Validating += txtSoNgay_Validating;
            // 
            // grpLoaiPhong
            // 
            grpLoaiPhong.Controls.Add(rdoPhongDon);
            grpLoaiPhong.Controls.Add(rdoPhongDoi);
            grpLoaiPhong.Controls.Add(rdoPhongBa);
            grpLoaiPhong.Location = new Point(5, 112);
            grpLoaiPhong.Name = "grpLoaiPhong";
            grpLoaiPhong.Size = new Size(115, 125);
            grpLoaiPhong.TabIndex = 6;
            grpLoaiPhong.TabStop = false;
            grpLoaiPhong.Text = "Loại phòng";
            // 
            // grpTienNghi
            // 
            grpTienNghi.Controls.Add(chkTivi);
            grpTienNghi.Controls.Add(chkInternet);
            grpTienNghi.Controls.Add(chkMayNuocNong);
            grpTienNghi.Location = new Point(125, 112);
            grpTienNghi.Name = "grpTienNghi";
            grpTienNghi.Size = new Size(135, 125);
            grpTienNghi.TabIndex = 7;
            grpTienNghi.TabStop = false;
            grpTienNghi.Text = "Tiện nghi";
            // 
            // grpDichVu
            // 
            grpDichVu.Controls.Add(chkKaraoke);
            grpDichVu.Controls.Add(chkAnSang);
            grpDichVu.Location = new Point(265, 112);
            grpDichVu.Name = "grpDichVu";
            grpDichVu.Size = new Size(115, 125);
            grpDichVu.TabIndex = 8;
            grpDichVu.TabStop = false;
            grpDichVu.Text = "Dịch vụ";
            // 
            // rdoPhongDon
            // 
            rdoPhongDon.Location = new Point(10, 28);
            rdoPhongDon.Name = "rdoPhongDon";
            rdoPhongDon.AutoSize = true;
            rdoPhongDon.TabIndex = 0;
            rdoPhongDon.UseVisualStyleBackColor = true;
            rdoPhongDon.Text = "Phòng đơn";
            rdoPhongDon.CheckedChanged += NhapLieu_Changed;
            // 
            // rdoPhongDoi
            // 
            rdoPhongDoi.Location = new Point(10, 62);
            rdoPhongDoi.Name = "rdoPhongDoi";
            rdoPhongDoi.AutoSize = true;
            rdoPhongDoi.TabIndex = 1;
            rdoPhongDoi.UseVisualStyleBackColor = true;
            rdoPhongDoi.Text = "Phòng đôi";
            rdoPhongDoi.CheckedChanged += NhapLieu_Changed;
            // 
            // rdoPhongBa
            // 
            rdoPhongBa.Location = new Point(10, 96);
            rdoPhongBa.Name = "rdoPhongBa";
            rdoPhongBa.AutoSize = true;
            rdoPhongBa.TabIndex = 2;
            rdoPhongBa.UseVisualStyleBackColor = true;
            rdoPhongBa.Text = "Phòng ba";
            rdoPhongBa.CheckedChanged += NhapLieu_Changed;
            // 
            // chkTivi
            // 
            chkTivi.Location = new Point(10, 28);
            chkTivi.Name = "chkTivi";
            chkTivi.AutoSize = true;
            chkTivi.TabIndex = 0;
            chkTivi.UseVisualStyleBackColor = true;
            chkTivi.Text = "Tivi";
            chkTivi.CheckedChanged += NhapLieu_Changed;
            // 
            // chkInternet
            // 
            chkInternet.Location = new Point(10, 62);
            chkInternet.Name = "chkInternet";
            chkInternet.AutoSize = true;
            chkInternet.TabIndex = 1;
            chkInternet.UseVisualStyleBackColor = true;
            chkInternet.Text = "Internet";
            chkInternet.CheckedChanged += NhapLieu_Changed;
            // 
            // chkMayNuocNong
            // 
            chkMayNuocNong.Location = new Point(10, 96);
            chkMayNuocNong.Name = "chkMayNuocNong";
            chkMayNuocNong.AutoSize = true;
            chkMayNuocNong.TabIndex = 2;
            chkMayNuocNong.UseVisualStyleBackColor = true;
            chkMayNuocNong.Text = "Máy nước nóng";
            chkMayNuocNong.CheckedChanged += NhapLieu_Changed;
            // 
            // chkKaraoke
            // 
            chkKaraoke.Location = new Point(10, 40);
            chkKaraoke.Name = "chkKaraoke";
            chkKaraoke.AutoSize = true;
            chkKaraoke.TabIndex = 0;
            chkKaraoke.UseVisualStyleBackColor = true;
            chkKaraoke.Text = "Karaoke";
            chkKaraoke.CheckedChanged += NhapLieu_Changed;
            // 
            // chkAnSang
            // 
            chkAnSang.Location = new Point(10, 80);
            chkAnSang.Name = "chkAnSang";
            chkAnSang.AutoSize = true;
            chkAnSang.TabIndex = 1;
            chkAnSang.UseVisualStyleBackColor = true;
            chkAnSang.Text = "Ăn sáng";
            chkAnSang.CheckedChanged += NhapLieu_Changed;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(405, 58);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(115, 30);
            btnThanhToan.TabIndex = 1;
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnNhapMoi
            // 
            btnNhapMoi.Location = new Point(530, 58);
            btnNhapMoi.Name = "btnNhapMoi";
            btnNhapMoi.Size = new Size(115, 30);
            btnNhapMoi.TabIndex = 2;
            btnNhapMoi.UseVisualStyleBackColor = true;
            btnNhapMoi.CausesValidation = false;
            btnNhapMoi.Text = "Nhập mới";
            btnNhapMoi.Click += btnNhapMoi_Click;
            // 
            // lblThanhTienCap
            // 
            lblThanhTienCap.Location = new Point(405, 108);
            lblThanhTienCap.Name = "lblThanhTienCap";
            lblThanhTienCap.AutoSize = true;
            lblThanhTienCap.TabIndex = 6;
            lblThanhTienCap.Text = "Thành tiền:";
            // 
            // lblThanhTien
            // 
            lblThanhTien.Location = new Point(490, 104);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.AutoSize = false;
            lblThanhTien.Size = new Size(155, 26);
            lblThanhTien.TabIndex = 7;
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTongKet
            // 
            btnTongKet.Location = new Point(405, 145);
            btnTongKet.Name = "btnTongKet";
            btnTongKet.Size = new Size(100, 30);
            btnTongKet.TabIndex = 3;
            btnTongKet.UseVisualStyleBackColor = true;
            btnTongKet.Text = "Tổng Kết";
            btnTongKet.Click += btnTongKet_Click;
            // 
            // grpTongKet
            // 
            grpTongKet.Controls.Add(lblSoLuotCap);
            grpTongKet.Controls.Add(lblSoLuot);
            grpTongKet.Controls.Add(lblTongTienCap);
            grpTongKet.Controls.Add(lblTongTien);
            grpTongKet.Location = new Point(405, 185);
            grpTongKet.Name = "grpTongKet";
            grpTongKet.Size = new Size(240, 95);
            grpTongKet.TabIndex = 8;
            grpTongKet.TabStop = false;
            grpTongKet.Text = "Thông tin tổng kết";
            // 
            // lblSoLuotCap
            // 
            lblSoLuotCap.Location = new Point(12, 30);
            lblSoLuotCap.Name = "lblSoLuotCap";
            lblSoLuotCap.AutoSize = true;
            lblSoLuotCap.TabIndex = 0;
            lblSoLuotCap.Text = "Số lượt người:";
            // 
            // lblSoLuot
            // 
            lblSoLuot.Location = new Point(120, 26);
            lblSoLuot.Name = "lblSoLuot";
            lblSoLuot.AutoSize = false;
            lblSoLuot.Size = new Size(110, 26);
            lblSoLuot.TabIndex = 1;
            lblSoLuot.BorderStyle = BorderStyle.FixedSingle;
            lblSoLuot.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongTienCap
            // 
            lblTongTienCap.Location = new Point(12, 62);
            lblTongTienCap.Name = "lblTongTienCap";
            lblTongTienCap.AutoSize = true;
            lblTongTienCap.TabIndex = 2;
            lblTongTienCap.Text = "Tổng số tiền:";
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(120, 58);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.AutoSize = false;
            lblTongTien.Size = new Size(110, 26);
            lblTongTien.TabIndex = 3;
            lblTongTien.BorderStyle = BorderStyle.FixedSingle;
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(405, 292);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 30);
            btnThoat.TabIndex = 4;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.CausesValidation = false;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBai4
            // 
            AcceptButton = btnThanhToan;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(660, 335);
            Controls.Add(lblTieuDe);
            Controls.Add(pnlKhach);
            Controls.Add(btnThanhToan);
            Controls.Add(btnNhapMoi);
            Controls.Add(lblThanhTienCap);
            Controls.Add(lblThanhTien);
            Controls.Add(btnTongKet);
            Controls.Add(grpTongKet);
            Controls.Add(btnThoat);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangkyKS";
            FormClosing += frmBai4_FormClosing;
            Load += frmBai4_Load;
            pnlKhach.ResumeLayout(false);
            pnlKhach.PerformLayout();
            grpLoaiPhong.ResumeLayout(false);
            grpLoaiPhong.PerformLayout();
            grpTienNghi.ResumeLayout(false);
            grpTienNghi.PerformLayout();
            grpDichVu.ResumeLayout(false);
            grpDichVu.PerformLayout();
            grpTongKet.ResumeLayout(false);
            grpTongKet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Panel pnlKhach;
        private Label lblHoTenCap;
        private TextBox txtHoTen;
        private Label lblDiaChiCap;
        private TextBox txtDiaChi;
        private Label lblSoNgayCap;
        private TextBox txtSoNgay;
        private GroupBox grpLoaiPhong;
        private GroupBox grpTienNghi;
        private GroupBox grpDichVu;
        private RadioButton rdoPhongDon;
        private RadioButton rdoPhongDoi;
        private RadioButton rdoPhongBa;
        private CheckBox chkTivi;
        private CheckBox chkInternet;
        private CheckBox chkMayNuocNong;
        private CheckBox chkKaraoke;
        private CheckBox chkAnSang;
        private Button btnThanhToan;
        private Button btnNhapMoi;
        private Label lblThanhTienCap;
        private Label lblThanhTien;
        private Button btnTongKet;
        private GroupBox grpTongKet;
        private Label lblSoLuotCap;
        private Label lblSoLuot;
        private Label lblTongTienCap;
        private Label lblTongTien;
        private Button btnThoat;
        private ErrorProvider errorProvider1;
    }
}