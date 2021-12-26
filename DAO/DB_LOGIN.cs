using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;
namespace DAO
{
    public  class DB_LOGIN
    {
        public DataTable connect(string acc, string pass)
        {
            string t = "exec sp_login '" + acc + "' ,'" + pass + "'";
            MessageBox.Show(t);
            return DataProvider.Instance.ExecuteQuery(t);
        }
    }
}
