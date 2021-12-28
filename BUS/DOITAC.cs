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
    public class DOITAC
    {
        public static DataTable getdsDoiTac(string username, string pass)
        {
            return DB_DOITAC.getdsDoiTac(username,pass);
        }
        public static DataTable TimKiemDTTheoMa(string username, string pass,string madt)
        {
            return DB_DOITAC.TimKiemDTTheoMa(username, pass,madt);
        }
        public static DataTable getdsDoiTac_QTV(string username, string pass)
        {
            return DB_DOITAC.getdsDoiTac_QTV(username, pass);
        }
        public static void ThemDT_QTV(string username, string password, string ma, string pass,int socn, string tendt, string nguoidd, string thanhpho, string diachikd, string sdt, string email)
        {
             DB_DOITAC.ThemDT_QTV(username, password, ma,pass,socn,tendt, nguoidd, thanhpho,diachikd,sdt,email);
        }
    }
}
