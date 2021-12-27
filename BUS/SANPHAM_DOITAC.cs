using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class SANPHAM_DOITAC
    {
        public static DataTable getdsSPDoiTac(string username, string pass)
        {
            return DB_SANPHAM_DOITAC.getdsSPDoiTac(username, pass);
        }
        public static DataTable TimKiemSPTheoTen(string username, string pass,string tenSP)
        {   
            return DB_SANPHAM_DOITAC.TimKiemSPTheoTen(username, pass,tenSP);
        }
        public static DataTable TimKiemSPTheoDT(string username, string pass, string maDT)
        {
            return DB_SANPHAM_DOITAC.TimKiemSPTheoDT(username, pass, maDT);
        }
    }
}
