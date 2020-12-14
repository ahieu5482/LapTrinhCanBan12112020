using System;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            //XinChao("Nguyen Van Teo");
            //XinChao();
            //double a, b;
            // nhap tu ban phim
            //double.TryParse(Console.ReadLine(), out a);
            //double.TryParse(Console.ReadLine(), out b);
            // gan gia tri
            //a = 6;
            //b = 8;
            //PhuongTrinhBac1(a, b);
            int a = NhapSoNguyen("Nhap so nguyen a");
            int b = NhapSoNguyen("Nhap so nguyen b");
            int c = NhapSoNguyen("Nhap so nguyen c");
        }

        private static int NhapSoNguyen(string thongBao)
        {
            Console.WriteLine(thongBao);
            // mac dinh nhap sai
            bool kt = false;
            int a = 0;
            while (kt == false)
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == false)
                {
                    Console.WriteLine("Nhap Lai:");
                }
            }
            return a;
        }

        private static void PhuongTrinhBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("PT vo so nghiem");
                }
                else
                {
                    Console.WriteLine("PT vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("X = {0}", -b/a);
            }
        }

        private static void XinChao(string hoTen)
        {
            Console.WriteLine("Xin Chao! {0}", hoTen);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin Chao");
        }
    }
}
