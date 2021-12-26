using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HOPDONG
    {
        public DTO_HOPDONG(int mahd1, string madt1,string nvduyet1, string mathue1,string nguoidd1, int socn1,string dccn1, string ngaybd1, string ngaykt1, float phh)
        {
            mahd = mahd1;
            madt = madt1;
            nvduyet = nvduyet1;
            mathue = mathue1;
            nguoidaidien = nguoidd1;
            sochinhanh = socn1;
            diachicn = dccn1;
            ngaybd = ngaybd1;
            ngaykt = ngaykt1;
            phihoahong = phh;
        }
        public DTO_HOPDONG()
        {
            mahd = 0;
            madt = " ";
            nvduyet = " ";
            mathue = " ";
            nguoidaidien = " ";
            sochinhanh = 0;
            diachicn = " ";
            ngaybd = " ";
            ngaykt = " ";
            phihoahong =0;
        }
        public int mahd;
        public string madt;
        public string nvduyet;
        public string mathue;
        public string nguoidaidien;
        public int sochinhanh;
        public string diachicn;
        public string ngaybd;
        public string ngaykt;
        public float phihoahong;

    }
}
