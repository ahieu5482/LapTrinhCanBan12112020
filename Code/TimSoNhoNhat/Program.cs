using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoNhoNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, min;
            Console.WriteLine("Nhap a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = double.Parse(Console.ReadLine());
            min = a;
            if (min >b)
            
                min = b;
            
            if (min > c)
            
                min = c;
            
            Console.WriteLine("Gia tri nho nhat la: {0}", min);
        }
    }
}
