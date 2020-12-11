using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, max;
            Console.WriteLine("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = double.Parse(Console.ReadLine());
            max = a;
            if  (max < b)
            { max = b; }
                if (max < c)
                { max = c; }
            Console.WriteLine("Gia tri lon nhat la: {0}", max);
            
            

            
            

            
        }
    }
}
