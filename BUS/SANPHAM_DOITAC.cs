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
        public static DataTable getdsSPDoiTac_DT(string username, string pass)
        {
            return DB_SANPHAM_DOITAC.getdsSPDoiTac_DT(username, pass);
        }
        public static DataTable TimKiemSPTheoTen(string username, string pass,string tenSP)
        {   
            return DB_SANPHAM_DOITAC.TimKiemSPTheoTen(username, pass,tenSP);
        }
        public static DataTable TimKiemSPTheoDT(string username, string pass, string maDT)
        {
            return DB_SANPHAM_DOITAC.TimKiemSPTheoDT(username, pass, maDT);
        }
        public static void UpdateSLTon(string username, string password,int slton,int masp, string madt)
        {
            DB_SANPHAM_DOITAC.UpdateSLTon(username, password,slton,masp, madt);
        }
        public static void UpdateSLDH(string username, string password, int sldh, int masp, string madt)
        {
            DB_SANPHAM_DOITAC.UpdateSLDH(username, password, sldh, masp, madt);
        }
    }
}
