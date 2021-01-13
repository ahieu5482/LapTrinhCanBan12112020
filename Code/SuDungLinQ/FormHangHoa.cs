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
    public partial class FormHangHoa : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int maHangHoa = int.Parse(dgvDanhSachHangHoa.Rows[e.RowIndex].Cells["MaHH"].Value.ToString());
            Form formSua = new FormSua(maHangHoa);
            var isOK = formSua.ShowDialog();
            if (isOK == DialogResult.OK)
                LoadDanhSachHangHoa();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoai();
            LoadDanhSachHangHoa();
        }

        private void LoadDanhSachLoai()
        {
            List<Loai> dsLoai = _dataBase.Loais.ToList();
            Loai loaiChon = new Loai()
            {
                MaLoai = 0,
                TenLoai = "Chọn loại hàng hóa"
            };
            dsLoai.Insert(0, loaiChon);
            cbbLoai.DataSource = dsLoai;
            cbbLoai.DisplayMember = "TenLoai";
            cbbLoai.ValueMember = "MaLoai";
        }

        private void LoadDanhSachHangHoa()
        {
            dgvDanhSachHangHoa.DataSource = _dataBase.HangHoas.Where(item => item.MaHH != null).Select(hh => new
                        {
                            MaHH = hh.MaHH,
                            TenHH = hh.TenHH,
                            MaLoai = hh.MaLoai,
                            TenLoai = hh.Loai.TenLoai,
                            MoTaDonVi = hh.MoTaDonVi,
                            DonGia = hh.DonGia,
                            Hinh = hh.Hinh,
                            NgaySX = hh.NgaySX,
                            GiamGia = hh.GiamGia,
                            SoLanXem = hh.SoLanXem,
                            MoTa = hh.MoTa,
                            MaNCC = hh.MaNCC,
                            TenCongTy = hh.NhaCungCap.TenCongTy,
                        }).ToList();
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loai loaiChon = (Loai)cbbLoai.SelectedItem;
            dgvDanhSachHangHoa.DataSource = _dataBase.HangHoas.Where(item => item.MaLoai == loaiChon.MaLoai).Select(hh => new
            {
                MaHH = hh.MaHH,
                TenHH = hh.TenHH,
                MaLoai = hh.MaLoai,
                TenLoai = hh.Loai.TenLoai,
                MoTaDonVi = hh.MoTaDonVi,
                DonGia = hh.DonGia,
                Hinh = hh.Hinh,
                NgaySX = hh.NgaySX,
                GiamGia = hh.GiamGia,
                SoLanXem = hh.SoLanXem,
                MoTa = hh.MoTa,
                MaNCC = hh.MaNCC,
                TenCongTy = hh.NhaCungCap.TenCongTy,
            }).ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form formThemHH = new FormThemHangHoa();
            var isOK = formThemHH.ShowDialog();
            if (isOK == DialogResult.OK)
                LoadDanhSachHangHoa();
        }
    }
}
