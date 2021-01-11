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
    public partial class FormLoaiHangHoa : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public FormLoaiHangHoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loaiThem = GetInputForm();
                _dataBase.Loais.InsertOnSubmit(loaiThem);
                _dataBase.SubmitChanges();
                dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();
                SetInputForm(new Loai());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetInputForm(Loai loai)
        {
            txtMaLoai.Text = loai.MaLoai.ToString();
            txtTenLoai.Text = loai.TenLoai;
            txtMoTa.Text = loai.MoTa;
            txtHinhAnh.Text = loai.Hinh;
        }

        private Loai GetInputForm()
        {
            int maLoai = 0;
            int.TryParse(txtMaLoai.Text, out maLoai);
            if (txtTenLoai.Text == "")
                throw new Exception("Tên loại không để trống");
            return new Loai()
                {
                    MaLoai = maLoai,
                    TenLoai = txtTenLoai.Text,
                    MoTa = txtMoTa.Text,
                    Hinh = txtHinhAnh.Text
                };
        }

        private void FormLoaiHangHoa_Load(object sender, EventArgs e)
        {
            dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loaiSua = GetInputForm();
                Loai loaiTim = _dataBase.Loais.FirstOrDefault(item => item.MaLoai == loaiSua.MaLoai);
                loaiTim.TenLoai = loaiSua.TenLoai;
                loaiTim.MoTa = loaiSua.MoTa;
                loaiTim.Hinh = loaiSua.Hinh;
                _dataBase.SubmitChanges();
                dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();
                SetInputForm(new Loai());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhSachLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int maLoai = int.Parse(dgvDanhSachLoai.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString());
            Loai loaiSua = _dataBase.Loais.FirstOrDefault(item => item.MaLoai == maLoai);
            SetInputForm(loaiSua);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var isYes = MessageBox.Show("Bạn có muốn xóa loại này không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (isYes != DialogResult.Yes)
            {
                // Không đồng ý
                return;
            }
            // Đồng ý
            _dataBase.Loais.DeleteOnSubmit(_dataBase.Loais.FirstOrDefault(item => item.MaLoai.ToString() == txtMaLoai.Text));
            _dataBase.SubmitChanges();
            dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();
            SetInputForm(new Loai());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDanhSachLoai.DataSource = _dataBase.Loais.Where(item => item.TenLoai.Contains(txtTuKhoa.Text)).ToList();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }
    }
}
