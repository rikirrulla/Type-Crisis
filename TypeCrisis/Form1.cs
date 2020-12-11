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
    public partial class Form1 : Form
    {
       

        int cpt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fotot.Rows.Add(3);

            fotot.Rows[0].Cells[0].Value = Image.FromFile("wallpapers/foto1.png");
            fotot.Rows[1].Cells[0].Value = Image.FromFile("wallpapers/foto2.png");
            fotot.Rows[2].Cells[0].Value = Image.FromFile("wallpapers/foto3.png");
            fotot.Rows[3].Cells[0].Value = Image.FromFile("wallpapers/foto4.png");
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (cpt < fotot.Rows.Count)
            {
                cpt++;
                pictureBox1.Image = (Image)fotot.Rows[cpt - 1].Cells[0].Value;
                if (cpt == 1)
                {
                    
                }

            }
            else
            {
                cpt = 1;
            }
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            if (cpt > 1)
            {
                cpt--;
                pictureBox1.Image = (Image)fotot.Rows[cpt - 1].Cells[0].Value;

            }
            else
            {
                cpt = 1;
            }
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)fotot.Rows[2].Cells[0].Value;

        }

        private void foto1C_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)fotot.Rows[0].Cells[0].Value;

        }

        private void foto2C_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)fotot.Rows[1].Cells[0].Value;

        }

        private void foto4C_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)fotot.Rows[3].Cells[0].Value;

        }

        private void btnLuaj_Click(object sender, EventArgs e)
        {
            Luaj l = new Luaj();
            l.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Piket l = new Piket();
            l.Show();
            this.Hide();
        }
    }
}
