using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DB_SANPHAM
    {
        public static DataTable getdsSP(string username, string pass)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("select * from sanpham", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            { 
                dt.Columns["MASP"].ColumnName = "Mã SP";
                dt.Columns["TENSP"].ColumnName = "Tên SP";
                dt.Columns["TONGSL"].ColumnName = "Tổng SL";
                dt.Columns["LOAIHANG"].ColumnName = "Loại hàng";
                dt.Columns["SLDT"].ColumnName = "SL Đối Tác";
            }
            return dt;
        }
        public static void UpdateTenSP(string username, string pass,int masp, string tensp)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("exec sp_UpdateTenSP "+masp+",'"+tensp+"'", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
        }
    }
}
