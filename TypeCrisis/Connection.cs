using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeCrisis
{
    class Connection
    {
        static string host = "localhost";
        static string database = "typecrisis";
        static string userDB = "root";
        static string password = "";
        private string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
        private MySqlConnection conn;


        public MySqlConnection Open()
        {
            try
            {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password + ";pooling = false; convert zero datetime=True";
                conn = new MySqlConnection(strProvider);
                conn.Open();

            }
            catch (Exception er)
            {
                MessageBox.Show("Ju lutem lidhuni me databaze ! ", "Information");
            }
            return conn;

        }

        public MySqlConnection closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
            return conn;
        }


    }
}
