using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XepLoaiHocSinh
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double diem;
                Console.WriteLine("Nhap diem: ");
                bool kt = double.TryParse(Console.ReadLine(), out diem);
                if (kt == false)
                { throw new Exception("Diem khong dung dinh dang");
                }
                    if (diem < 0 || diem > 10)
                    {
                        throw new Exception("Diem khong dung dinh dang");
                    }
                if (diem >= 0 && diem <3.5)
                    Console.WriteLine("Kem");
                else if (diem >= 3.5 && diem < 5)
                    Console.WriteLine("Yeu");
                else if (diem >= 5 && diem <= 6.5)
                    Console.WriteLine("Trung binh");
                else if (diem >6.5  && diem < 8.5)
                    Console.WriteLine("Kha");
                else
                    Console.WriteLine("Gioi");
                

                
                

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

        }
    }
}
