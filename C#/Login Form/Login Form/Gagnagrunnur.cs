using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Login_Form
{
    class Gagnagrunnur
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        string tengistrengur = null;
        string fyrirspurn = null;

        MySqlConnection sqltenging;
        MySqlCommand nySQLskipun;
        MySqlDataReader sqllesari = null;

        public void TengingVidGagnagrunn()
        {
            server = "10.200.10.24";
            database = "3001992329_Starfsmenn";
            uid = "3001992329";
            password = "mypassword";
            tengistrengur = "Server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }
        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }
        /*
         ====================================== 
                     LoginCheck():
         Notað: --> Form1.cs <--
         Upplýsingar: Athugar hvort notendanafnið
         sé rétt
         ======================================
        */
        public List<string> LoginCheck(string Notendanafn)
        {
            List<string> Faerslur = new List<string>();
            string lina = null;          
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT hlutverk, notendanafn, password FROM Starfsmenn WHERE notendanafn = '"+ Notendanafn +"'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + "-";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        /*
         ====================================== 
                     SynaYfirmenn():
         Notað: --> LoginYfirmaður.cs <--
         Upplýsingar: Sýnir alla yfirmenn með því
         að select-a allt úr töflunni 'starfsmenn'
         þar sem Hlutverk = 'Yfirmaður'
         ======================================
        */
        public List<string> SynaYfirmenn()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Nafn, Sími, Email, Mættur, Veikur, Hlutverk, Notendanafn, Frí FROM starfsmenn WHERE Hlutverk = 'Yfirmaður'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + "-";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        /*
         ====================================== 
                     SynaAlla():
         Notað: --> LoginYfirmaður.cs <--
         Upplýsingar: Select-ar allt úr töflunni
         'starfsmenn'
         ======================================
        */
        public List<string> SynaAlla()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Nafn, Sími, Email, Mættur, Veikur, Hlutverk, Notendanafn, Frí FROM starfsmenn";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + "-";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        /*
         ====================================== 
                     SettInnSqlToflu():
         Notað: --> RadaStarfsmann.cs <--
         Upplýsingar: Bættir nýjum gögnum við 
         töfluna 'starfsmaður'
         ======================================
        */
        public void SettInnSqlToflu(string nafn, string sími, string email, string hlutverk, string notendanafn) //Aðferð til að setja í grunn
        {
            if (OpenConnection() == true)
            {
                int mættur = 0;
                int veikur = 0;
                int frí = 0;
                fyrirspurn = "INSERT INTO Starfsmenn (nafn, sími, email, mættur, veikur, hlutverk, notendanafn, frí) VALUES ('" + nafn + "','" + sími + "','" + email + "','" + mættur + "','" + veikur + "','" + hlutverk + "','" + notendanafn + "','" + frí +"');";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                     SynaStarfsmenn():
         Notað: --> LoginYfirmaður.cs <--
         Upplýsingar: Sýnir alla starfsmenn með því
         að select-a allt úr töflunni 'starfsmenn'
         þar sem Hlutverk = 'Starfsmaður'
         ======================================
        */
        public List<string> SynaStarfsmenn()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Nafn, Sími, Email, Mættur, Veikur, Hlutverk, Notendanafn, Frí FROM starfsmenn WHERE Hlutverk = 'Starfsmaður'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + "-";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        /*
         ====================================== 
                     NafnaCheck():
         Notað: --> Form1.cs <--
         Upplýsingar: Athugar hvort að notendanafnið 
         og email-ið sé rétt þegar notendur eru 
         að stofna nýjan aðgang
         ======================================
        */
        public string NafnaCheck(string Notendanafn)
        {
            string Faerslur = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT email FROM Starfsmenn WHERE notendanafn = '" + Notendanafn + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    Faerslur = sqllesari.GetValue(0).ToString();
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        /*
         ====================================== 
                PasswordSettInnSqlToflu():
         Notað: --> Form1.cs <--
         Upplýsingar: Settur inn nýja password-ið
         hjá nýjum notendum í gagnagrunninn(sem 
         er auðvitað encryptaður)
         ======================================
        */
        public void PasswordSettInnSqlToflu(string password, string Notendanafn) //Aðferð til að setja í grunn
        {          
            if (OpenConnection() == true)
            {            
                fyrirspurn = "UPDATE Starfsmenn SET password = '" + password + "' WHERE notendanafn = '" + Notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                        Eyda():
         Notað: --> LoginYfirmaður.cs <--
         Upplýsingar: Yfirmaður getur rekið/eytt
         fólki út úr gagnagrunninum
         ======================================
        */
        public void Eyda(string nafn, string email)
        {           
            if (OpenConnection() == true)
            {
                fyrirspurn = "Delete FROM starfsmenn where Notendanafn='" + nafn + "'" + " AND Email='" + email + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                       Motd():
         Notað: --> LoginYfirmaður.cs <--
         Upplýsingar: Leyfir yfirmenn að skrifa 
         nýtt motd(Message of the Day)
         ======================================
        */
        public void Motd(string texti) 
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE motd SET motd = '" + texti + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                       Motd2():
         Notað: --> LoginStarfsmenn.cs <--
         Upplýsingar: Select-ar textan úr töflunni
         'motd' þannig starfsmenn geta séð
         (Message of the Day)
         ======================================
        */
        public string Motd2()
        {
            string Faerslur = null;

            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT motd FROM motd";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    Faerslur = sqllesari.GetValue(0).ToString();
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        /*
         ====================================== 
                     Innskra():
         Notað: --> LoginYfirmaður.cs og LoginStarfsmenn.cs <--
         Upplýsingar: Update-ar gagnagrunninn þannig 
         að starfsmaður eða yfirmaður sé mættur
         ======================================
        */
        public void Innskra(string notendanafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Starfsmenn SET Mættur = 1 AND Veikur = 0 AND Frí = 0 WHERE notendanafn = '" + notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                     Utskra():
         Notað: --> LoginYfirmaður.cs og LoginStarfsmenn.cs <--
         Upplýsingar: Skráir fólk úr gangagrunninum
         þannig þau er ekki mætt/búin að vinna
         ======================================
        */
        public void Utskra(string notendanafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Starfsmenn SET Mættur = 0 WHERE notendanafn = '" + notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                     mæting():
         Notað: --> LoginStarfsmenn.cs <--
         Upplýsingar: Athugar hvort að maður sé
         mættur
         ======================================
        */
        public string mæting(string notandanafn)
        {
            string geymsla = "3";
            int tala = 3;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Mættur FROM Starfsmenn WHERE notendanafn = '"+ notandanafn +"';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    tala = sqllesari.GetInt32(0);
                }
                geymsla = tala.ToString();
                CloseConnection();
                return geymsla;
            }
            return geymsla;
        }
        /*
         ====================================== 
                     Veikur():
         Notað: --> LoginYfirmaður.cs og LoginStarfsmenn.cs <--
         Upplýsingar: Update-ar gagnagrunninn þannig 
         að starfsmaður eða yfirmaður sé veikur
         (ath. að ekki er hægt að skrá sig veikan
         ef maður er í fríi eða mættur)
         ======================================
        */
        public void Veikur(string notendanafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Starfsmenn SET Veikur = 1 AND Mættur = 0 AND Frí = 0 WHERE notendanafn = '" + notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                     EkkiVeikur():
         Notað: --> LoginYfirmaður.cs og LoginStarfsmenn.cs <--
         Upplýsingar: Update-ar gagnagrunninn
         þannig notendur eru ekki lengur veikt
         ======================================
        */
        public void EkkiVeikur(string notendanafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Starfsmenn SET Veikur = 0 WHERE notendanafn = '" + notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                     FaraÍFrí():
         Notað: --> LoginYfirmaður.cs og LoginStarfsmenn.cs <--
         Upplýsingar: Update-ar gagnagrunninn þannig 
         að starfsmaður eða yfirmaður sé settir
         í frí(ath. að starfsmenn verða senda 
         yfirmanni skilaboð ef þeir vilja komast
         í frí)
         ======================================
        */
        public void FaraÍFrí(string notendanafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Starfsmenn SET Frí = 1 AND Mættur = 0 AND Veikur = 0 WHERE notendanafn = '" + notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         ====================================== 
                     FaraÚrFríi():
         Notað: --> LoginYfirmaður.cs og LoginStarfsmenn.cs <--
         Upplýsingar: Update-ar gagnagrunninn
         þannig notendur eru ekki lengur í fríi
         ======================================
        */
        public void FaraÚrFríi(string notendanafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Starfsmenn SET Frí = 0 WHERE notendanafn = '" + notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void SetjaSkilaboðÍGrunn(string skilaboð)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "INSERT INTO Skilaboð (skilaboð) VALUES ('"+skilaboð+"')";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public List<string> NáÍSkilaboð()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;

            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT skilaboð FROM skilaboð";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + "-";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        public void EyðaSkilaboði(string Notendanafn)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "DELETE skilaboð FROM skilaboð WHERE skilaboð LIKE '" + Notendanafn + "%'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                CloseConnection();
            }
        }
    }
}
