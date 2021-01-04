using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class FormQuanLySinhVien : Form
    {
        public FormQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

        }

        private HinhTron GetInputForm()
        {
            double r;
            if (double.TryParse(txtBanKinh.Text, out r) == false)
            {
                txtBanKinh.Focus();
                txtBanKinh.SelectAll();
                throw new Exception("Bán Kính nhập không hợp lệ");
            }
            return new HinhTron()
            {
                BanKinh = r
            };
               
        }

        private void txtBanKinh_TextChanged(object sender, EventArgs e)
        {
            lblBanKinh.Text = "r =" + txtBanKinh.Text;
            try
            {
                HinhTron hinhTron = GetInputForm();
                txtChuVi.Text = hinhTron.ChuVi().ToString();
                txtDienTich.Text = hinhTron.DienTich().ToString();
                lblChuVi.Text = "Chu Vi =" + hinhTron.ChuVi().ToString();
                lblDienTich.Text = "Diện Tích =" + hinhTron.DienTich().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
