using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
{
    public partial class FormSua : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        private int maHangHoa;

        public FormSua()
        {
            InitializeComponent();
        }

        public FormSua(int maHangHoa)
        {
            this.maHangHoa = maHangHoa;
            InitializeComponent();
        }

        private void FormSua_Load(object sender, EventArgs e)
        {
            LoadDanhSachNCC();
            LoadDanhSachLoai();
            SetInputForm(this.maHangHoa);
        }

        private void SetInputForm(int maHangHoa)
        {
            HangHoa hhSua = _dataBase.HangHoas.FirstOrDefault(item => item.MaHH == maHangHoa);
            txtTenHangHoa.Text = hhSua.TenHH;
            txtDonGia.Text = hhSua.DonGia.ToString();
            dtpNgaySanXuat.Value = hhSua.NgaySX;
            txtGiamGia.Text = hhSua.GiamGia.ToString();
            txtMoTa.Text = hhSua.MoTa;
            txtMoTaDonVi.Text = hhSua.MoTaDonVi;
            cbbLoaiHangHoa.SelectedValue = hhSua.MaLoai;
            cbbNhaCungCap.SelectedValue = hhSua.MaNCC;
            if (File.Exists(hhSua.Hinh))
            pictureBox1.Image = new Bitmap(hhSua.Hinh);
        }

        private void LoadDanhSachLoai()
        {
            cbbLoaiHangHoa.DataSource = _dataBase.Loais.ToList();
            cbbLoaiHangHoa.DisplayMember = "TenLoai";
            cbbLoaiHangHoa.ValueMember = "MaLoai";
        }

        private void LoadDanhSachNCC()
        {
            cbbNhaCungCap.DataSource = _dataBase.NhaCungCaps.ToList();
            cbbNhaCungCap.DisplayMember = "TenCongTy";
            cbbNhaCungCap.ValueMember = "MaNCC";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var isOK = MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                HangHoa hhSua = GetInputForm();
                HangHoa hhDataBase = _dataBase.HangHoas.FirstOrDefault(item => item.MaHH == hhSua.MaHH);
                hhDataBase.TenHH = hhSua.TenHH;
                hhDataBase.DonGia = hhSua.DonGia;
                hhDataBase.MoTa = hhSua.MoTa;
                hhDataBase.MoTaDonVi = hhSua.MoTaDonVi;
                hhDataBase.GiamGia = hhSua.GiamGia;
                hhDataBase.DonGia = hhSua.DonGia;
                hhDataBase.MaLoai = hhSua.MaLoai;
                hhDataBase.MaNCC = hhSua.MaNCC;
                hhDataBase.Hinh = hhSua.Hinh;
                _dataBase.SubmitChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private HangHoa GetInputForm()
        {
            if (txtTenHangHoa.Text == "")
                throw new Exception("Tên hàng hóa không được để trống");
            if (txtDonGia.Text == "")
                throw new Exception("Đơn giá không được để trống");
            string hinhAnh = "";
            if (openFileDialog1.FileName != null)
            {
                string fileName = string.Format("{0}/{1}", Application.StartupPath, txtTenHangHoa.Text + ".jpg");
                Bitmap hinhBitmap = new Bitmap(pictureBox1.Image);
                pictureBox1.Image.Dispose();
                File.Delete(fileName);
                hinhBitmap.Save(fileName);
                hinhAnh = fileName;
            }
            double donGia;
            double.TryParse(txtDonGia.Text, out donGia);
            double giamGia;
            double.TryParse(txtGiamGia.Text, out giamGia);
            Loai loaiHH = (Loai)cbbLoaiHangHoa.SelectedItem;
            NhaCungCap nccHH = (NhaCungCap)cbbNhaCungCap.SelectedItem;
            DateTime ngaySX = dtpNgaySanXuat.Value;
            return new HangHoa()
            {
                MaHH = this.maHangHoa,
                TenHH = txtTenHangHoa.Text,
                DonGia = donGia,
                GiamGia = giamGia,
                MoTaDonVi = txtMoTaDonVi.Text,
                MoTa = txtMoTa.Text,
                MaLoai = loaiHH.MaLoai,
                MaNCC = nccHH.MaNCC,
                Hinh = hinhAnh,
                SoLanXem = 0,
                NgaySX = ngaySX
            };
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            var isOK = openFileDialog1.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
