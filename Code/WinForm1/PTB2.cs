using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm1
{
    class PTB2
    {
        public double SoA { get; set; }
        public double SoB { get; set; }
        public double SoC { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }
        public void TinhKetQua()
        {
            if (SoA == 0)
                throw new Exception("Không phải PTB2");
            double d = Math.Pow(SoB, 2) - 4 * SoA * SoC;
            if (d < 0)
            {
                throw new Exception("Phương trình vô nghiệm");
            }
                X1 = (-SoB + Math.Sqrt(d)) / (2 * SoA);
                X2 = (-SoB - Math.Sqrt(d)) / (2 * SoA);
        }
    }
}
