using System;

namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            ThongTinSinhVien();
            ThemThongTinSinhVien();
            Console.WriteLine("--------------------");
            XoaSinhVien();
            SuaThongTinSinhVien();
            XuatDanhSachSinhVien();
        }

        private static void Menu()
        {
            Console.WriteLine("======Phan Mem Quan Ly Sinh Vien======");
            Console.WriteLine("1. Them Sinh Vien");
            Console.WriteLine("2. Sua Sinh Vien");
            Console.WriteLine("3. Xoa Sinh Vien");
            Console.WriteLine("4. Danh Sach Sinh Vien");
            Console.WriteLine("exit");
            Console.WriteLine("Chon:");
            string Chon = Console.ReadLine();
            switch (Chon)
            {
                case "1":
                    ThemThongTinSinhVien();
                    break;
                case "2":
                    SuaThongTinSinhVien();
                    break;
                case "3":
                    XoaSinhVien();
                    break;
                case "4":
                    XuatDanhSachSinhVien();
                    break;
                case "exit":
                    return;
                default:
                    break;
            }
            Menu();
        }

        private static void ThemThongTinSinhVien()
        {
            Console.WriteLine("=====Them Sinh Vien=====");
            Console.WriteLine("Nhap MaSV:");
            string maSV = Console.ReadLine();
            Console.WriteLine("Nhap TenSV:");
            string tenSV = Console.ReadLine();
            Console.WriteLine("Nhap DiaChi:");
            string diaChi = Console.ReadLine();
            Console.WriteLine("Nhap NgaySinh:");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap SDT:");
            string sDT = Console.ReadLine();
            SinhVien sv = new SinhVien()
            {
                MaSV = maSV,
                TenSV = tenSV,
                DiaChi = diaChi,
                NgaySinh = ngaySinh,
                SDT = sDT,
            };
            sv.ThemDanhSach();
        }

        private static void SuaThongTinSinhVien()
        {
            SinhVien ti = new SinhVien()
            {
                MaSV = "002",
                TenSV = "Tran Thi Ti",
                DiaChi = "HCM",
                NgaySinh = new DateTime(2000, 2, 1),
                SDT = "0123456788"
            };
            SinhVien.SuaSinhVien(ti);
        }

        private static void XuatDanhSachSinhVien()
        {
            foreach (SinhVien sv in SinhVien.GetDSSinhVien())
            {
                Console.WriteLine(sv.ThongTin());
            }
        }

        private static void XoaSinhVien()
        {
            string maSV = "001";
            SinhVien.XoaSinhVien(maSV);
        }

        private static void ThongTinSinhVien()
        {
            // Cach 1
            SinhVien teo = new SinhVien();
            teo.MaSV = "001";
            teo.TenSV = "Teo Nguyen";
            teo.DiaChi = "HCM";
            teo.NgaySinh = new DateTime(2000, 1, 1);
            teo.SDT = "0123456789";
            //Console.WriteLine(teo.MaSV);
            //Console.WriteLine(teo.TenSV);
            //Console.WriteLine(teo.DiaChi);
            //Console.WriteLine(teo.NgaySinh.ToString());
            //Console.WriteLine(teo.SDT);
            Console.WriteLine(teo.ThongTin());
            //
            // Cach 2
            SinhVien ti = new SinhVien()
            {
                MaSV = "002",
                TenSV = "Tran Van Ti",
                DiaChi = "HCM",
                NgaySinh = new DateTime(2000, 2, 1),
                SDT = "0123456788"
            };
            Console.WriteLine(ti.ThongTin());
            SinhVien.GetDSSinhVien();
            teo.ThemDanhSach();
            ti.ThemDanhSach();
            SinhVien tun = new SinhVien()
            {
                MaSV = "003",
                TenSV = "Tran Van Tun",
                DiaChi = "HCM",
                NgaySinh = new DateTime(2000, 3, 1),
                SDT = "0123456777"
            };
            SinhVien.ThemDanhSachSV(tun);
            foreach (SinhVien sv in SinhVien.GetDSSinhVien())
            {
                Console.WriteLine(sv.ThongTin());
            }
        }   
    }
}
