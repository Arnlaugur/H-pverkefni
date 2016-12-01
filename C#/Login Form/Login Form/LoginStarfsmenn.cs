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
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public LoginStarfsmenn(string xNotandi)
        {
            InitializeComponent();
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
                Notandi = xNotandi;
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
        /*
         ====================================== 
                     btSkráSemVeikur_Click:
         Notandi verður skráður sem 'veikur'
         ef ýtt er á þennan takka
         ======================================
        */
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
        /*
         ====================================== 
                     btSkráÍFrí_Click:
         Notandi fær að biðja um frí og send verður 
         skilaboð til yfirmanns ef ýtt er á þennan takka
         ======================================
        */
        private void btSkráIFrí_Click(object sender, EventArgs e)
        {
            if (btSkráIFrí.Text == "Skrá í frí")
            {
                btSkráIFrí.Text = "Skrá úr fríi";
                gagnagrunnur.FaraÍFrí(Notandi);
                btSkráIFrí.Text = "Skrá úr fríi";
                string skilaboð = Notandi + " biður um frí í dag";
                gagnagrunnur.SetjaSkilaboðÍGrunn(skilaboð);
            }
            else if (btSkráIFrí.Text == "Skrá úr fríi")
            {
                btSkráIFrí.Text = "Skrá í frí";
                gagnagrunnur.FaraÚrFríi(Notandi);
            }
        }
        /*
         ====================================== 
                     btSkráSemMættur_Click:
         Notandi verður skráður sem 'mættur'
         ef ýtt er á þennan takka
         ======================================
        */
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
        /*
         ====================================== 
                     LoginStarfsmenn_Load:
         Þegar LoginStarfsmenn load-ar þá heilsar
         forritið þann notanda sem loggaði sig inn
         ======================================
        */
        private void LoginStarfsmenn_Load(object sender, EventArgs e)
        {
            labelVelkominn.Text = "Velkomin/n " + Notandi;
            labelMotd.Text = "Motd:\n" + gagnagrunnur.Motd2();
        }
    }
}
