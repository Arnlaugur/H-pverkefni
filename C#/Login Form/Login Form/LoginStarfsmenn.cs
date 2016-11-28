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
        string nafn = null;
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public LoginStarfsmenn(string xnafn, string xNotandi,string texti)
        {
            InitializeComponent();
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
                nafn = xnafn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btSkráSemVeikur_Click(object sender, EventArgs e)
        {

        }

        private void btSkráIFrí_Click(object sender, EventArgs e)
        {

        }

        private void btSkráSemMættur_Click(object sender, EventArgs e)
        {

        }

        private void LoginStarfsmenn_Load(object sender, EventArgs e)
        {
            labelVelkominn.Text = "Velkominn/Velkomin " + nafn;
        }
    }
}
