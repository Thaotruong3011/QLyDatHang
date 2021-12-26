using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHACHHANG
    { 
        public DTO_KHACHHANG(string email1, string pass1, string sdt1, string diachi1)
        {
            email = email1;
            sdt = sdt1;
            diachi = diachi1;
            pass = pass1;
        }
        public DTO_KHACHHANG()
        {
            email = " ";
            sdt = " ";
            diachi = " ";
            pass = " ";
        }
        public string email;
        public string pass;
        public string sdt;
        public string diachi;
    }
}
