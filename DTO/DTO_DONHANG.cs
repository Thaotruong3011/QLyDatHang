using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DONHANG
    { 
        public DTO_DONHANG(int madh1,string makh1,string txgiao1,string ngaylap1,float tongtien1,string dcgiaohang1, string httt1,string ttdh1)
        {
            madh = madh1;
            makh = makh1;
            txgiao = txgiao1;
            ngaylap = ngaylap1;
            tongtien = tongtien1;
            dcgiaohang = dcgiaohang1;
            hinhthucthanhtoan = httt1;
            tinhtrangdonhang = ttdh1;
        }
        public DTO_DONHANG()
        {
            madh = 1;
            makh = " ";
            txgiao = " ";
            ngaylap = " ";
            tongtien = 0;
            dcgiaohang = " ";
            hinhthucthanhtoan = " ";
            tinhtrangdonhang = " ";
        }


        public int madh;
        public string makh;
        public string txgiao;
        public string ngaylap;
        public float tongtien;
        public string dcgiaohang;
        public string hinhthucthanhtoan;
        public string tinhtrangdonhang;
        
    }
}
