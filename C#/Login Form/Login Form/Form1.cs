﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
//Hópverkefni 3.önn - Arnlaugur og Bjarki

namespace Login_Form
{
    
    public partial class Form1 : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        public Form1()
        {
            InitializeComponent();
            tb_Password.PasswordChar = '*';
            tb_Lykilorð1.PasswordChar = '*';
            tb_Lykilorð2.PasswordChar = '*';
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /*
         ====================================== 
                    bt_Login_Click:
         Athugar hvort að starfsmaður eða yfirmaður
         hafi loggað sér inn
         ======================================
        */
        private void bt_Login_Click(object sender, EventArgs e)
        {           
            string Notendanafn = tb_Notendanafn.Text;
            string PasswordA = tb_Password.Text;
            string PasswordB = Encryption(PasswordA);
            if (Notendanafn.Count() > 6)
            {
                MessageBox.Show("Notendanafn of langt");
            }
            tb_Password.Text = PasswordB;
            List<string> linur = new List<string>();        
            try
            {                
                linur = gagnagrunnur.LoginCheck(Notendanafn);                
                foreach (string lin in linur)
                {
                    string[] linaUrLista = lin.Split('-');
                    string Hlutverk = linaUrLista[0];
                    string NotendanafnB = linaUrLista[1];
                    string PasswordC = linaUrLista[2];
                    
                    if (Hlutverk == "Starfsmaður")
                    {
                        if (PasswordC == PasswordB)
                        {
                            LoginStarfsmenn login = new LoginStarfsmenn(Notendanafn);
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Lykilorð passar ekki, reyndu aftur");
                        }
                    }
                    else if (Hlutverk == "Yfirmaður")
                    {
                        if (PasswordC == PasswordB)
                        {
                            LoginYfirmaður login = new LoginYfirmaður(Notendanafn);
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Lykilorð passar ekki, reyndu aftur");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            tb_Notendanafn.Clear();
            tb_Password.Clear();
        }
        //Password Encryption Kóði:
        static string Encryption(string pass)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] Data = md5.ComputeHash(utf8.GetBytes(pass));
                return Convert.ToBase64String(Data);
            }
        }
        /*
         ====================================== 
                    bt_Virkja_Click:
         Virkjar password-in
         ======================================
        */
        private void bt_Virkja_Click(object sender, EventArgs e)
        {
            string Notendanafn = tb_NotendanafnVirkja.Text;
            string PasswordVirkjaA = tb_Lykilorð1.Text;
            string PasswordVirkjaB = tb_Lykilorð2.Text;
            string Email = tb_Email.Text;
            if (PasswordVirkjaA == PasswordVirkjaB)
            {
                if (Email == gagnagrunnur.NafnaCheck(Notendanafn))
                {
                    PasswordVirkjaA = Encryption(PasswordVirkjaA);
                    gagnagrunnur.PasswordSettInnSqlToflu(PasswordVirkjaA, Notendanafn);
                }
                else
                {
                    MessageBox.Show("Gögn passa ekki við notanda í gagnagrunn");
                }               
            }
            else
            {
                MessageBox.Show("Lykkilorð ekki alveg eins");
            }
        }        
    }
}
