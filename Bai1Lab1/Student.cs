using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Lab1
{
    internal class Student
    {
        private int sID;
        private string tenSV;
        private string khoa;
        private double diemTB;

        public int SID //Property dai dien cho thuoc tinh SID
        {
            get { return sID; } //Lay du lieu
            set { sID = value; } //Gan du lieu
        }

        public String TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }

        public String Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }

        public double DiemTB
        {
            get { return diemTB; }
            set { diemTB = value; }
        }

        public void inThongTin()
        {
            Console.WriteLine("Ma so sinh vien: {0}",SID);
            Console.WriteLine("Ten sinh vien: {0}", tenSV);
            Console.WriteLine("Khoa sinh vien: {0}", khoa);
            Console.WriteLine("Diem trung binh sinh vien: {0}", diemTB);
        }


    }
}
