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
        public static DataTable getdsDoiTac(string username, string pass)
        {
           
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("select * from XemTTDOITAC()", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                dt.Columns["SOCHINHANH"].ColumnName = "Số Chi Nhánh";
                dt.Columns["MADT"].ColumnName = "Mã DT";
                dt.Columns["TENDT"].ColumnName = "Tên ĐT";
                dt.Columns["NGUOIDAIDIEN"].ColumnName = "Người Đại Diện";
                dt.Columns["THANHPHO"].ColumnName = "Thành Phố";
                dt.Columns["DIACHIKD"].ColumnName = "Địa chỉ KD";
                dt.Columns["SDT"].ColumnName = "SDT";
                dt.Columns["EMAIL"].ColumnName = "Email";
              
            }
            return dt;
        }
        public static DataTable getdsDoiTac_QTV(string username, string pass)
        {

            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("select * from DOITAC", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                dt.Columns["SOCHINHANH"].ColumnName = "Số Chi Nhánh";
                dt.Columns["MADT"].ColumnName = "Mã DT";
                dt.Columns["PASS"].ColumnName = "PASS";
                dt.Columns["TENDT"].ColumnName = "Tên ĐT";
                dt.Columns["NGUOIDAIDIEN"].ColumnName = "Người Đại Diện";
                dt.Columns["THANHPHO"].ColumnName = "Thành Phố";
                dt.Columns["DIACHIKD"].ColumnName = "Địa chỉ KD";
                dt.Columns["SDT"].ColumnName = "SDT";
                dt.Columns["EMAIL"].ColumnName = "Email";

            }
            return dt;
        }
        public static DataTable TimKiemDTTheoMa(string username, string pass,string madt)
        {

            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("exec sp_XemDTTheoMa '"+madt+"'", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                dt.Columns["SOCHINHANH"].ColumnName = "Số Chi Nhánh";
                dt.Columns["MADT"].ColumnName = "Mã DT";
                dt.Columns["TENDT"].ColumnName = "Tên ĐT";
                dt.Columns["NGUOIDAIDIEN"].ColumnName = "Người Đại Diện";
                dt.Columns["THANHPHO"].ColumnName = "Thành Phố";
                dt.Columns["DIACHIKD"].ColumnName = "Địa chỉ KD";
                dt.Columns["SDT"].ColumnName = "SDT";
                dt.Columns["EMAIL"].ColumnName = "Email";

            }
            return dt;
        }
        public static void ThemDT_QTV(string username, string password, string ma, string pass, int socn, string tendt, string nguoidd, string thanhpho, string diachikd, string sdt, string email)
        {

            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, password);
            SqlCommand command = new SqlCommand("insert into DOITAC (MADT,PASS,SOCHINHANH,TENDT,NGUOIDAIDIEN,THANHPHO,DIACHIKD,SDT,EMAIL) VALUES('" +
                ma + "','" + pass + "'," + socn + ",N'" + tendt + "',N'" + nguoidd + "',N'" + thanhpho + "',N'" + diachikd + "',N'" + sdt + "','" + email + "')", _dbConnection) ;
           
        }

    }
}
