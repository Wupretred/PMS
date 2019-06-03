using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PMS
{
    public static class SetConnection
    {
        public static SqlConnection sqlConnection = null;
        public static string passwd = "1641117";

        public static SqlConnection GetConnection()
        {
            try
            {
                string myConnString =
                    "Data Source=.;Initial Catalog=PMS;Persist Security Info=True;User ID=sa;Password=" + passwd;
                sqlConnection = new SqlConnection(myConnString); //实例化连接对象
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("数据库连接错误。");
            }

            return sqlConnection;
        }
    }
}