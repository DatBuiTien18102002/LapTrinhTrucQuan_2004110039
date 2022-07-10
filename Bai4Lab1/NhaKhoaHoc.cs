using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4Lab1
{
    internal class NhaKhoaHoc:NhanVienCapCao
    {
        private int soBaiBaoDaCongBo;

        public int SoBaiBaoDaCongBo { get => soBaiBaoDaCongBo; set => soBaiBaoDaCongBo = value; }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine("So Bai Bao Da Cong Bo: {0}", SoBaiBaoDaCongBo);
        }


    }
}
