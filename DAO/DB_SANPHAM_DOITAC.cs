using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using Dapper;
using System.Data;
using System.Windows.Forms;
namespace DAO
{
    public class DB_SANPHAM_DOITAC
    {
        public static DataTable getdsSPDoiTac(string username, string pass)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("select * from sanpham_doitac", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                dt.Columns["MOTA"].ColumnName = "Mô Tả";
                dt.Columns["MADT"].ColumnName = "Đối tác";
                dt.Columns["MASP"].ColumnName = "Mã SP";
                dt.Columns["SLDH"].ColumnName = "DH/ngày";
                dt.Columns["GIA"].ColumnName = "Giá";
                //dt.Columns["GIA"].DataType = typeof(UInt32);
                dt.Columns["SLTON"].ColumnName = "SL Tồn";
                //dt.Columns["TENSP"].ColumnName = "Tên SP";
            }
            return dt;

        }
        public static void UpdateSLTon(string username, string password, int slton, int masp, string madt)
        {
            try
            {
                DBConnect _dbContext = new DBConnect();
                SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, password);
                SqlCommand command = new SqlCommand("exec sp_DoiSLTonSP_DT " + masp + ", '" + madt + "'," + slton, _dbConnection);
                // DataTable dt = new DataTable();
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật số lượng tồn thành công!");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("ERROR" + ex.Message );
            }
        }
        public static void UpdateSLDH(string username, string password, int sldh, int masp, string madt)
        {
            try
            {
                DBConnect _dbContext = new DBConnect();
                SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, password);
                SqlCommand command = new SqlCommand("exec sp_DoiSLDHSP_DT " + masp + ", '" + madt + "'," + sldh, _dbConnection);
                // DataTable dt = new DataTable();
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật số lượng đơn hàng thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex.Message);
            }
        }
        public static DataTable getdsSPDoiTac_DT(string username, string pass)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("select * from sanpham_doitac where madt='"+username+"'", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                dt.Columns["MOTA"].ColumnName = "Mô Tả";
                dt.Columns["MADT"].ColumnName = "Đối tác";
                dt.Columns["MASP"].ColumnName = "Mã SP";
                dt.Columns["SLDH"].ColumnName = "DH/ngày";
                dt.Columns["GIA"].ColumnName = "Giá";
                //dt.Columns["GIA"].DataType = typeof(UInt32);
                dt.Columns["SLTON"].ColumnName = "SL Tồn";
                //dt.Columns["TENSP"].ColumnName = "Tên SP";
            }
            return dt;

        }
        public static DataTable TimKiemSPTheoDT(string username, string pass,string maDT)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("exec sp_XemSPTheoDT '" + maDT + "'", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                dt.Columns["MOTA"].ColumnName = "Mô Tả";
                dt.Columns["MADT"].ColumnName = "Đối tác";
                dt.Columns["MASP"].ColumnName = "Mã SP";
                dt.Columns["SLDH"].ColumnName = "DH/ngày";
                dt.Columns["GIA"].ColumnName = "Giá";
                //dt.Columns["GIA"].DataType = typeof(UInt32);
                dt.Columns["SLTON"].ColumnName = "SL Tồn";
                dt.Columns["TENSP"].ColumnName = "Tên SP";
            }
            return dt;

        }
        public static DataTable TimKiemSPTheoTen(string username, string pass, string tensp)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
            SqlCommand command = new SqlCommand("exec sp_XemTheoTen '" + tensp + "'", _dbConnection);
            DataTable dt = new DataTable();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
            if (dt.Columns.Count != 0)
            {
                dt.Columns["MOTA"].ColumnName = "Mô Tả";
                dt.Columns["MADT"].ColumnName = "Đối tác";
                dt.Columns["MASP"].ColumnName = "Mã SP";
                dt.Columns["SLDH"].ColumnName = "DH/ngày";
                dt.Columns["GIA"].ColumnName = "Giá";
                //dt.Columns["GIA"].DataType = typeof(UInt32);
                dt.Columns["SLTON"].ColumnName = "SL Tồn";
                dt.Columns["TENSP"].ColumnName = "Tên SP";
            }
            return dt;
        }
    }
}

