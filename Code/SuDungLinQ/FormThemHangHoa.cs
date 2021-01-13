using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
{
    public partial class FormThemHangHoa : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public FormThemHangHoa()
        {
            InitializeComponent();
        }

        private void FormThemHangHoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachNCC();
            LoadDanhSachLoai();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            var isOK = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                HangHoa hh = GetInputForm();
                _dataBase.HangHoas.InsertOnSubmit(hh);
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
            if (pictureBox1.Image != null)
            {
                string fileName = string.Format("{0}/{1}", Application.StartupPath, txtTenHangHoa.Text + ".jpg");
                pictureBox1.Image.Save("fileName");
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
