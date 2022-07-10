using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3Lap1
{
    internal abstract class People
    {
        private string ten;
        public String getten()
        {
            return ten;
        }
        public void setten(String ten)
        {
            this.ten = ten;
        }
    }
}
