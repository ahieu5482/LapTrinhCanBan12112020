using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnectDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvDanhSachLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int maLoai = int.Parse(dgvDanhSachLoai.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString());
            Loai loai = new Loai();
            Loai loaiTim = loai.GetLoaiById(maLoai);
            SetInputForm(loaiTim);
        }

        private void SetInputForm(Loai loaiTim)
        {
            txtMaLoai.Text = loaiTim.MaLoai.ToString();
            txtTenLoai.Text = loaiTim.TenLoai.ToString();
            txtMoTa.Text = loaiTim.MoTa.ToString();
            txtHinhAnh.Text = loaiTim.Hinh.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoai();
        }

        private void LoadDanhSachLoai()
        {
            Loai loai = new Loai();
            dgvDanhSachLoai.DataSource = loai.GetDanhSachLoai().ToList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Loai loai = new Loai();
            dgvDanhSachLoai.DataSource = loai.TimKiemLoai(txtTuKhoa.Text).ToList();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loai = GetInputForm();
                loai.ThemLoai();
                LoadDanhSachLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Loai GetInputForm()
        {
            int maLoai = 0;
            if (txtMaLoai.Text != "")
            {
                if(int.TryParse(txtMaLoai.Text, out maLoai) == false)
                throw new Exception("Mã loại không hợp lệ");
            }
            if (txtTenLoai.Text == "")
                throw new Exception("Tên loại không hợp lệ");
            return new Loai()
            {
                MaLoai = maLoai,
                TenLoai = txtTenLoai.Text,
                MoTa = txtMoTa.Text,
                Hinh = txtHinhAnh.Text,
            };
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            var isOK = openFileDialog1.ShowDialog();
            if(isOK == DialogResult.OK)
            {
                txtHinhAnh.Text = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loai = GetInputForm();
                loai.SuaLoai();
                LoadDanhSachLoai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
