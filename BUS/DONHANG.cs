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
    public class DONHANG
    {
        public static void ThemDH(string username, string password, DateTime ngaygiao,double TongTB,string dchigiao, string httt, string tinhtrang,List<DTO_SANPHAM_DOITAC> lstSP_DTChon)
        {
            DB_DONHANG.ThemDH(username, password,ngaygiao,TongTB,dchigiao,httt,tinhtrang,lstSP_DTChon);
        }
        public static DataTable XemDSDH_KH(string username, string password)
        {
            return DB_DONHANG.XemDSDH_KH(username, password);
        }
    }
}
