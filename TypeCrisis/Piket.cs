using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeCrisis
{
    public partial class Piket : Form
    {
        private Connection conn = new Connection();
        Luaj luaj = new Luaj();
        Form1 form1 = new Form1();

        public Piket()
        {
            InitializeComponent();
            fillTableAdmins();
        }

        private void fillTableAdmins()
        {
            CD_Piket cDA = new CD_Piket();
            table.DataSource = cDA.FillData();
        }

        private void btnPiketMeSeShumti_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            DataTable dataTable = new DataTable();




            connection = conn.Open();
            cmd.Connection = connection;
            cmd.CommandText = "select COUNT(Piket) AS Rekordi_eshte from type_crisis";
            dr = cmd.ExecuteReader();


            dataTable.Load(dr);
            table.DataSource = dataTable;




            conn.closeConnection();
            connection.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnLuaj_Click(object sender, EventArgs e)
        {
            Luaj l = new Luaj();
            l.Show();
            this.Hide();

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }
    }
}
