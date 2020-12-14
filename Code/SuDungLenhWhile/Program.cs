using System;

namespace SuDungLenhWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tinh tong tu 1 toi n
            //int n = 9;
            //int tong = 0;
            //int i = 1;
            //while (i <= n)
            //{
            //    tong += i;
            //    i++;
            //}
            //Console.WriteLine("Tong {0}", tong);
            #endregion

            #region Xac dinh so nguyen to
            int n = 9;
            int i = 2;
            while (true)
            {
                if (n%i==0)
                {
                    if (i == n)
                    {
                        Console.WriteLine("{0} la so nguyen to", n);
                    }
                    else
                    { Console.WriteLine("{0} khong la so nguyen to", n); }
                    break;
                }
                i++;
            }
            #endregion
        }
    }
}
