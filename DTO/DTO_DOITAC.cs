using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DOITAC
    {
        public DTO_DOITAC(string madt1, int socn1,string tendt1,string nguoidd1,string tp1,string dckd,string sdt1,string email1,string nvduyet1,string pass1)
        {
            madt = madt1;
            sochinhanh = socn1;
            tendt = tendt1;
            nguoidaidien = nguoidd1;
            thanhpho = tp1;
            diachikd = dckd;
            sdt = sdt1;
            email = email1;
            // nvduyet = nvduyet1;
            pass = pass1;
        }
        public DTO_DOITAC()
        {
            madt =" ";
            sochinhanh = 0;
            tendt = " ";
            nguoidaidien = " ";
            thanhpho = " ";
            diachikd = " ";
            sdt = " ";
            email = " ";
            // nvduyet = " ";
            pass = " ";
        }
        public string madt { get; set; }
        public string pass { get; set; }
        public int sochinhanh { get; set; }
        public string tendt { get; set; }
        public string nguoidaidien { get; set; }
        public string thanhpho { get; set; }
        public string diachikd { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        //public string nvduyet { get; set; }

    }
}
