namespace SuDungLinQ
{
    partial class FormNhaCungCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDanhSachNCC = new System.Windows.Forms.DataGridView();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiLienLac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChonHinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachNCC
            // 
            this.dgvDanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNCC.Location = new System.Drawing.Point(12, 68);
            this.dgvDanhSachNCC.Name = "dgvDanhSachNCC";
            this.dgvDanhSachNCC.Size = new System.Drawing.Size(483, 436);
            this.dgvDanhSachNCC.TabIndex = 0;
            this.dgvDanhSachNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNCC_CellContentClick);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNCC.Location = new System.Drawing.Point(509, 67);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(258, 20);
            this.txtMaNCC.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã NCC";
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenCongTy.Location = new System.Drawing.Point(509, 110);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(258, 20);
            this.txtTenCongTy.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Địa chỉ";
            // 
            // txtLogo
            // 
            this.txtLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogo.Location = new System.Drawing.Point(509, 327);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(168, 20);
            this.txtLogo.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Điện thoại";
            // 
            // txtNguoiLienLac
            // 
            this.txtNguoiLienLac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNguoiLienLac.Location = new System.Drawing.Point(509, 151);
            this.txtNguoiLienLac.Name = "txtNguoiLienLac";
            this.txtNguoiLienLac.Size = new System.Drawing.Size(258, 20);
            this.txtNguoiLienLac.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(509, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Người liên lạc";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDienThoai.Location = new System.Drawing.Point(509, 238);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(258, 20);
            this.txtDienThoai.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "LOGO";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChi.Location = new System.Drawing.Point(509, 283);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(258, 20);
            this.txtDiaChi.TabIndex = 35;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(506, 94);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 13);
            this.label.TabIndex = 34;
            this.label.Text = "Tên công ty";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMoTa.Location = new System.Drawing.Point(509, 373);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(258, 131);
            this.txtMoTa.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mô tả";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(602, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(692, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(509, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.Location = new System.Drawing.Point(17, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 24);
            this.btnTimKiem.TabIndex = 42;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTuKhoa.Location = new System.Drawing.Point(17, 41);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(330, 20);
            this.txtTuKhoa.TabIndex = 41;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChonHinh.Location = new System.Drawing.Point(692, 324);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonHinh.TabIndex = 43;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 516);
            this.Controls.Add(this.btnChonHinh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNguoiLienLac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenCongTy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachNCC);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiLienLac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChonHinh;
    }
}