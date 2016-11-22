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
            List<string> linur = new List<string>();

            string[] arr = new string[2];

            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.LoginCheck();
                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split('-');
                    string NotendanafnB = linaUrLista[0];
                    string PasswordC = linaUrLista[1];
                    

                    arr[0] = NotendanafnB;
                    arr[1] = PasswordC;
                    if (arr[1] == PasswordA)
                    {
                        LoginStarfsmenn login = new LoginStarfsmenn();
                        login.Show();
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
