﻿using System;
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
    public partial class Skilaboð : Form
    {
        public Skilaboð()
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
            rtb_Skilaboð.Clear();
            List<string> linur = new List<string>();
            try
            {
                
                linur = gagnagrunnur.NáÍSkilaboð();
                foreach (string lin in linur)
                {
                string[] linaUrLista = lin.Split('-');
                string skilaboð = linaUrLista[0];
                
                rtb_Skilaboð.Text += skilaboð + "\n";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            //List<string>;
        }
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        private void bt_fri_Click(object sender, EventArgs e)
        {
            string Notandi = tb_nafn.Text;
            string email = tb_netfang.Text;
            string email2 = gagnagrunnur.NafnaCheck(Notandi);
            if (bt_fri.Text == "senda í frí" && email2 == email)
            {
                bt_fri.Text = "Srká úr fríi";
                gagnagrunnur.FaraÍFrí(Notandi);
            }
            else if (bt_fri.Text == "Skrá ír ´fríi")
            {
                gagnagrunnur.FaraÚrFríi(Notandi);
            }
        }
    }
}
