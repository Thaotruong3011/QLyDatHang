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
    public class DB_DONHANG
    {
        public static void ThemDH(string username, string password, DateTime ngaygiao, double TongTB, string dchigiao, string httt, string tinhtrang, List<DTO_SANPHAM_DOITAC> lstSP_DTChon)
        {
            DBConnect _dbContext = new DBConnect();
            DataTable dt = new DataTable();
            string madh;
            SqlTransaction objTrans = null;

            using (SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, password))
            {
                //_dbConnection.Open();
                objTrans = _dbConnection.BeginTransaction("myTransaction");
                List<SqlCommand> lstCommand = new List<SqlCommand>();
                string stringSql = "declare @datetime datetime, @lastID int  " +
                    " set @datetime=GETDATE()" +
                    " exec sp_TaoDonHang @datetime," + TongTB + ",N'" + dchigiao + "',N'" + httt + "',N'" + tinhtrang + "', @lastID output";

                SqlCommand commandDH = new SqlCommand(stringSql, _dbConnection);
               
                try
                {
                    
                    commandDH.Transaction = objTrans;
                    using (SqlDataReader reader = commandDH.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    madh = dt.Rows[0][0].ToString();
                    MessageBox.Show(madh + " ");
                    //_dbConnection.Open();
                    for (int i = 0; i < lstSP_DTChon.Count; i++)
                    {
                        string sqlCTDH = "exec sp_TaoCTDonHang " +madh + "," + lstSP_DTChon[i].masp + ",'" + lstSP_DTChon[i].madt + "'," + lstSP_DTChon[i].soluong;
                        
                        SqlCommand commandCTDH = new SqlCommand(sqlCTDH, _dbConnection);
                        lstCommand.Add(commandCTDH);
                    }
                    for (int i = 0; i < lstCommand.Count; i++)
                    {
                        lstCommand[i].Transaction = objTrans;
                        lstCommand[i].ExecuteNonQuery();
                    }
                    objTrans.Commit();
                    MessageBox.Show("Thêm đơn hàng thành công");
                }
                catch (Exception ex)
                {
                    objTrans.Rollback();
                    MessageBox.Show("ERROR"+ ex.Message+"/n Thêm đơn hàng thất bại!!");
                }
                finally
                {
                    _dbConnection.Close();
                }

                //    try
                //{

                //    objTrans = _dbConnection.BeginTransaction();

                //    // command.ExecuteNonQuery();
                //    try
                //    {
                //        using (SqlDataReader reader = commandDH.ExecuteReader())
                //        {
                //            dt.Load(reader);
                //        }
                //        madh = dt.Rows[0][0].ToString();
                //        MessageBox.Show(madh + " ");
                //        for (int i = 0; i < lstSP_DTChon.Count; i++)
                //        {
                //            string sqlCTDH = "exec sp_TaoCTDonHang" + madh + "," + lstSP_DTChon[i].soluong + ",'" + lstSP_DTChon[i].madt + "'," + lstSP_DTChon[i].masp;
                //            SqlCommand commandCTDH = new SqlCommand(sqlCTDH, _dbConnection);
                //            lstCommand.Add(commandCTDH);
                //        }

                //        for(int i = 0; i < lstCommand.Count; i++)
                //        {
                //            lstCommand[i].ExecuteNonQuery();
                //        }
                //        objTrans.Commit();
                //        MessageBox.Show("Thêm đơn hàng thành công");

                //    }
                //    catch(Exception ex)
                //    {
                //        objTrans.Rollback();
                //        throw new Exception(ex.Message, ex);
                //    }
                //    finally
                //    {
                //       // objConn.Close();
                //    }
                //}

                //catch (Exception ex)
                //{
                //    throw new Exception(ex.Message, ex);
                //}
            }
        }
        public static DataTable XemDSDH_KH(string username, string password)
        {
            DBConnect _dbContext = new DBConnect();
            SqlConnection _dbConnection = _dbContext.creatsqlconnection(username, password);
            SqlCommand command = new SqlCommand(" SELECT * FROM XEMDH()", _dbConnection);
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
