using System;

namespace SuDungHamTiepTheo
{
    struct SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
    }

    struct PhuongTrinhBac1
    {
        public double soa { get; set; }
        public double sob { get; set; }
        public double GiaiPhuongTrinh()
        {
            if (soa == 0)
                if (sob == 0)
                    throw new Exception("PT vo so nghiem");
                else
                    throw new Exception("PT vo nghiem");

            return -this.sob / this.soa; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                PhuongTrinhBac1 PT1 = new PhuongTrinhBac1();
                PT1.soa = 1;
                PT1.sob = 2;
                double kq = PT1.GiaiPhuongTrinh();
                Console.WriteLine(kq);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            
            // SinhVien teo = new SinhVien()
            //{
            //    MaSinhVien = "001",
            //    TenSinhVien = "Teo Nguyen",
            //    CMND = "0123456789",
            //    DiaChi = "HCM",
            //    NgaySinh = new DateTime(2000, 1, 1),
            //    SDT = "09000001"
            //};
            //Console.WriteLine(teo.TenSinhVien);
            // menu cua phan mem
            //Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Menu chon 1...n");
            Console.WriteLine("1. Xac dinh chan le");
            Console.WriteLine("2. Tim so lon nhat");
            Console.WriteLine("3. Tim so nho nhat");
            Console.WriteLine("4. PhuongTrinhBac1");
            Console.WriteLine("5. PhuongTrinhBac2");
            Console.WriteLine("6. UCLN");
            Console.WriteLine("7. Tinh n!");
            Console.WriteLine("exit");
            Console.WriteLine("Chon: ");
            string Chon = Console.ReadLine();
            switch (Chon)
            {
                case "1":
                    XacDinhChanLe();
                    break;
                case "2":
                    TimSoLonNhat();
                    break;
                case "3":
                    TimSoNhoNhat();
                    break;
                case "4":
                    PhuongTrinhBac1();
                    break;
                case "5":
                    PhuongTrinhBac2();
                    break;
                case "6":
                    UCLN();
                    break;
                case "7":
                    TinhGiaiThua();
                    break;
                case "exit":;
                    return;
                default:
                    break;
            }
            Menu();
        }

        private static void TinhGiaiThua()
        {
            int a = NhapSoNguyen("Nhap so nguyen duong a: ");
            if (a <= 0)
            {
                Console.WriteLine("Khong tinh duoc");
                return;
            }
            int gt = 1;
            for (int i = 1; i <= a; i++)
            {
                gt *= i;
            }
            Console.WriteLine("{0}! = {1}", a, gt);
        }

        private static void UCLN()
        {
            // Uoc Chung Lon Nhat
            int a = NhapSoNguyen("Nhap so nguyen duong a: ");
            int b = NhapSoNguyen("Nhap so nguyen duong b: ");
            while (a * b > 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            Console.WriteLine("UCLN la: {0}", a + b);
        }

        private static void PhuongTrinhBac2()
        {
            double a = NhapSoThuc("Nhap So a: ");
            double b = NhapSoThuc("Nhap So b: ");
            double c = NhapSoThuc("Nhap So c: ");
            if (a == 0)
            {
                Console.WriteLine("Day khong phai PT bac 2");
                return;
            }
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
                return;
            }
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0} | x2 = {1}", x1, x2);
        }

        private static void PhuongTrinhBac1()
        {
            double a = NhapSoThuc("Nhap So a: ");
            double b = NhapSoThuc("Nhap So b: ");
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("PT vo so nghiem");
                else
                    Console.WriteLine("PT vo nghiem");
            else
            Console.WriteLine("PT co nghiem la {0}", (-b/a));
        }

        private static double NhapSoThuc(string thongBao)
        {
            Console.WriteLine(thongBao);
            double nhap = 0;
            bool kt = false;
            while (kt == false)
            {
                kt = double.TryParse(Console.ReadLine(), out nhap);
                if (kt == false)
                {
                    Console.WriteLine("Nhap Lai:");
                }
            }
            return nhap;
        }

        private static void TimSoNhoNhat()
        {
            int a = NhapSoNguyen("Nhap So Nguyen a: ");
            int b = NhapSoNguyen("Nhap So Nguyen b: ");
            int c = NhapSoNguyen("Nhap So Nguyen c: ");
            // tim min
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            Console.WriteLine("So nho nhat la {0}", min);
        }

        private static void TimSoLonNhat()
        {
            int a = NhapSoNguyen("Nhap So Nguyen a: ");
            int b = NhapSoNguyen("Nhap So Nguyen b: ");
            int c = NhapSoNguyen("Nhap So Nguyen c: ");
            // tim max
            int max = a;
            if (max > b)
                max = b;
            if (max > c)
                max = c;
            Console.WriteLine("So lon nhat la {0}", max);

        }

        private static int NhapSoNguyen(string thongBao)
        {
            Console.WriteLine(thongBao);
            int nhap = 0;
            bool kt = false;
            while (kt == false)
            {
                kt = int.TryParse(Console.ReadLine(), out nhap);
                if (kt == false)
                {
                    Console.WriteLine("Nhap Lai:");
                }
            }
            return nhap;
        }

        private static void XacDinhChanLe()
        {
            Console.WriteLine("Nhap So Nguyen n");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            if (n%2 == 0)
                Console.WriteLine("{0} La So Chan", n);
            else
                Console.WriteLine("{0} La So Le", n);
        }
    }
}
