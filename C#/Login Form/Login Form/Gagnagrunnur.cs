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
        public List<string> notandanöfn()
        {
            
                List<string> Faerslur = new List<string>();
                string lina = null;
                
                if (OpenConnection() == true)
                {
                    fyrirspurn = "SELECT Nafn FROM Starfsmenn";
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
        public void Innskra(string notendanafn)
        {

            if (OpenConnection() == true)
            {
                fyrirspurn = "UPDATE Starfsmenn SET Mættur = 1 AND Veikur = 0 WHERE notendanafn = '" + notendanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
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
        public string mæting(string notandanafn)
        {
            string tala = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Mættur FROM Starfsmenn WHERE notendanafn = '" + notandanafn + "';";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    tala = sqllesari.GetValue(0).ToString();
                }
                CloseConnection();
                return tala;
            }
            return tala;

        }
    }
}
