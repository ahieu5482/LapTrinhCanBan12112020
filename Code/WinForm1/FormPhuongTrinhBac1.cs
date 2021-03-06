﻿using System;
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
    public partial class FormPhuongTrinhBac1 : Form
    {
        public FormPhuongTrinhBac1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                PTB1 ptb1 = GetInputForm();
                txtX.Text = ptb1.TinhKetQua().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private PTB1 GetInputForm()
        {
            double a, b;
            if (double.TryParse(txtSoA.Text, out a) == false)
            {
                txtSoA.Focus();
                txtSoA.SelectAll();
                throw new Exception("Số a không hợp lệ");
            }
            if (double.TryParse(txtSoB.Text, out b) == false)
            {
                txtSoB.Focus();
                txtSoB.SelectAll();
                throw new Exception("Số b không hợp lệ");
            }
            return new PTB1()
            {
                SoA = a,
                SoB = b
            };
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
