using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace P_Prod_LeonardFrauchiger_MysqlCsharp
{
    class Network
    {
        public void Connect(string userName, string password, string server, string database)
        {
            string connstring = @"server="+server+";user="+userName+";password="+password+";database="+database;

            MySqlConnection conn = null;

            try
            {
                
                conn = new MySqlConnection(connstring);
                conn.Open();

                string query = "SELECT * FROM test;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "test");
                System.Data.DataTable dt = ds.Tables["test"];
                Login login = new Login();
                login.Hide();
                Main main = new Main();
                main.Show();

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    foreach (System.Data.DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col] + "\t");
                    }

                    Console.Write("\n");
                }
            }
            catch (Exception e)
            {
                Login login = new Login();
                login.Message("Error: {0}" + e.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
