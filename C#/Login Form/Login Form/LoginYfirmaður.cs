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
    public partial class LoginYfirmaður : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public LoginYfirmaður()
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

        
    }
}
