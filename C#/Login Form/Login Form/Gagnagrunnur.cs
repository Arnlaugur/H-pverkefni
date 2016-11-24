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
                //CloseConnection();
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
                //CloseConnection();
            }

        }
    }
}
