using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class SANPHAM_DOITAC
    {
        public static List<DTO_SANPHAM_DOITAC> getdsSPDoiTac(string username, string pass)
        {
            return DB_SANPHAM_DOITAC.getdsSPDoiTac(username, pass);
        }
    }
}
