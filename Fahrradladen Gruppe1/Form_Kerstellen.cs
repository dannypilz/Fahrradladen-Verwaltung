using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Fahrradladen_Gruppe1
{
    
    public partial class Form_Kerstellen : Form
    {     
        //Datenbankverbindung herstellen
        DBVerbindung db = new DBVerbindung(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
        public MySqlConnection connection = new MySqlConnection(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");

        public Form_Kerstellen()
        {
            InitializeComponent();
        }

        //Die folgenden Befehle dienen dazu, dass man die Form verschieben kann
        Point Startpunkt;

        void Form_Index_MouseAction(object sender, MouseEventArgs e)
        {
            if (Startpunkt.IsEmpty)
            {
                Startpunkt = new Point(-e.Location.X - 8, -e.Location.Y - 30);
            }
            else
            {
                Startpunkt = Point.Empty;
            }
        }

        void Form_Index_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Startpunkt.IsEmpty)
            {
                Point Endpunkt = this.PointToScreen(e.Location);
                this.Location = new Point(Startpunkt.X + Endpunkt.X,
                                          Startpunkt.Y + Endpunkt.Y);
            }
        }

        //X und - müssen extra programmiert werden um das Design zu verfeinern
        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Einfügen der MouseHover um die Anwendung des Programms zu vereinfachen
        private void lbl_close_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(lbl_close, "Schließen");
        }

        private void lbl_min_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(lbl_min, "Minimieren");
        }

        private void pb_Kspeichern_MouseHover(object sender, EventArgs e)
        {
            ToolTip ts = new ToolTip();
            ts.SetToolTip(this.pb_Kspeichern, "Kunde speichern");
        }

        //Die Textboxen werden jedesmal bei einem neuen Aufruf geleert. Außerdem soll in der tb_KundenID immer eine
        //neue KundenID angezeigt werden. Dies haben wir dadurch gelöst, dass man auf die bestehende höchste KundenID immer 
        //eine Einheit hinzurechnet
        private void Kundenerfassung_Load(object sender, EventArgs e)
        {
            //Hier wird die Form bewegbar gemacht
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            tb_Name.Text = "" ;
            tb_Vorname.Text = "";
            tb_Email.Text = "";
            tb_GebDatum.Text = "";
            tb_strasse.Text = "";
            tb_ort.Text = "";
            tb_nr.Text = "";
            tb_haendler.Text = "";
            tb_firma.Text = "";
            tb_passwort.Text = "";
            tb_plz.Text = "";

            try
            {
                int zahl = db.select_höchster_int("SELECT max(KundenID) FROM Kunden");
                tb_KundenID.Text = Convert.ToString(zahl + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Quelle: https://social.msdn.microsoft.com/Forums/de-DE/677eccd2-54f1-40b7-b23e-606d94ef6552/mysql-c-datenabfrage?forum=vsexpressde
        }

        //Sobald man auf die Picturebox Speichern geht, soll der angelegte Kunde in der Datenbank unter der Tabelle
        //Kunden angelegt werden. Außerdem sollen die Textboxen wieder geleert werden
        private void pb_Kspeichern_Click(object sender, EventArgs e)
        {
             db.insert_update("insert into Kunden(Nachname,Name,Geburtsdatum,EMail,PLZ,Ort,Strasse,Hausnummer,Haendler,Firma,Passwort) value('" + tb_Name.Text + "','" + tb_Vorname.Text + "','" + tb_GebDatum.Text + "','" + tb_Email.Text + "','" + tb_plz.Text + "','" + tb_ort.Text + "','" + tb_strasse.Text + "','" + tb_nr.Text + "','" + tb_haendler.Text + "','" + tb_firma.Text + "','" + tb_passwort.Text + "')");
        
            MessageBox.Show("Kunde wurde erstellt.");
            Kundenerfassung_Load(sender, e);
        }
    }
}
