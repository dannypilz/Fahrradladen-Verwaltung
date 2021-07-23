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
    public partial class Form_MAerstellen : Form
    {
        //Datenbankverbindung herstellen
        DBVerbindung db = new DBVerbindung(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");

        public Form_MAerstellen()
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

        private void pb_MAspeichern_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(pb_MAspeichern,"Mitarbeiter speichern");
        }

        //Beim Laden der Form sollen die Textboxen immer wieder geleert werden, damit man nicht alles herauslöschen
        //muss. Außerdem soll auch die MitarbeiterID fortlaufend weitergehen, damit es nicht zu Dopplungen kommt.
        private void Form_MAerstellen_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            tb_name.Text = "";
            tb_vorname.Text = "";
            tb_email.Text = "";
            tb_gebdat.Text = "";
            tb_strasse.Text = "";
            tb_ort.Text = "";
            tb_nr.Text = "";
            tb_abteilung.Text = "";
            tb_plz.Text = "";

            try
            {
                int zahl = db.select_höchster_int("SELECT max(MAID) FROM mitarbeiter");
                tb_MAID.Text = Convert.ToString(zahl + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Sobald man auf das Speichern Symbol klickt soll ein neuer Mitarbeiter in der Datenbank erstellt werden
        private void pb_MAspeichern_Click(object sender, EventArgs e)
        {
            db.insert_update("insert into mitarbeiter(Name,Vorname,Geburtsdatum,EMail,PLZ,Ort,Strasse,Hausnummer,Abteilung) value('" + tb_name.Text + "','" + tb_vorname.Text + "','" + tb_gebdat.Text + "','" + tb_email.Text + "','" + tb_plz.Text + "','" + tb_ort.Text + "','" + tb_strasse.Text + "','" + tb_nr.Text + "','" + tb_abteilung.Text + "')");
            MessageBox.Show("Mitarbeiter wurde erstellt.");
            Form_MAerstellen_Load(sender, e);
        }              
    }
}
