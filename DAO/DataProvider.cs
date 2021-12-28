using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    class DataProvider
        {
            private static DataProvider instance;
            internal static DataProvider Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DataProvider();
                    return DataProvider.instance;
                }
                private set => instance = value;
            }

            private DataProvider() { }

            private String connectionSTR = @"Data Source=THAOTRUONG\SQL;Initial Catalog=QLDCHO;Integrated Security=True";


            public DataTable ExecuteQuery(String query)
            {
                DataTable data = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);


                    connection.Close();
                }


                return data;
            }

            public int ExecuteNonQuery(String query)
            {   
                int data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    data = command.ExecuteNonQuery();

                    connection.Close();
                }

                return data;
            }

            public object ExecuteSaclar(String query)
            {
                object data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    data = command.ExecuteScalar();

                    connection.Close();
                }

                return data;
            }
        }

    }

