using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
namespace BUS
{
    public class SANPHAM
    {
        public static DataTable getdsSP(string username, string pass)
        {
            return DB_SANPHAM.getdsSP(username, pass);
        }
        public static void updateTenSP(string username, string pass, int maSP, string tenSP)
        {
             
                DB_SANPHAM.UpdateTenSP(username, pass,maSP,tenSP);
        }
    }
}
