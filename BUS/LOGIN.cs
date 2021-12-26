using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DAO;
namespace BUS
{
    public class LOGIN
    {
        public DataTable con(string acc, string pass)
        {
            DB_LOGIN lg = new DB_LOGIN();
            DataTable dt = lg.connect(acc, pass);
            //if (dt.Rows.Count > 0)
            //{   
                return dt;
            //}

            //return null;
        }
    }
}
