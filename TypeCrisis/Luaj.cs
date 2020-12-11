using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeCrisis
{
    public partial class Luaj : Form
    {
    
        CD_Piket cD_Piket = new CD_Piket();
        string fjala = null;
        string[] fjalet = new string[10] {"behane", "hukubet", "kallashter", "kuvendar", "munafik", "pupteshk", "tokmak", "xhokaxhi", "govate", "fanoz" };
        int timeleft = 5;
        public static int piket = 0;

       public Luaj()
        {
            InitializeComponent();
            randomFillimi();
            labelFjala.Text = fjala;

        }

        public  int piketDB()
        {
            return piket;
        }

        public void ndrysho()
        {
            lblPiketRuaj.Text = "0";
            piket = 0;
        }

        private void btnFillo_Click(object sender, EventArgs e)
        {
            textBoxShkruaj.Focus();
            textBoxShkruaj.Text = "";
            textBoxShkruaj.TabIndex = 1;
            btnFillo.Visible = false;
            lblKohaTimer.Visible = true;
            lblKoha.Visible = true;
            lblPiketRuaj.Visible = true;
            lblPiket.Visible = true;
            timer1.Start();
            timer1.Enabled = true;
        }

        private Boolean validoFjalet()
        {
            if(textBoxShkruaj.Text == fjala)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;
        }

        void randomFillimi()
        {
            Random rnd = new Random();
            int index = rnd.Next(fjalet.Length);
            fjala = fjalet[index];
            labelFjala.Text = fjala;
        }

        void random()
        {
            Random rnd = new Random();
            int index = rnd.Next(fjalet.Length);
            fjala = fjalet[index];
            labelFjala.Text = fjala;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeleft--;
            lblKohaTimer.Text = timeleft.ToString()+" sec";
            lblPiketRuaj.Text = piket.ToString();
      
            if(validoFjalet() == true)
            {
                piket++;
                timer1.Stop();
                random();
                timeleft = 5;
                textBoxShkruaj.Text = "";
            }


            if (timeleft == 0)
            {
                timer1.Stop();
                lojaPerfundoi();
            }

            
        }

        private void lojaPerfundoi()
        {
            btnProvoPerseri.Visible = true;
            btnRuajPiket.Visible = true;
            lbllojaPerfundoi.Visible = true;
        }

        private void btnProvoPerseri_Click(object sender, EventArgs e)
        {
            lblPiketRuaj.Text = "0";
            piket = 0;
            btnProvoPerseri.Visible = false;
            btnRuajPiket.Visible = false;
            lbllojaPerfundoi.Visible = false;
            timer1.Start();
            timeleft = 5;
        }

        

        private void btnRuajPiket_Click(object sender, EventArgs e)
        {
            ShkruajEmrin em = new ShkruajEmrin();
            em.Show();            
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {

            Piket l = new Piket();
            l.Show();
            this.Hide();


        }

        private void btnLuaj_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
           
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
