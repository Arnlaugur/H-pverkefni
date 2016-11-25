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
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public LoginStarfsmenn()
        {
            InitializeComponent();
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
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
            labelVelkominn.Text = "Velkominn " + "";
        }
    }
}
