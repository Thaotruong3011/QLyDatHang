using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CT_DONHANG
    {
        public DTO_CT_DONHANG( int madh1, int masp1, string madt1, int soluong1, float thanhtien1)
        {
            madh = madh1;
            masp = masp1;
            madt = madt1;
            soluong = soluong1;
            thanhtien = thanhtien1;
    }
        public DTO_CT_DONHANG()
        {
            madh =1 ;
            masp = 1;
            madt = "DT001" ;
            soluong =0;
            thanhtien =0 ;
        }

        public int madh;
        public int masp;
        public string madt;
        public int soluong;
        public float thanhtien;
    }
}
