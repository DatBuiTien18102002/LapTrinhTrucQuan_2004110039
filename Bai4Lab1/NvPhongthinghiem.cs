using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab1
{
    internal class NvPhongthinghiem:NhanVien
    {
        private int luongTrongThang;

        public int LuongTrongThang { get => LuongTrongThang; set => LuongTrongThang = value; }


        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine("Luong trong thang: {0}",LuongTrongThang);
        }
        public override int tinhLuong()
        {
            return LuongTrongThang;
        }
    }
}
