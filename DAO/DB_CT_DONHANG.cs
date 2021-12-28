using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DB_CT_DONHANG
    {
        public static DataTable XemDSCTDH_KH(string username, string password)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, password);
            SqlCommand command = new SqlCommand(" SELECT * FROM XemCTDHAll()", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                //dt.Columns["MOTA"].ColumnName = "Mô Tả";
                //dt.Columns["MADT"].ColumnName = "Đối tác";
                //dt.Columns["MASP"].ColumnName = "Mã SP";
                //dt.Columns["SLDH"].ColumnName = "DH/ngày";
                //dt.Columns["GIA"].ColumnName = "Giá";
                ////dt.Columns["GIA"].DataType = typeof(UInt32);
                //dt.Columns["SLTON"].ColumnName = "SL Tồn";
                ////dt.Columns["TENSP"].ColumnName = "Tên SP";
            }
            return dt;
        }
    }
}
