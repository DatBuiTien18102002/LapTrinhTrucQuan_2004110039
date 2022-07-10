using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Lab1
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            Student[] arrayS = new Student[n];

            for (int i = 0; i<n;i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien {0}: ", i);
                Student student = new Student();
                Console.Write("Nhap ma sinh vien: ");
                student.SID = Convert.ToInt32(Console.ReadLine());  
                Console.Write("Nhap ten sinh vien: ");
                student.TenSV = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap khoa cua sinh vien: ");
                student.Khoa = Convert.ToString(Console.ReadLine());
                Console.Write("Nhap diem trung binh cua sinh vien: ");
                student.DiemTB = Convert.ToDouble(Console.ReadLine());
                arrayS[i] = student;
            }
            Console.WriteLine("****Danh sách sinh viên****");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("****Sinh vien {0}",i);
                arrayS[i].inThongTin();

            }
        }
    }
}
