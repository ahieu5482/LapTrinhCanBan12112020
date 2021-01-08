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

namespace TestConnectDatabase
{
    public partial class FormSuaLoai : Form
    {
        private int maLoai;
        private Loai LoaiSua;

        public FormSuaLoai()
        {
            InitializeComponent();
        }

        public FormSuaLoai(int maLoai)
        {
            InitializeComponent();
            this.maLoai = maLoai;
            Loai loaiSua = new Loai();
            LoaiSua = loaiSua.GetLoaiById(maLoai);
            SetInputForm(LoaiSua);
        }

        private void SetInputForm(Loai loaiSua)
        {
            txtMaLoai.Text = loaiSua.MaLoai.ToString();
            txtTenLoai.Text = loaiSua.TenLoai;
            txtMoTa.Text = loaiSua.MoTa;
            txtHinhAnh.Text =loaiSua.Hinh;
            if(File.Exists(Application.StartupPath + "/Image/" + loaiSua.Hinh))
            pictureBox1.Image = new Bitmap(Application.StartupPath + "/Image/" + loaiSua.Hinh);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSua.TenLoai = txtTenLoai.Text;
                LoaiSua.MoTa = txtMoTa.Text;
                LoaiSua.Hinh = string.Format("loai-{0}.jpg", LoaiSua.MaLoai);
                LoaiSua.SuaLoai();
                // Cách 1
                // pictureBox1.Image.Save(@"C:\\Image\loai-" + LoaiSua.MaLoai.ToString() + ".jpg");
                // Cách 2 (tự động tạo thêm thư mục)
                bool exists = System.IO.Directory.Exists(Application.StartupPath + "/Image");
                if (!exists) System.IO.Directory.CreateDirectory(Application.StartupPath + "/Image");
                string fileName = String.Format(@"{0}\Image\loai-{1}.jpg", Application.StartupPath, LoaiSua.MaLoai);
                pictureBox1.Image.Save(fileName);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            var isOK = openFileDialog1.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                txtHinhAnh.Text = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
