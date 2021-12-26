using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;
namespace DAO
{
    public class DB_DOITAC
    {
        public static List<DTO_DOITAC> getdsDoiTac(string username, string pass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection( username, pass))
            {
                var output = _dbConnection.Query<DTO_DOITAC>($"select * from XemTTDOITAC()").ToList();
                return output;
                //select* from XemTTDOITAC()
            }
        }
    }
}
