using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;
using System.Windows.Forms;
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
            try
            {
                //string sscore;
                SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, pass);
                SqlCommand command = new SqlCommand("declare @message nvarchar(50)  exec sp_XemDTTheoMa '" + madt + "',@message", _dbConnection);
                DataTable dt = new DataTable();
                DataTable dtAll = new DataTable();

                List<DataTable> dataTables=new List<DataTable>();
                using (IDataReader dataReader = command.ExecuteReader())
                {
                    do
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);
                        dataTables.Add(dataTable);
                    }
                    while (!dataReader.IsClosed);
                }
               
                if (dataTables[0].Columns.Count <= 1 && dataTables[0].Rows.Count<=1)
                {
                  
                    dataTables[1].Columns["SOCHINHANH"].ColumnName = "Số Chi Nhánh";
                    dataTables[1].Columns["MADT"].ColumnName = "Mã DT";
                    dataTables[1].Columns["TENDT"].ColumnName = "Tên ĐT";
                    dataTables[1].Columns["NGUOIDAIDIEN"].ColumnName = "Người Đại Diện";
                    dataTables[1].Columns["THANHPHO"].ColumnName = "Thành Phố";
                    dataTables[1].Columns["DIACHIKD"].ColumnName = "Địa chỉ KD";
                    dataTables[1].Columns["SDT"].ColumnName = "SDT";
                    dataTables[1].Columns["EMAIL"].ColumnName = "Email";
                    return dataTables[1];

                }
                else if (dataTables[0].Columns.Count > 1 && dataTables[0].Rows.Count>=1)
                {
                    dataTables[0].Columns["SOCHINHANH"].ColumnName = "Số Chi Nhánh";
                    dataTables[0].Columns["MADT"].ColumnName = "Mã DT";
                    dataTables[0].Columns["TENDT"].ColumnName = "Tên ĐT";
                    dataTables[0].Columns["NGUOIDAIDIEN"].ColumnName = "Người Đại Diện";
                    dataTables[0].Columns["THANHPHO"].ColumnName = "Thành Phố";
                    dataTables[0].Columns["DIACHIKD"].ColumnName = "Địa chỉ KD";
                    dataTables[0].Columns["SDT"].ColumnName = "SDT";
                    dataTables[0].Columns["EMAIL"].ColumnName = "Email";
                    return dataTables[0];
                }
                
                return dataTables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
           
        }
        public static void ThemDT_QTV(string username, string password, string ma, string pass, int socn, string tendt, string nguoidd, string thanhpho, string diachikd, string sdt, string email)
        {

            DBConnect _dbContext = new DBConnect();
            //StringBuilder sb = new StringBuilder("");
           
            try
            {
                SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, password);
                string stringSql = "insert into DOITAC ([MADT],[PASS],[SOCHINHANH],[TENDT],[NGUOIDAIDIEN],[THANHPHO],[DIACHIKD],[SDT],[EMAIL]) VALUES('" +
                     ma + "','" + pass + "'," + socn + ",N'" + tendt + "',N'" + nguoidd + "',N'" + thanhpho + "',N'" + diachikd + "',N'" + sdt + "','" + email + "')";
                string stringproc = "exec sp_ThemDT '" +
                     ma + "','" + pass + "'," + socn + ",N'" + tendt + "',N'" + nguoidd + "',N'" + thanhpho + "',N'" + diachikd + "',N'" + sdt + "','" + email + "'";
                SqlCommand command = new SqlCommand(stringSql, _dbConnection);
                MessageBox.Show(stringproc);
                command.ExecuteNonQuery();
                //string result;
                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                //    result.(reader);
                //}
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            
        }

    }
}
