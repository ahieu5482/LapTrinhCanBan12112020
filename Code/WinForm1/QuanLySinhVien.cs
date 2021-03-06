﻿using QuanLySinhVien;
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
    public partial class QuanLySinhVien : Form
    {
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSV = dgvDanhSachSV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaSV.ReadOnly = true;
            SinhVien svSua = SinhVien.TimSinhVienTheoMa(maSV);
            SetInputForm(svSua);
        }

        private void SetInputForm(SinhVien svSua)
        {
            txtMaSV.Text = svSua.MaSV.Trim();
            txtTenSV.Text = svSua.TenSV.Trim();
            txtSDT.Text = svSua.SDT.Trim();
            txtDiaChi.Text = svSua.DiaChi.Trim();
            dtpNgaySinh.Value = svSua.NgaySinh;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien svSua = GetInputForm();
                SinhVien.SuaSinhVien(svSua);
                CapNhatDanhSachSinhVien();
                SetInputForm(new SinhVien()
                {
                    MaSV = "",
                    TenSV = "",
                    SDT = "",
                    DiaChi = "",
                    NgaySinh = new DateTime(2000, 1, 1)
                }
                );
                txtMaSV.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = GetInputForm();
                SinhVien.ThemDanhSachSV(sv);
                // cap nhat dategreaview
                CapNhatDanhSachSinhVien();
                SetInputForm(new SinhVien() 
                {
                    MaSV = "",
                    TenSV = "",
                    SDT = "",
                    DiaChi = "",
                    NgaySinh = new DateTime(2000,1,1)
                }
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        

        private void CapNhatDanhSachSinhVien()
        {
            dgvDanhSachSV.DataSource = SinhVien.GetDSSinhVien().ToList();
        }

        private SinhVien GetInputForm()
        {
            if (txtMaSV.Text == "")
            {
                throw new Exception("Bạn chưa nhập mã sinh viên");
            }
            if (txtTenSV.Text == "")
            {
                throw new Exception("Bạn chưa nhập tên sinh viên");
            }
            return new SinhVien()
            {
                MaSV = txtMaSV.Text,
                TenSV = txtTenSV.Text,
                DiaChi = txtDiaChi.Text,
                NgaySinh = dtpNgaySinh.Value,
                SDT = txtSDT.Text
            };
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien svXoa = GetInputForm();
                var isOK = MessageBox.Show("Bạn có muốn xóa thật không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (isOK == DialogResult.OK)
                {
                    SinhVien.XoaSinhVien(svXoa.MaSV);
                    CapNhatDanhSachSinhVien();
                    SetInputForm(new SinhVien()
                    {
                        MaSV = "",
                        TenSV = "",
                        SDT = "",
                        DiaChi = "",
                        NgaySinh = new DateTime(2000, 1, 1)
                    }
               );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
