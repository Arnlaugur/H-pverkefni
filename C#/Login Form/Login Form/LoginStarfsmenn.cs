using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class LoginStarfsmenn : Form
    {
        string Notandi = null;
        string mætting = null;
<<<<<<< HEAD
=======
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
>>>>>>> master
        string nafn = null;
        public LoginStarfsmenn(string xnafn, string xNotandi)
<<<<<<< HEAD

        {
            InitializeComponent();
=======
        {
            InitializeComponent();
            
>>>>>>> master
            try
            {
                Notandi = xNotandi;
                gagnagrunnur.TengingVidGagnagrunn();
                nafn = xnafn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            mætting = gagnagrunnur.mæting(Notandi);
            if (mætting == "0")
            {
                btSkráSemMættur.Text = "Skrá sem mættur";
            }
            else if (mætting == "1")
            {
                btSkráSemMættur.Text = "Útskrá";
            }
        }

        private void btSkráSemVeikur_Click(object sender, EventArgs e)
        {
            
            if ( btSkráSemVeikur.Text == "Skrá sem veikur")
            {
                btSkráSemVeikur.Text = "Skrá úr veikindum";
                gagnagrunnur.Veikur(Notandi);
            }
            else if (btSkráSemVeikur.Text == "Skrá úr veikindum")
            {
                btSkráSemVeikur.Text = "Skrá sem veikur";
                gagnagrunnur.EkkiVeikur(Notandi);
            }
        }

        private void btSkráIFrí_Click(object sender, EventArgs e)
        {
            if (btSkráIFrí.Text == "Skrá í frí")
            {
<<<<<<< HEAD
                btSkráIFrí.Text = "Skrá úr fríi";
                
=======
                btSkráIFrí.Text = "Srká úr fríi";
                gagnagrunnur.FaraÍFrí(Notandi);
>>>>>>> master
            }
            else if (btSkráIFrí.Text == "Skrá úr fríi")
            {
                btSkráIFrí.Text = "Skrá í frí";
                gagnagrunnur.FaraÚrFríi(Notandi);
            }
        }
        
        private void btSkráSemMættur_Click(object sender, EventArgs e)
        {
            
            if (btSkráSemMættur.Text == "Skrá sem mættur")
            {
                btSkráSemMættur.Text = "Útskrá";
                gagnagrunnur.Innskra(Notandi);
            }
            else if (btSkráSemMættur.Text == "Útskrá")
            {
                btSkráSemMættur.Text = "Skrá sem mættur";
                gagnagrunnur.Utskra(Notandi);
            }
        }

        private void LoginStarfsmenn_Load(object sender, EventArgs e)
        {
            labelVelkominn.Text = "Velkomin/n " + nafn;
            labelMotd.Text = "Motd: " + gagnagrunnur.Motd2();
        }
    }
}
