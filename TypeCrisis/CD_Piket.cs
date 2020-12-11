using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCrisis
{
    class CD_Piket
    {
        private Connection conn = new Connection();

        public DataTable dataTable = new DataTable();
       

        public DataTable FillData()
        {
            MySqlConnection connection;
            MySqlCommand cmd = new MySqlCommand();

            connection = conn.Open();
            cmd.Connection = connection;

            cmd.CommandText = "select lojtari,piket from type_crisis";
            //cmd.CommandType = CommandType.Text;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dataTable);


            //dataGridView1.DataBindings;
            conn.closeConnection();
            connection.Close();


            return dataTable;
        }

        public void InsertoPiket(string lojtari, int piket)
        {
            MySqlConnection connection;
            MySqlCommand cmd = new MySqlCommand();

            connection = conn.Open();
            cmd.Connection = connection;

            cmd.CommandText = "insert into type_crisis (lojtari,piket) values ('" + lojtari+"', '"+piket.ToString()+"')";
            cmd.ExecuteNonQuery();


            conn.closeConnection();
            connection.Close();

        }
    }
}
