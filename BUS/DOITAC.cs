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
        public static List<DTO_DOITAC> getdsDoiTac(string username, string pass)
        {
            return DB_DOITAC.getdsDoiTac(username,pass);
        }
    }
}
