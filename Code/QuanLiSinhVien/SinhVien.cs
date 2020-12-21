using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }

        public static void XoaSinhVien(string maSV)
        {
            List<SinhVien> danhSachSV = GetDSSinhVien();
            XoaSinhVienCach1(maSV);
            XoaSinhVienCach2(maSV);
        }

        private static void XoaSinhVienCach2(string maSV)
        {
            List<SinhVien> dsSV = GetDSSinhVien();
            dsSV.RemoveAll(sv => sv.MaSV == maSV);
            DSSinhVien = dsSV;
        }

        public static void SuaSinhVien(SinhVien svSua)
        {
            // Xoa
            XoaSinhVien(svSua.MaSV);
            ThemDanhSachSV(svSua);
        }

        private static void XoaSinhVienCach1(string maSV)
        {
            List<SinhVien> dsSV = GetDSSinhVien();
            int dem = -1;
            int i = 0;
            // Tim vi tri sinh vien muon xoa
            foreach (SinhVien item in dsSV)
            {
                if (item.MaSV == maSV)
                    dem = i;
                i++;
            }
            // Tim duoc thi xoa
            if (dem > -1)
                dsSV.RemoveAt(dem);
            DSSinhVien = dsSV;
        }

        public string SDT { get; set; }
        public static List<SinhVien> DSSinhVien;
        public string ThongTin()
        {
            return String.Format("{0},{1},{2},{3},{4}", MaSV, TenSV, DiaChi, NgaySinh, SDT);
        }
        /// <summary>
        /// Lay Danh Sach Sinh Vien
        /// </summary>
        /// <returns> </returns>
        public static List<SinhVien> GetDSSinhVien()
        {
            //DSSinhVien = DSSinhVien == null ? new List<SinhVien>() : DSSinhVien;
            if (DSSinhVien == null)
                DSSinhVien = new List<SinhVien>();
            return DSSinhVien;
        }
        /// <summary>
        /// Tu Them Vao Danh Sach
        /// </summary>
        public void ThemDanhSach()
        {
            SinhVien svThem = this;
            List<SinhVien> danhSachSV = GetDSSinhVien();
            danhSachSV.Add(svThem);
            DSSinhVien = danhSachSV;
        }

        public void ThemDanhSach(SinhVien svThem)
        {
            List<SinhVien> danhSachSV = GetDSSinhVien();
            danhSachSV.Add(svThem);
            DSSinhVien = danhSachSV;
        }

        public static void ThemDanhSachSV(SinhVien svThem)
        {
            List<SinhVien> danhSachSV = GetDSSinhVien();
            danhSachSV.Add(svThem);
            DSSinhVien = danhSachSV;
        }
    }
}
