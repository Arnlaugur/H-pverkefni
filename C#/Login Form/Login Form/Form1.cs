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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string Notendanafn = tb_Notendanafn.Text;
            string PasswordA = tb_Password.Text;
            string PasswordB = Encryption(PasswordA);
            
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
