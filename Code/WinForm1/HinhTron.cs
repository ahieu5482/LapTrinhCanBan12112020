using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm1
{
    class HinhTron : IHinhHoc
    {
        public double BanKinh { get; set; }
        public double ChuVi()
        {
            return 2 * BanKinh * Math.PI;
        }

        public double DienTich()
        {
            return Math.Pow(BanKinh, 2) * Math.PI;
        }
    }
}
