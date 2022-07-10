using Bai3Lap1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1Lab1
{
    internal class Student:People
    {
        private int sID;
        private string khoa;
        private double diemTB;

        
        public int getsID()
        {
            return sID;
        }

        public void setsID(int sID)
        {
            this.sID = sID;
        }


        public String getKhoa()
        {
            return khoa;
        }
        public void setKhoa(String khoa)
        {
            this.khoa = khoa;
        }
        public double getDiemTB()
        {
            return diemTB;
        }
        public void setDiemTB(double diemTB)
        {
            this.diemTB = diemTB;
        }
        public void inThongTin()
        {
            Console.WriteLine("Ma so sinh vien: {0}", getsID());
            Console.WriteLine("Ten sinh vien: {0}", getten());
            Console.WriteLine("Khoa sinh vien: {0}", getKhoa());
            Console.WriteLine("Diem trung binh sinh vien: {0}", getDiemTB());
        }




    }
}
