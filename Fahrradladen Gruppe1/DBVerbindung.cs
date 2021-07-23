using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;



namespace Fahrradladen_Gruppe1
{
    class DBVerbindung //Klasse für eine erleichterete Verbindung
    {
        private string connstr;

        //get set Methoden
        public string ConnStr
        {
            get
            {
                return connstr;
            }
            set
            {

                connstr = value;

            }
        }

        //Konstruktor
        public DBVerbindung(string str)
        {
            connstr = str;
        }

        //um eine Tabelle aus der DB zu ziehen
        public DataTable select_datatable(string str)
        {
           
            MySqlConnection con = null;

            con = new MySqlConnection(this.connstr);
            
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(str, con); 
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }

        //für SQL Befehle ohne Rückgabewert
        public void insert_update(string str)
        {
            MySqlConnection con = null;
            con = new MySqlConnection(this.connstr);
            try
            {
                
                con.Open();
                MySqlCommand insertCommand = new MySqlCommand( str , con);

                int i = insertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //Für den Abruf des höchsten Wertes einer Tabelle
        public int select_höchster_int(string str)
        {
            int h=0;
            MySqlConnection connection = null;
            connection = new MySqlConnection(this.connstr);
            connection.Open();
            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(str, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                h = Convert.ToInt32(reader[0]);
            }
            connection.Close();
            return h;
        }

        //zum auslesen eines Strigs aus der DB
        public string select_string(string str)
        {
            string h = "";
            MySqlConnection connection = null;
            connection = new MySqlConnection(this.connstr);
            connection.Open();
            MySqlDataReader reader = null;
            MySqlCommand cmd = new MySqlCommand(str, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                h = Convert.ToString(reader[0]);
            }
            connection.Close();
            return h;
        }

        //zum zählen der Einträge einer DB
        public int count_einträge(string str)
        {
            MySqlConnection connection = new MySqlConnection(this.connstr);
            connection.Open();
            MySqlCommand comm = new MySqlCommand(str, connection);
            int count = Convert.ToInt32(comm.ExecuteScalar());
            connection.Close();
            return count;
        }

        //zum bauen eine Strings aus 2 Spalten
        public string reader_string_builder2(string sqlstr, string a, string b)
        {
            MySqlConnection con = new MySqlConnection(this.connstr);
            con.Open();
            string astring="";
            MySqlCommand command = new MySqlCommand(sqlstr, con);
            MySqlDataReader sdr = command.ExecuteReader();

            while (sdr.Read())
            {
                astring += sdr[a].ToString() + " " + sdr[b].ToString() + Environment.NewLine;
            }
            con.Close();
            return astring;
        }

    }
}
