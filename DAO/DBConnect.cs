using System;
using System.Collections.Generic;
using System.Windows;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAO
{
    public class DBConnect
    {
        public static string CnnVal(string name)
        {
            //    //  //          SqlConnection conn = new SqlConnection();
            //    //  //          conn.ConnectionString = @"Data Source=THAOTRUONG\SQL;" +
            //    //  //"Initial Catalog=QLDCHO;" +
            //    //  //"User id=thaotruong@gmail;" +
            //    //  //"Password=123456;";

            //    //    //        SqlConnection conn1 = new SqlConnection(
            //    //    //new SqlConnectionStringBuilder()
            //    //    //{
            //    //    //    DataSource = @"THAOTRUONG\SQL",
            //    //    //    InitialCatalog = "QLDCHO",
            //    //    //    UserID = "thaotruong@gmail",
            //    //    //    Password = "123456"
            //    //    //}.ConnectionString
            //    ////);
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        //public void Dispose()
        //{
        //    if (conn1 != null && _connection.State == ConnectionState.Open)
        //    {
        //        _connection.Close();
        //        _connection = null;
        //    }
        public IDbConnection CreateConnection(string username, string pass)
        {
            //SqlConnection conn1 = new SqlConnection();
            //conn1.ConnectionString = @"Data Source=THAOTRUONG\SQL;" +
            //"Initial Catalog=QLDCHO;" +
            //  "User id=thaotruong@gmail"
            // + "password=123456;";
            ////conn1.ConnectionString = @"Data Source = THAOTRUONG\SQL; Initial Catalog = QLDCHO; Integrated Security = True";

            //            MySQLHelper.ExecuteNonQuery(
            //ConfigurationManager.ConnectionStrings["QUANLYTRUNGTAMTINHOC"].ConnectionString,
            //CommandType.Text,
            //sqlQuery,
            //sqlParams);
            //string strConString = CnnVal("QUANLYTRUNGTAMTINHOC");

            ///var conn1 = new SqlConnection(@"Data Source=THAOTRUONG\SQL;Initial Catalog=QLDCHO;Integrated Security=True");
            var conn1 = new SqlConnection(@"Data Source=THAOTRUONG\SQL;Initial Catalog=QLDCHO;User ID=" + username + " ; Password=" + pass + " ;");
            try
            {
                conn1.Open();
                conn1.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Timed Out");
                return new SqlConnection();
            }

            //return new SqlConnection(strConString);
            return conn1;
        }
       public SqlConnection creatsqlconnection(string username, string pass)
        {
            var conn1 = new SqlConnection(@"Data Source=THAOTRUONG\SQL;Initial Catalog=QLDCHO;User ID=" + username + " ; Password=" + pass + " ;");
            try
            {
                conn1.Open();
               // conn1.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Timed Out");
                return new SqlConnection();
            }

            //return new SqlConnection(strConString);
            return conn1;
        }

    }
}
