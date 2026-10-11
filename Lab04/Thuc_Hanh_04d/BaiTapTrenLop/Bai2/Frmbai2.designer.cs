#nullable disable

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
            btnNhapMang = new Button();
            txtNhapMang = new TextBox();
            btnReset = new Button();
            lblKetQuaMang = new Label();
            txtKetQuaMang = new TextBox();
            btnThoat = new Button();
            btnThucHien = new Button();
            grpSapXep = new GroupBox();
            grpTimKiem = new GroupBox();
            grpXoa = new GroupBox();
            grpThem = new GroupBox();
            grpTong = new GroupBox();
            grpMaxMin = new GroupBox();
            grpThayThe = new GroupBox();
            rdoTang = new RadioButton();
            rdoGiam = new RadioButton();
            rdoTimGiaTri = new RadioButton();
            txtTimGiaTri = new TextBox();
            rdoTimViTri = new RadioButton();
            txtTimViTri = new TextBox();
            lblSoTimDuoc = new Label();
            txtKetQuaTim = new TextBox();
            rdoXoaGiaTri = new RadioButton();
            txtXoaGiaTri = new TextBox();
            rdoXoaViTri = new RadioButton();
            txtXoaViTri = new TextBox();
            lblCanSapXepXoa = new Label();
            rdoThemGiaTri = new RadioButton();
            txtThemGiaTri = new TextBox();
            lblViTriThem = new Label();
            txtThemViTri = new TextBox();
            lblCanSapXepThem = new Label();
            lblTongMang = new Label();
            txtTongMang = new TextBox();
            lblTongChan = new Label();
            txtTongChan = new TextBox();
            lblTongLe = new Label();
            txtTongLe = new TextBox();
            btnTong = new Button();
            lblMax = new Label();
            txtMax = new TextBox();
            lblMin = new Label();
            txtMin = new TextBox();
            btnTim = new Button();
            rdoThayGiaTri = new RadioButton();
            txtThayGiaTri = new TextBox();
            rdoThayViTri = new RadioButton();
            txtThayViTri = new TextBox();
            lblSoThayThe = new Label();
            txtSoThayThe = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            grpSapXep.SuspendLayout();
            grpTimKiem.SuspendLayout();
            grpXoa.SuspendLayout();
            grpThem.SuspendLayout();
            grpTong.SuspendLayout();
            grpMaxMin.SuspendLayout();
            grpThayThe.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Location = new Point(0, 8);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.AutoSize = false;
            lblTieuDe.Size = new Size(510, 48);
            lblTieuDe.TabIndex = 12;
            lblTieuDe.ForeColor = Color.Red;
            lblTieuDe.Font = new Font("Times New Roman", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            lblTieuDe.Text = "Mảng Số Nguyên";
            // 
            // btnNhapMang
            // 
            btnNhapMang.Location = new Point(15, 66);
            btnNhapMang.Name = "btnNhapMang";
            btnNhapMang.Size = new Size(105, 30);
            btnNhapMang.TabIndex = 1;
            btnNhapMang.UseVisualStyleBackColor = true;
            btnNhapMang.Text = "Nhập mảng :";
            btnNhapMang.Click += btnNhapMang_Click;
            // 
            // txtNhapMang
            // 
            txtNhapMang.Location = new Point(127, 69);
            txtNhapMang.Name = "txtNhapMang";
            txtNhapMang.Size = new Size(268, 25);
            txtNhapMang.TabIndex = 0;
            txtNhapMang.KeyPress += txtNhapMang_KeyPress;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(405, 66);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 30);
            btnReset.TabIndex = 10;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // lblKetQuaMang
            // 
            lblKetQuaMang.Location = new Point(15, 108);
            lblKetQuaMang.Name = "lblKetQuaMang";
            lblKetQuaMang.AutoSize = true;
            lblKetQuaMang.TabIndex = 13;
            lblKetQuaMang.Text = "Kết quả mảng :";
            // 
            // txtKetQuaMang
            // 
            txtKetQuaMang.Location = new Point(127, 105);
            txtKetQuaMang.Name = "txtKetQuaMang";
            txtKetQuaMang.Size = new Size(268, 25);
            txtKetQuaMang.TabIndex = 14;
            txtKetQuaMang.ReadOnly = true;
            txtKetQuaMang.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(405, 100);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(95, 30);
            btnThoat.TabIndex = 11;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(15, 142);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(105, 60);
            btnThucHien.TabIndex = 7;
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Text = "Thực Hiện";
            btnThucHien.Click += btnThucHien_Click;
            // 
            // grpSapXep
            // 
            grpSapXep.Controls.Add(rdoTang);
            grpSapXep.Controls.Add(rdoGiam);
            grpSapXep.Location = new Point(127, 138);
            grpSapXep.Name = "grpSapXep";
            grpSapXep.Size = new Size(373, 64);
            grpSapXep.TabIndex = 2;
            grpSapXep.TabStop = false;
            grpSapXep.Text = "Sắp Xếp";
            // 
            // grpTimKiem
            // 
            grpTimKiem.Controls.Add(rdoTimGiaTri);
            grpTimKiem.Controls.Add(txtTimGiaTri);
            grpTimKiem.Controls.Add(rdoTimViTri);
            grpTimKiem.Controls.Add(txtTimViTri);
            grpTimKiem.Controls.Add(lblSoTimDuoc);
            grpTimKiem.Controls.Add(txtKetQuaTim);
            grpTimKiem.Location = new Point(15, 212);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new Size(235, 122);
            grpTimKiem.TabIndex = 3;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm Kiếm";
            // 
            // grpXoa
            // 
            grpXoa.Controls.Add(rdoXoaGiaTri);
            grpXoa.Controls.Add(txtXoaGiaTri);
            grpXoa.Controls.Add(rdoXoaViTri);
            grpXoa.Controls.Add(txtXoaViTri);
            grpXoa.Controls.Add(lblCanSapXepXoa);
            grpXoa.Location = new Point(265, 212);
            grpXoa.Name = "grpXoa";
            grpXoa.Size = new Size(235, 122);
            grpXoa.TabIndex = 4;
            grpXoa.TabStop = false;
            grpXoa.Text = "Xóa";
            // 
            // grpThem
            // 
            grpThem.Controls.Add(rdoThemGiaTri);
            grpThem.Controls.Add(txtThemGiaTri);
            grpThem.Controls.Add(lblViTriThem);
            grpThem.Controls.Add(txtThemViTri);
            grpThem.Controls.Add(lblCanSapXepThem);
            grpThem.Location = new Point(15, 342);
            grpThem.Name = "grpThem";
            grpThem.Size = new Size(235, 122);
            grpThem.TabIndex = 5;
            grpThem.TabStop = false;
            grpThem.Text = "Thêm";
            // 
            // grpTong
            // 
            grpTong.Controls.Add(lblTongMang);
            grpTong.Controls.Add(txtTongMang);
            grpTong.Controls.Add(lblTongChan);
            grpTong.Controls.Add(txtTongChan);
            grpTong.Controls.Add(lblTongLe);
            grpTong.Controls.Add(txtTongLe);
            grpTong.Controls.Add(btnTong);
            grpTong.Location = new Point(265, 342);
            grpTong.Name = "grpTong";
            grpTong.Size = new Size(235, 122);
            grpTong.TabIndex = 8;
            grpTong.TabStop = false;
            grpTong.Text = "Tổng";
            // 
            // grpMaxMin
            // 
            grpMaxMin.Controls.Add(lblMax);
            grpMaxMin.Controls.Add(txtMax);
            grpMaxMin.Controls.Add(lblMin);
            grpMaxMin.Controls.Add(txtMin);
            grpMaxMin.Controls.Add(btnTim);
            grpMaxMin.Location = new Point(15, 472);
            grpMaxMin.Name = "grpMaxMin";
            grpMaxMin.Size = new Size(235, 118);
            grpMaxMin.TabIndex = 9;
            grpMaxMin.TabStop = false;
            grpMaxMin.Text = "Max - Min";
            // 
            // grpThayThe
            // 
            grpThayThe.Controls.Add(rdoThayGiaTri);
            grpThayThe.Controls.Add(txtThayGiaTri);
            grpThayThe.Controls.Add(rdoThayViTri);
            grpThayThe.Controls.Add(txtThayViTri);
            grpThayThe.Controls.Add(lblSoThayThe);
            grpThayThe.Controls.Add(txtSoThayThe);
            grpThayThe.Location = new Point(265, 472);
            grpThayThe.Name = "grpThayThe";
            grpThayThe.Size = new Size(235, 118);
            grpThayThe.TabIndex = 6;
            grpThayThe.TabStop = false;
            grpThayThe.Text = "Thay Thế";
            // 
            // rdoTang
            // 
            rdoTang.Location = new Point(40, 26);
            rdoTang.Name = "rdoTang";
            rdoTang.AutoSize = true;
            rdoTang.TabIndex = 0;
            rdoTang.Checked = true;
            rdoTang.UseVisualStyleBackColor = true;
            rdoTang.Text = "Sắp xếp Tăng";
            // 
            // rdoGiam
            // 
            rdoGiam.Location = new Point(210, 26);
            rdoGiam.Name = "rdoGiam";
            rdoGiam.AutoSize = true;
            rdoGiam.TabIndex = 1;
            rdoGiam.UseVisualStyleBackColor = true;
            rdoGiam.Text = "Sắp xếp Giảm";
            // 
            // rdoTimGiaTri
            // 
            rdoTimGiaTri.Location = new Point(10, 24);
            rdoTimGiaTri.Name = "rdoTimGiaTri";
            rdoTimGiaTri.AutoSize = true;
            rdoTimGiaTri.TabIndex = 0;
            rdoTimGiaTri.UseVisualStyleBackColor = true;
            rdoTimGiaTri.Text = "Tìm giá trị cần tìm";
            rdoTimGiaTri.CheckedChanged += rdoNhom_CheckedChanged;
            // 
            // txtTimGiaTri
            // 
            txtTimGiaTri.Location = new Point(184, 22);
            txtTimGiaTri.Name = "txtTimGiaTri";
            txtTimGiaTri.Size = new Size(42, 23);
            txtTimGiaTri.TabIndex = 1;
            txtTimGiaTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // rdoTimViTri
            // 
            rdoTimViTri.Location = new Point(10, 56);
            rdoTimViTri.Name = "rdoTimViTri";
            rdoTimViTri.AutoSize = true;
            rdoTimViTri.TabIndex = 2;
            rdoTimViTri.UseVisualStyleBackColor = true;
            rdoTimViTri.Text = "Tìm vị trí cần tìm";
            rdoTimViTri.CheckedChanged += rdoNhom_CheckedChanged;
            // 
            // txtTimViTri
            // 
            txtTimViTri.Location = new Point(184, 54);
            txtTimViTri.Name = "txtTimViTri";
            txtTimViTri.Size = new Size(42, 23);
            txtTimViTri.TabIndex = 3;
            txtTimViTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // lblSoTimDuoc
            // 
            lblSoTimDuoc.Location = new Point(30, 92);
            lblSoTimDuoc.Name = "lblSoTimDuoc";
            lblSoTimDuoc.AutoSize = true;
            lblSoTimDuoc.TabIndex = 4;
            lblSoTimDuoc.Text = "Số tìm được là :";
            // 
            // txtKetQuaTim
            // 
            txtKetQuaTim.Location = new Point(150, 89);
            txtKetQuaTim.Name = "txtKetQuaTim";
            txtKetQuaTim.Size = new Size(76, 23);
            txtKetQuaTim.TabIndex = 5;
            txtKetQuaTim.ReadOnly = true;
            txtKetQuaTim.TabStop = false;
            // 
            // rdoXoaGiaTri
            // 
            rdoXoaGiaTri.Location = new Point(10, 24);
            rdoXoaGiaTri.Name = "rdoXoaGiaTri";
            rdoXoaGiaTri.AutoSize = true;
            rdoXoaGiaTri.TabIndex = 0;
            rdoXoaGiaTri.UseVisualStyleBackColor = true;
            rdoXoaGiaTri.Text = "Tìm giá trị cần xóa";
            rdoXoaGiaTri.CheckedChanged += rdoNhom_CheckedChanged;
            // 
            // txtXoaGiaTri
            // 
            txtXoaGiaTri.Location = new Point(184, 22);
            txtXoaGiaTri.Name = "txtXoaGiaTri";
            txtXoaGiaTri.Size = new Size(42, 23);
            txtXoaGiaTri.TabIndex = 1;
            txtXoaGiaTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // rdoXoaViTri
            // 
            rdoXoaViTri.Location = new Point(10, 56);
            rdoXoaViTri.Name = "rdoXoaViTri";
            rdoXoaViTri.AutoSize = true;
            rdoXoaViTri.TabIndex = 2;
            rdoXoaViTri.UseVisualStyleBackColor = true;
            rdoXoaViTri.Text = "Tìm vị trí cần xóa";
            rdoXoaViTri.CheckedChanged += rdoNhom_CheckedChanged;
            // 
            // txtXoaViTri
            // 
            txtXoaViTri.Location = new Point(184, 54);
            txtXoaViTri.Name = "txtXoaViTri";
            txtXoaViTri.Size = new Size(42, 23);
            txtXoaViTri.TabIndex = 3;
            txtXoaViTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // lblCanSapXepXoa
            // 
            lblCanSapXepXoa.Location = new Point(55, 92);
            lblCanSapXepXoa.Name = "lblCanSapXepXoa";
            lblCanSapXepXoa.AutoSize = true;
            lblCanSapXepXoa.TabIndex = 4;
            lblCanSapXepXoa.ForeColor = Color.Red;
            lblCanSapXepXoa.Text = "Cần sắp xếp tăng";
            // 
            // rdoThemGiaTri
            // 
            rdoThemGiaTri.Location = new Point(10, 24);
            rdoThemGiaTri.Name = "rdoThemGiaTri";
            rdoThemGiaTri.AutoSize = true;
            rdoThemGiaTri.TabIndex = 0;
            rdoThemGiaTri.UseVisualStyleBackColor = true;
            rdoThemGiaTri.Text = "Tìm giá trị cần thêm";
            rdoThemGiaTri.CheckedChanged += rdoNhom_CheckedChanged;
            // 
            // txtThemGiaTri
            // 
            txtThemGiaTri.Location = new Point(184, 22);
            txtThemGiaTri.Name = "txtThemGiaTri";
            txtThemGiaTri.Size = new Size(42, 23);
            txtThemGiaTri.TabIndex = 1;
            txtThemGiaTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // lblViTriThem
            // 
            lblViTriThem.Location = new Point(22, 62);
            lblViTriThem.Name = "lblViTriThem";
            lblViTriThem.AutoSize = true;
            lblViTriThem.TabIndex = 2;
            lblViTriThem.Text = "Tại vị trí cần thêm :";
            // 
            // txtThemViTri
            // 
            txtThemViTri.Location = new Point(184, 59);
            txtThemViTri.Name = "txtThemViTri";
            txtThemViTri.Size = new Size(42, 23);
            txtThemViTri.TabIndex = 3;
            txtThemViTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // lblCanSapXepThem
            // 
            lblCanSapXepThem.Location = new Point(55, 94);
            lblCanSapXepThem.Name = "lblCanSapXepThem";
            lblCanSapXepThem.AutoSize = true;
            lblCanSapXepThem.TabIndex = 4;
            lblCanSapXepThem.ForeColor = Color.Red;
            lblCanSapXepThem.Text = "Cần sắp xếp tăng";
            // 
            // lblTongMang
            // 
            lblTongMang.Location = new Point(12, 29);
            lblTongMang.Name = "lblTongMang";
            lblTongMang.AutoSize = true;
            lblTongMang.TabIndex = 0;
            lblTongMang.Text = "Tổng mảng";
            // 
            // txtTongMang
            // 
            txtTongMang.Location = new Point(95, 26);
            txtTongMang.Name = "txtTongMang";
            txtTongMang.Size = new Size(70, 23);
            txtTongMang.TabIndex = 1;
            txtTongMang.ReadOnly = true;
            txtTongMang.TabStop = false;
            // 
            // lblTongChan
            // 
            lblTongChan.Location = new Point(12, 61);
            lblTongChan.Name = "lblTongChan";
            lblTongChan.AutoSize = true;
            lblTongChan.TabIndex = 2;
            lblTongChan.Text = "Tổng chẵn";
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(95, 58);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(70, 23);
            txtTongChan.TabIndex = 3;
            txtTongChan.ReadOnly = true;
            txtTongChan.TabStop = false;
            // 
            // lblTongLe
            // 
            lblTongLe.Location = new Point(12, 93);
            lblTongLe.Name = "lblTongLe";
            lblTongLe.AutoSize = true;
            lblTongLe.TabIndex = 4;
            lblTongLe.Text = "Tổng lẻ";
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(95, 90);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(70, 23);
            txtTongLe.TabIndex = 5;
            txtTongLe.ReadOnly = true;
            txtTongLe.TabStop = false;
            // 
            // btnTong
            // 
            btnTong.Location = new Point(172, 26);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(55, 87);
            btnTong.TabIndex = 6;
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Text = "Tổng";
            btnTong.Click += btnTong_Click;
            // 
            // lblMax
            // 
            lblMax.Location = new Point(12, 32);
            lblMax.Name = "lblMax";
            lblMax.AutoSize = true;
            lblMax.TabIndex = 0;
            lblMax.Text = "Giá trị lớn nhất";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(125, 29);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(50, 23);
            txtMax.TabIndex = 1;
            txtMax.ReadOnly = true;
            txtMax.TabStop = false;
            // 
            // lblMin
            // 
            lblMin.Location = new Point(12, 72);
            lblMin.Name = "lblMin";
            lblMin.AutoSize = true;
            lblMin.TabIndex = 2;
            lblMin.Text = "Giá trị nhỏ nhất";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(125, 69);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(50, 23);
            txtMin.TabIndex = 3;
            txtMin.ReadOnly = true;
            txtMin.TabStop = false;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(182, 29);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(45, 63);
            btnTim.TabIndex = 4;
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Text = "Tìm";
            btnTim.Click += btnTim_Click;
            // 
            // rdoThayGiaTri
            // 
            rdoThayGiaTri.Location = new Point(10, 24);
            rdoThayGiaTri.Name = "rdoThayGiaTri";
            rdoThayGiaTri.AutoSize = true;
            rdoThayGiaTri.TabIndex = 0;
            rdoThayGiaTri.UseVisualStyleBackColor = true;
            rdoThayGiaTri.Text = "Giá trị cần thay thế";
            rdoThayGiaTri.CheckedChanged += rdoNhom_CheckedChanged;
            // 
            // txtThayGiaTri
            // 
            txtThayGiaTri.Location = new Point(184, 22);
            txtThayGiaTri.Name = "txtThayGiaTri";
            txtThayGiaTri.Size = new Size(42, 23);
            txtThayGiaTri.TabIndex = 1;
            txtThayGiaTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // rdoThayViTri
            // 
            rdoThayViTri.Location = new Point(10, 56);
            rdoThayViTri.Name = "rdoThayViTri";
            rdoThayViTri.AutoSize = true;
            rdoThayViTri.TabIndex = 2;
            rdoThayViTri.UseVisualStyleBackColor = true;
            rdoThayViTri.Text = "Vị trí cần thay thế";
            rdoThayViTri.CheckedChanged += rdoNhom_CheckedChanged;
            // 
            // txtThayViTri
            // 
            txtThayViTri.Location = new Point(184, 54);
            txtThayViTri.Name = "txtThayViTri";
            txtThayViTri.Size = new Size(42, 23);
            txtThayViTri.TabIndex = 3;
            txtThayViTri.KeyPress += txtSoNguyen_KeyPress;
            // 
            // lblSoThayThe
            // 
            lblSoThayThe.Location = new Point(30, 88);
            lblSoThayThe.Name = "lblSoThayThe";
            lblSoThayThe.AutoSize = true;
            lblSoThayThe.TabIndex = 4;
            lblSoThayThe.Text = "Số thay thế là :";
            // 
            // txtSoThayThe
            // 
            txtSoThayThe.Location = new Point(150, 85);
            txtSoThayThe.Name = "txtSoThayThe";
            txtSoThayThe.Size = new Size(76, 23);
            txtSoThayThe.TabIndex = 5;
            txtSoThayThe.KeyPress += txtSoNguyen_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBai2
            // 
            AcceptButton = btnNhapMang;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(510, 600);
            Controls.Add(lblTieuDe);
            Controls.Add(btnNhapMang);
            Controls.Add(txtNhapMang);
            Controls.Add(btnReset);
            Controls.Add(lblKetQuaMang);
            Controls.Add(txtKetQuaMang);
            Controls.Add(btnThoat);
            Controls.Add(btnThucHien);
            Controls.Add(grpSapXep);
            Controls.Add(grpTimKiem);
            Controls.Add(grpXoa);
            Controls.Add(grpThem);
            Controls.Add(grpTong);
            Controls.Add(grpMaxMin);
            Controls.Add(grpThayThe);
            Font = new Font("Times New Roman", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmBai2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mảng Số Nguyên";
            FormClosing += frmBai2_FormClosing;
            grpSapXep.ResumeLayout(false);
            grpSapXep.PerformLayout();
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            grpXoa.ResumeLayout(false);
            grpXoa.PerformLayout();
            grpThem.ResumeLayout(false);
            grpThem.PerformLayout();
            grpTong.ResumeLayout(false);
            grpTong.PerformLayout();
            grpMaxMin.ResumeLayout(false);
            grpMaxMin.PerformLayout();
            grpThayThe.ResumeLayout(false);
            grpThayThe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Button btnNhapMang;
        private TextBox txtNhapMang;
        private Button btnReset;
        private Label lblKetQuaMang;
        private TextBox txtKetQuaMang;
        private Button btnThoat;
        private Button btnThucHien;
        private GroupBox grpSapXep;
        private GroupBox grpTimKiem;
        private GroupBox grpXoa;
        private GroupBox grpThem;
        private GroupBox grpTong;
        private GroupBox grpMaxMin;
        private GroupBox grpThayThe;
        private RadioButton rdoTang;
        private RadioButton rdoGiam;
        private RadioButton rdoTimGiaTri;
        private TextBox txtTimGiaTri;
        private RadioButton rdoTimViTri;
        private TextBox txtTimViTri;
        private Label lblSoTimDuoc;
        private TextBox txtKetQuaTim;
        private RadioButton rdoXoaGiaTri;
        private TextBox txtXoaGiaTri;
        private RadioButton rdoXoaViTri;
        private TextBox txtXoaViTri;
        private Label lblCanSapXepXoa;
        private RadioButton rdoThemGiaTri;
        private TextBox txtThemGiaTri;
        private Label lblViTriThem;
        private TextBox txtThemViTri;
        private Label lblCanSapXepThem;
        private Label lblTongMang;
        private TextBox txtTongMang;
        private Label lblTongChan;
        private TextBox txtTongChan;
        private Label lblTongLe;
        private TextBox txtTongLe;
        private Button btnTong;
        private Label lblMax;
        private TextBox txtMax;
        private Label lblMin;
        private TextBox txtMin;
        private Button btnTim;
        private RadioButton rdoThayGiaTri;
        private TextBox txtThayGiaTri;
        private RadioButton rdoThayViTri;
        private TextBox txtThayViTri;
        private Label lblSoThayThe;
        private TextBox txtSoThayThe;
        private ErrorProvider errorProvider1;
    }
}