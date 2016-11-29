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
    public partial class LoginYfirmaður : Form
    {
        string nafn = null;
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public LoginYfirmaður(string xnafn)
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
        private void btSýnaAlla_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Nafn", 100);
            listView1.Columns.Add("Sími", 65);
            listView1.Columns.Add("Email", 130);
            listView1.Columns.Add("Mættur", 50);
            listView1.Columns.Add("Veikur", 50);
            listView1.Columns.Add("Hlutverk", 85);
            listView1.Columns.Add("Notendanafn", 100);
            listView1.Columns.Add("Frí", 30);
            List<string> linur = new List<string>();
            string[] arr = new string[8];
            ListViewItem itm;
            try
            {
                linur = gagnagrunnur.SynaAlla();
                foreach (var lin in linur)
                {
                    string[] linaUrLista = lin.Split('-');
                    string Nafn = linaUrLista[0];
                    string Sími = linaUrLista[1];
                    string Email = linaUrLista[2];
                    string Mættur = linaUrLista[3];
                    string Veikur = linaUrLista[4];
                    string Hlutverk = linaUrLista[5];
                    string Notendanafn = linaUrLista[6];
                    string Frí = linaUrLista[7];

                    arr[0] = Nafn;
                    arr[1] = Sími;
                    arr[2] = Email;
                    arr[3] = Mættur;
                    arr[4] = Veikur;
                    arr[5] = Hlutverk;
                    arr[6] = Notendanafn;
                    arr[7] = Frí;

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("villa: " + ex);
            }
        }

        private void btSýnaYfirmenn_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Nafn", 100);
            listView1.Columns.Add("Sími", 65);
            listView1.Columns.Add("Email", 130);
            listView1.Columns.Add("Mættur", 50);
            listView1.Columns.Add("Veikur", 50);
            listView1.Columns.Add("Hlutverk", 85);
            listView1.Columns.Add("Notendanafn", 100);
            listView1.Columns.Add("Frí", 30);
            List<string> linur = new List<string>();
            string[] arr = new string[8];
            ListViewItem itm;
            try
            {
                linur = gagnagrunnur.SynaYfirmenn();
                foreach (var lin in linur)
                {
                    string[] linaUrLista = lin.Split('-');
                    string Nafn = linaUrLista[0];
                    string Sími = linaUrLista[1];
                    string Email = linaUrLista[2];
                    string Mættur = linaUrLista[3];
                    string Veikur = linaUrLista[4];
                    string Hlutverk = linaUrLista[5];
                    string Notendanafn = linaUrLista[6];
                    string Frí = linaUrLista[7];

                    arr[0] = Nafn;
                    arr[1] = Sími;
                    arr[2] = Email;
                    arr[3] = Mættur;
                    arr[4] = Veikur;
                    arr[5] = Hlutverk;
                    arr[6] = Notendanafn;
                    arr[7] = Frí;

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("villa: " + ex);
            }
        }
        private void bt_Ráða_Click(object sender, EventArgs e)
        {
            RadaStarfsmann Raða = new RadaStarfsmann();
            Raða.Show();
        }

        private void btSýnaStarfsmenn_Click(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("Nafn", 100);
            listView1.Columns.Add("Sími", 65);
            listView1.Columns.Add("Email", 130);
            listView1.Columns.Add("Mættur", 50);
            listView1.Columns.Add("Veikur", 50);
            listView1.Columns.Add("Hlutverk", 85);
            listView1.Columns.Add("Notendanafn", 100);
            listView1.Columns.Add("Frí", 30);
            List<string> linur = new List<string>();
            string[] arr = new string[8];
            ListViewItem itm;
            try
            {
                linur = gagnagrunnur.SynaStarfsmenn();
                foreach (var lin in linur)
                {
                    string[] linaUrLista = lin.Split('-');
                    string Nafn = linaUrLista[0];
                    string Sími = linaUrLista[1];
                    string Email = linaUrLista[2];
                    string Mættur = linaUrLista[3];
                    string Veikur = linaUrLista[4];
                    string Hlutverk = linaUrLista[5];
                    string Notendanafn = linaUrLista[6];
                    string Frí = linaUrLista[7];

                    arr[0] = Nafn;
                    arr[1] = Sími;
                    arr[2] = Email;
                    arr[3] = Mættur;
                    arr[4] = Veikur;
                    arr[5] = Hlutverk;
                    arr[6] = Notendanafn;
                    arr[7] = Frí;

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("villa: " + ex);
            }
        }

        private void btRekaStarfsmann_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string nafnNotenda = tbRekaNafn.Text;
            string emailNotenda = tbRekaEmail.Text;
            try
            {
                gagnagrunnur.Eyda(nafnNotenda, emailNotenda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            tbRekaNafn.Clear();
            tbRekaEmail.Clear();
        }

        private void btSendaIFrí_Click(object sender, EventArgs e)
        {

        }

        private void btMotd_Click(object sender, EventArgs e)
        {
            string motd = tbMotd.Text;
            gagnagrunnur.Motd(motd);
            MessageBox.Show("==============\nMessage of the day:\n==============\n" + motd);
            tbMotd.Clear();
        }

        private void LoginYfirmaður_Load(object sender, EventArgs e)
        {
            labelNafn.Text = "Velkomin/n " + nafn;
        }


        private void btSkráMættur_Click(object sender, EventArgs e)
        {
            if (btSkráMættur.Text == "Skrá sem mættur")
            {
                btSkráMættur.Text = "Útskrá";
                gagnagrunnur.Innskra(nafn);
            }
            else if (btSkráMættur.Text == "Útskrá")
            {
                btSkráMættur.Text = "Skrá sem mættur";
                gagnagrunnur.Utskra(nafn);
            }
        }

        private void btSkráVeikur_Click(object sender, EventArgs e)
        {
            if (btSkráVeikur.Text == "Skrá sem veikur")
            {
                btSkráVeikur.Text = "Skrá úr veikindum";
                gagnagrunnur.Veikur(nafn);
            }
            else if (btSkráVeikur.Text == "Skrá úr veikindum")
            {
                btSkráVeikur.Text = "Skrá sem veikur";
                gagnagrunnur.EkkiVeikur(nafn);
            }
        }

        private void btFaraÍFrí_Click(object sender, EventArgs e)
        {
            if (btFaraÍFrí.Text == "Fara í frí")
            {
                btFaraÍFrí.Text = "Skrá úr fríi";
                gagnagrunnur.FaraÍFrí(nafn);
            }
            else if (btFaraÍFrí.Text == "Skrá úr fríi")
            {
                btFaraÍFrí.Text = "Fara í frí";
                gagnagrunnur.FaraÚrFríi(nafn);
            }
        }
        private void bt_Skilaboð_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            

=======
            Skilaboð Skilaboð = new Skilaboð();
            Skilaboð.Show();
>>>>>>> d689788b4f7a33b4b5792442ec36cb04c2a6e2af
        }

        
    }
}
