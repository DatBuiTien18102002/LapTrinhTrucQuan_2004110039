using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab1
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so nhan vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            List<NhanVien> arrayS = new List<NhanVien>(n);

            arrayS = nhapDS(n);
            xuatDS(n, arrayS);
        }
        public static NhanVien nhap1SV(int choice)
        {
            NhanVien nhanVien ;
            Console.WriteLine("Ho Ten: ");
            String hoTen = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nam Sinh: ");
            String namSinh = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Bang Cap: ");
            String bangCap = Convert.ToString(Console.ReadLine()) ;
            if (choice == 1){
                nhanVien = new NvPhongthinghiem();
                NvPhongthinghiem nvPhongthinghiem = new NvPhongthinghiem() ;
                Console.WriteLine("Luong trong thang: ");
                nvPhongthinghiem.LuongTrongThang = Convert.ToInt32(Console.ReadLine());
                nvPhongthinghiem.HoTen = hoTen;
                nvPhongthinghiem.NamSinh = namSinh;
                nvPhongthinghiem.BangCap = bangCap;
                nhanVien = nvPhongthinghiem;
            }
            else if(choice == 2){ 
                nhanVien = new NhaKhoaHoc();
                NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc();
                nhaKhoaHoc.HoTen = hoTen;
                nhaKhoaHoc.NamSinh = namSinh;
                nhaKhoaHoc.BangCap = bangCap;
                Console.WriteLine("Chuc vu: ");
                nhaKhoaHoc.ChucVu = Convert.ToString(Console.ReadLine());
                Console.WriteLine("So ngay cong trong thang: ");
                nhaKhoaHoc.SoNgayCongTrongThang = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bac luong: ");
                nhaKhoaHoc.BacLuong = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("So Bai Bao Da Cong Bo:");
                nhaKhoaHoc.SoBaiBaoDaCongBo = Convert.ToInt32(Console.ReadLine());

                nhanVien = nhaKhoaHoc;
            }
            else {
                nhanVien = new NhaQuanLy();
                NhaQuanLy nhaQuanLy = new NhaQuanLy();
                nhaQuanLy.HoTen = hoTen;
                nhaQuanLy.NamSinh = namSinh;
                nhaQuanLy.BangCap = bangCap;

                Console.WriteLine("Chuc vu: ");
                nhaQuanLy.ChucVu = Convert.ToString(Console.ReadLine());
                Console.WriteLine("So ngay cong trong thang: ");
                nhaQuanLy.SoNgayCongTrongThang = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bac luong: ");
                nhaQuanLy.BacLuong = Convert.ToInt32(Console.ReadLine());
                nhanVien = nhaQuanLy;

            }
            

            return nhanVien;

        }

        public static List<NhanVien> nhapDS(int n)
        {

            List<NhanVien> arrayS = new List<NhanVien>(n);

            Console.WriteLine("***Loai nhan vien : ");
            Console.WriteLine("**1. Nhân viên phòng thí nghiệm  : ");
            Console.WriteLine("**2. Nhà khoa học : ");
            Console.WriteLine("**3. Nhà quản lý : ");

            int choice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien {0}: ", i);

                arrayS[i] = nhap1SV(choice);
            }

            return arrayS;
        }

        public static void xuatDS(int n, List<NhanVien> arrayS)
        {
            Console.WriteLine("****Danh sách nhân viên****");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("****Nhân viên {0}", i);
                arrayS[i].inThongTin();

            }
        }
    }
}
