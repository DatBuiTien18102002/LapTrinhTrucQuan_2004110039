using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab1
{
    internal abstract class NhanVienCapCao:NhanVien
    {
        private String chucVu;
        private int soNgayCongTrongThang;
        private int bacLuong;

        public string ChucVu { get => chucVu; set => chucVu = value; }
        public int SoNgayCongTrongThang { get => soNgayCongTrongThang; set => soNgayCongTrongThang = value; }
        public int BacLuong { get => bacLuong; set => bacLuong = value; }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine("Chuc vu: {0}", ChucVu);
            Console.WriteLine("So ngay cong trong thang: {0}", SoNgayCongTrongThang);
            Console.WriteLine("Bac luong: {0}", BacLuong);
        }

        public override int tinhLuong()
        {
            return SoNgayCongTrongThang * BacLuong;
        }
    }
}
