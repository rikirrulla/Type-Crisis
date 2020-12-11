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
    public partial class ShkruajEmrin : Form
    {
        CD_Piket cD_Piket = new CD_Piket();
        public ShkruajEmrin()
        {
            InitializeComponent();
        }

      
        private void btnFillo_Click(object sender, EventArgs e)
        {
            int pik = 0;
            Luaj l = new Luaj();
            pik = l.piketDB();
            l.ndrysho();

            if (emriLojtarit.Text == null)
            {
                MessageBox.Show("Emri eshte i zbrazet");
            }
            else
            {
                cD_Piket.InsertoPiket(emriLojtarit.Text, pik);
                this.Hide();
            }
        }
    }
}
