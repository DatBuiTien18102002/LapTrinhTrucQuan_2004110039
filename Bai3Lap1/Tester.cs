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
            List<Student> arrayS = new List<Student>(n);

            arrayS =  nhapDS(n);
            xuatDS(n, arrayS);
        }

        public static Student nhap1SV()
        {
            Student student = new Student();
            Console.Write("Nhap ma sinh vien: ");
            student.setsID(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Nhap ten sinh vien: ");
            student.setten(Convert.ToString(Console.ReadLine()));
            Console.Write("Nhap khoa cua sinh vien: ");
            student.setKhoa(Convert.ToString(Console.ReadLine()));
            Console.Write("Nhap diem trung binh cua sinh vien: ");
            student.setDiemTB(Convert.ToDouble(Console.ReadLine()));

            return student;

        }

        public static List<Student> nhapDS(int n)
        {

            List<Student> arrayS = new List<Student>(n);

            Student student = new Student();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien {0}: ", i);
                student =  nhap1SV();
                arrayS[i] = student;
            }

            return arrayS;
        }

        public static void xuatDS(int n, List<Student> arrayS)
        {
            Console.WriteLine("****Danh sách sinh viên****");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("****Sinh vien {0}", i);
                arrayS[i].inThongTin();

            }
        }
    }
}
