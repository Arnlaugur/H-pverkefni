using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public Form1()
        {
            
            
            InitializeComponent();
            tb_Password.PasswordChar = '*';
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string Notendanafn = tb_Notendanafn.Text;
            string PasswordA = tb_Password.Text;
            string PasswordB = Encryption(PasswordA);
            tb_Password.Text = PasswordB;
            List<string> linur = new List<string>();

            string[] arr = new string[3];

            ListViewItem itm;
            
            try
            {
                linur = gagnagrunnur.LoginCheck();
                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split('-');
                    string Hlutverk = linaUrLista[0];
                    string NotendanafnB = linaUrLista[1];
                    string PasswordC = linaUrLista[2];
                    
                    arr[0] = Hlutverk;
                    arr[1] = NotendanafnB;
                    arr[2] = PasswordC;
                    if (Hlutverk == "Starfsmaður")
                    {
                        if (arr[2] == PasswordB)
                        {
                            LoginStarfsmenn login = new LoginStarfsmenn();
                            login.Show();
                        }
                    }
                    else if (Hlutverk == "Yfirmaður")
                    {
                        if (arr[2] == PasswordB)
                        {
                            LoginYfirmaður login = new LoginYfirmaður();
                            login.Show();
                        }
                    }
                    

                    itm = new ListViewItem(arr);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        static string Encryption(string pass)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] Data = md5.ComputeHash(utf8.GetBytes(pass));
                return Convert.ToBase64String(Data);
            }
        }
    }
}
