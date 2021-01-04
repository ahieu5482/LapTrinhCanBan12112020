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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Form dangNhap = new FormDangNhap();
            var isOK = dangNhap.ShowDialog();
            if (isOK == DialogResult.OK)
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var isOK = MessageBox.Show("Bạn có muốn thoát không?","Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isOK != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pTBậc1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPTB1 = new FormPhuongTrinhBac1();
            formPTB1.MdiParent = this;
            formPTB1.Show();
        }

        private void pTBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPTB2 = new FormPhuongTrinhBac2();
            formPTB2.MdiParent = this;
            formPTB2.Show();
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formHT = new FormHinhTron();
            formHT.MdiParent = this;
            formHT.Show();
        }

        private void hìnhHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formSV = new QuanLySinhVien();
            formSV.MdiParent = this;
            formSV.Show();
        }
    }
}
