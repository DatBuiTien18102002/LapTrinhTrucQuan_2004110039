using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab1
{
    internal abstract class NhanVien
    {
        private String hoTen;
        private String namSinh;
        private String bangCap;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }

        public abstract int tinhLuong();
        public virtual void inThongTin()
        {
            Console.WriteLine("Ho Ten: {0}", HoTen);
            Console.WriteLine("Nam Sinh: {0}", NamSinh);
            Console.WriteLine("Bang Cap: {0}", BangCap);

        }

    }
}
