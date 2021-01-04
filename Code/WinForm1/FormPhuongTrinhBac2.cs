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
    public partial class FormPhuongTrinhBac2 : Form
    {
        public FormPhuongTrinhBac2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                PTB2 ptb2 = GetInputform();
                ptb2.TinhKetQua();
                txtX1.Text = ptb2.X1.ToString();
                txtX2.Text = ptb2.X2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private PTB2 GetInputform()
        {
            double a, b, c;
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
            if (double.TryParse(txtSoC.Text, out c) == false)
            {
                txtSoC.Focus();
                txtSoC.SelectAll();
                throw new Exception("Số c không hợp lệ");
            }
            return new PTB2()
            {
                SoA = a,
                SoB = b,
                SoC = c
            };    
        }
    }
}
