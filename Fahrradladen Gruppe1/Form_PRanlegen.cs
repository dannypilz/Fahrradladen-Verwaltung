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
    public partial class Produkt_anlegen : Form
    {
        //Datenbankverbindung herstellen
        DBVerbindung db = new DBVerbindung(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
        //public MySqlConnection connection = new MySqlConnection(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");

        public Produkt_anlegen()
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

        private void pb_PRspeichern_MouseHover(object sender, EventArgs e)
        {
            ToolTip ts = new ToolTip();
            ts.SetToolTip(this.pb_PRspeichern, "Produkt speichern");

        }

        //Beim Laden der Form sollen jedesmal die Textboxen wieder geleert werden. Außerdem soll die Nummer fortlaufend
        //weitergehen
        private void Produkt_anlegen_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            tb_produktid.Text = "";
            tb_bezeichnung.Text = "";
            tb_produktkategorie.Text = "";
            tb_preis.Text = "";
            tb_lagerbestand.Text = "";

            try
            {
                int zahl = db.select_höchster_int("SELECT max(ProduktID) FROM produkte");
                tb_produktid.Text = Convert.ToString(zahl + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Sobald man auf die Picturebox Speichern klickt soll das neu angelegte Produkt in der Datenbank
        //unter der Tabelle Produkte ergänzt werden
        private void pb_PRspeichern_Click(object sender, EventArgs e)
        {
            {
                db.insert_update("insert into produkte(ProduktID, Bezeichnung, Produktkategorie, Preis, Lagerbestand) value('" + tb_produktid.Text + "','" + tb_bezeichnung.Text + "','" + tb_produktkategorie.Text + "','" + tb_preis.Text + "','" + tb_lagerbestand.Text + "')");
                MessageBox.Show("Produkt wurde angelegt");
                Produkt_anlegen_Load(sender, e);
            }
        }        
                
        //Sobald man mit der Maus die Textbox tb_produktkategorie betritt, soll ein ToolTip helfen, welche Nummer
        //zu welcher Kategorie gehört. Durch die VisibleTime lässt sich die Anzeigedauer in Millisekunden bestimmen.
        private void tb_produktkategorie_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 10000;

            ToolTip tk = new ToolTip();
            string ausgabe = "Bitte verwenden Sie die folgenden Zahlen für die Produktkategorie:"
                + Environment.NewLine + "1 = Rahmen"
                + Environment.NewLine + "2 = Lenker"
                + Environment.NewLine + "3 = Federung"
                + Environment.NewLine + "4 = Sattel"
                + Environment.NewLine + "5 = Schaltung"
                + Environment.NewLine + "6 = Rad"
                + Environment.NewLine + "7 = Reifen"
                + Environment.NewLine + "8 = Klingel"
                + Environment.NewLine + "9 = Licht"
                + Environment.NewLine + "10 = Griff";
            tk.Show(ausgabe, TB,219,0, VisibleTime);
        }
    }
}

