using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnectDatabase
{
    public partial class FormThemLoai : Form
    {
        public FormThemLoai()
        {
            InitializeComponent();
        }
                
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            var isOK = openFileDialog1.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                txtHinhAnh.Text = openFileDialog1.FileName;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loaiThem = GetInputForm();
                loaiThem.ThemLoai();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Loai GetInputForm()
        {
            if (txtTenLoai.Text == "")
            {
                throw new Exception("Tên loại không để trống");
            }
            return new Loai()
            {
                TenLoai = txtTenLoai.Text,
                MoTa = txtMoTa.Text,
                Hinh = txtHinhAnh.Text
            };
        }
    }
}
