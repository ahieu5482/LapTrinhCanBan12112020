using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cau truc lenh try catch
            //try
            //{
            //    double a = double.Parse(Console.ReadLine());
            //    if (a < 0)
            //        throw new Exception("Gia tri nhap phai lon hon 0");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            #endregion

            #region Giai phuong trinh bac 1
            //try
            //{
            //    Double a, b, x;
            //    Console.WriteLine("Nhap a: ");
            //    a = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Nhap b: ");
            //    b = double.Parse(Console.ReadLine());
            //    if (a == 0)
            //    {
            //        if (b == 0)
            //        {
            //            throw new Exception("PT vo so nghiem");
            //        }
            //        else
            //        {
            //            throw new Exception("PT vo nghiem");
            //        }
            //    }
            //    x = -b / a;
            //            Console.WriteLine("PT co nghiem la: {0}", x); 

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);               
            //}

            #endregion

            #region su dung try parse

            double a, b, c;
            Console.WriteLine("Nhap a: ");
            bool kt = double.TryParse(Console.ReadLine(), out a);
            if (kt = false)
            

            
            { Console.WriteLine("A nhap khong dung"); }
            Console.WriteLine("Nhap a: ");
           
            #endregion
        }
    }
}
