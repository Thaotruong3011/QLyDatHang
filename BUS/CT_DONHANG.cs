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
    public class CT_DONHANG
    {
        public static DataTable XemDSCTDH_KH(string username, string password)
        {
            return DB_CT_DONHANG.XemDSCTDH_KH(username, password);
        }
    }
}
