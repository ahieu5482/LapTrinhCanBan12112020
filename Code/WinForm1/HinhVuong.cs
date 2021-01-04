using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm1
{
    class HinhVuong : IHinhHoc
    {
        public double Canh { get; set; }
        public double ChuVi()
        {
            return 4 * Canh;
        }

        public double DienTich()
        {
            return Canh * Canh;
        }
    }
}
