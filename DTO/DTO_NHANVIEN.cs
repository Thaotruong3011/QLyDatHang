using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NHANVIEN
    {  public DTO_NHANVIEN(string manv1,string hoten1,string cmnd1,string sdt1,string diachi1,string email1,string tknh1, string loainv1,string pass1)
        {
            manv = manv1;
            hoten = hoten1;
            cmnd = cmnd1;
            sdt = sdt1;
            diachi = diachi1;
            email = email1;
            tknh = tknh1;
            loainv = loainv1;
            pass = pass1;
        }
        public DTO_NHANVIEN()
        {
            manv =" ";
            hoten = " ";
            cmnd = " ";
            sdt = " ";
            diachi = " ";
            email = " ";
            tknh = " ";
            loainv = " ";
            pass = " ";
        }
        public string manv;
        public string pass;
        public string hoten;
        public string cmnd;
        public string sdt;
        public string diachi;
        public string email;
        public string tknh;
        public string loainv;

    }
}
