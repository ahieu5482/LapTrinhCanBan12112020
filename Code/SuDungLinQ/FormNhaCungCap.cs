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
    public partial class FormNhaCungCap : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvDanhSachNCC.DataSource = _dataBase.NhaCungCaps.ToList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDanhSachNCC.DataSource = _dataBase.NhaCungCaps.Where(item => item.TenCongTy.Contains(txtTuKhoa.Text)
                    || item.Email.Contains(txtTuKhoa.Text)
                    || item.DiaChi.Contains(txtTuKhoa.Text)
                    || item.DienThoai.Contains(txtTuKhoa.Text));
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nccThem = GetInputForm();
                _dataBase.NhaCungCaps.InsertOnSubmit(nccThem);
                _dataBase.SubmitChanges();
                dgvDanhSachNCC.DataSource = _dataBase.NhaCungCaps.ToList();
                SetInputForm(new NhaCungCap());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetInputForm(NhaCungCap nhaCungCap)
        {
            txtMaNCC.Text = nhaCungCap.MaNCC;
            txtTenCongTy.Text = nhaCungCap.TenCongTy;
            txtLogo.Text = nhaCungCap.Logo;
            txtNguoiLienLac.Text = nhaCungCap.NguoiLienLac;
            txtEmail.Text = nhaCungCap.Email;
            txtDienThoai.Text = nhaCungCap.DienThoai;
            txtDiaChi.Text = nhaCungCap.DiaChi;
            txtMoTa.Text = nhaCungCap.MoTa;

        }

        private NhaCungCap GetInputForm()
        {
            if (txtMaNCC.Text == "")
                throw new Exception("Mã nhà cung cấp không để trống");
            if (txtTenCongTy.Text == "")
                throw new Exception("Tên công ty không thể để trống");
            if (txtLogo.Text == "")
                throw new Exception("Logo không thể để trống");
            if (txtEmail.Text == "")
                throw new Exception("Email không thể để trống");
            return new NhaCungCap()
            {
                MaNCC = txtMaNCC.Text,
                TenCongTy = txtTenCongTy.Text,
                Logo = txtLogo.Text,
                NguoiLienLac = txtNguoiLienLac.Text,
                Email = txtEmail.Text,
                DienThoai = txtDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                MoTa = txtMoTa.Text
            };
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {

            var isOK = openFileDialog1.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                txtLogo.Text = openFileDialog1.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nccSua = GetInputForm();
                NhaCungCap nccTim = _dataBase.NhaCungCaps.FirstOrDefault(item => item.MaNCC == nccSua.MaNCC);
                nccTim.MaNCC = txtMaNCC.Text;
                nccTim.TenCongTy = txtTenCongTy.Text;
                nccTim.Logo = txtLogo.Text;
                nccTim.NguoiLienLac = txtNguoiLienLac.Text;
                nccTim.Email = txtEmail.Text;
                nccTim.DienThoai = txtDienThoai.Text;
                nccTim.DiaChi = txtDiaChi.Text;
                nccTim.MoTa = txtMoTa.Text;
                _dataBase.SubmitChanges();
                dgvDanhSachNCC.DataSource = _dataBase.NhaCungCaps.ToList();
                SetInputForm(new NhaCungCap());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvDanhSachNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNCC = dgvDanhSachNCC.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
            NhaCungCap nccTim = _dataBase.NhaCungCaps.FirstOrDefault(item => item.MaNCC == maNCC);
            SetInputForm(nccTim);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var isOK = MessageBox.Show("Bạn có muốn xóa NCC này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (isOK != DialogResult.OK)
            {
                return;
            }
            _dataBase.NhaCungCaps.DeleteOnSubmit(_dataBase.NhaCungCaps.FirstOrDefault(item => item.MaNCC == txtMaNCC.Text));
            _dataBase.SubmitChanges();
            dgvDanhSachNCC.DataSource = _dataBase.NhaCungCaps.ToList();
            SetInputForm(new NhaCungCap());
        }
    }
}
