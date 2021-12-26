using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Dapper;
using System.Data;
namespace DAO
{
    public class DB_SANPHAM_DOITAC
    {
        public static List<DTO_SANPHAM_DOITAC> getdsSPDoiTac(string username, string pass)
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection(username, pass))
            {
                var output = _dbConnection.Query<DTO_SANPHAM_DOITAC>($"select * from sanpham_doitac").ToList();
                return output;
                //select* from XemTTDOITAC()
            }
        }
    }
}
