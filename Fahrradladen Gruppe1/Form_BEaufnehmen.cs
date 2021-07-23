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
    public partial class Form_BEaufnehmen : Form
    {        
        //Datenbankverbindung herstellen
        DBVerbindung db = new DBVerbindung(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");       
        DataTable dt = new DataTable();
        WarenkorbBestellung WK = new WarenkorbBestellung();

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

        public Form_BEaufnehmen()
        {
            InitializeComponent();
        }

        //Hier werden die Labels für X und - programmiert
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

        //Beim Laden der Form soll im Textfeld tb_BestellID eine neue ID angelegt werden, die eine Zahl höher ist als die bisherige
        //höchste. Die Daten soll sich das Programm aus der Tabelle Bestellungen herausziehen.
        private void Bestellung_aufnehmen_Load(object sender, EventArgs e)
        {
            //Die folgenden drei Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            WK = new WarenkorbBestellung();
            try
            {
                int zahl = db.select_höchster_int("SELECT max(BestellungID) FROM bestellung");
                tb_BestellID.Text = Convert.ToString(zahl + 1);
                dt = db.select_datatable("select * from produkte");
                dgv_AlleProdukte.DataSource = dt;
                dgv_AlleProdukte.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb_GP.Text = "0";
            tb_KundenID.Text = "";
        }

        //Beim Klicken auf den Button Hinzufügen sollen die im dgv_AlleProdukte ausgewählten Produkte in den dgv_Warenkorb 
        //übernommen werden. Hierbei werden die Zeilen des dgv_AlleProdukte durch den Befehl row.Cells[].Value ausgelesen.
        private void btn_hinzufügen_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgv_AlleProdukte.SelectedRows[0];
            dgv_Warenkorb.ClearSelection();
            string Bezeichnung;
            try
            {
                Bezeichnung = db.select_string("select Bezeichnung from produktkategorie where KategorieID = '" + Convert.ToString(row.Cells[2].Value) + "'");
                Produkt P = new Produkt(Convert.ToInt32(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToDouble(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), Bezeichnung);
                WK.AddProduct(P);
                tb_GP.Text = Convert.ToString(WK.Gesammtwert);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv_Warenkorb.DataSource = WK.umwandelnTabelle();
            dgv_Warenkorb.ForeColor = Color.Black;
        }

        //Sobald der Button Bestellung aufgeben geklickt wurde soll die Bestellung in der Tabelle Bestellung hinzugefügt
        //werden. Diese ist abhängig von der jeweiligen KundenID.
        private void btn_BEaufgeben_Click(object sender, EventArgs e)
        {
            string Datum = DateTime.Now.ToString("yyyy-MM-dd");
            db.insert_update("insert into bestellung (KundenID, Datum) values (" + tb_KundenID.Text + ", '" + Datum + "')");        
            for (int j = 0; j < WK.Liste_Produkt.Count; j++)
              {
                  db.insert_update("insert into bestellungpos (BestellungID, Position, ProduktID, Menge) values (" + tb_BestellID.Text + "," + Convert.ToString(j + 1) + "," + Convert.ToString(WK.Liste_Produkt[j].ProduktID) + "," + Convert.ToString(WK.Liste_Menge[j]) + ")");
              }
            db.insert_update("update bestellungpos as bp set bp.Preis = (select p.Preis from produkte as p where p.ProduktID = bp.ProduktID) where bp.BestellungID > 0; ");
            db.insert_update("update bestellungpos set Summe = Menge * Preis where BestellungID > 0; ");
            db.insert_update("update bestellung as b set b.Bestellsumme = (select round(sum(bp.Summe), 2) from bestellungpos as bp where b.BestellungID = bp.BestellungID) where b.BestellungID > 0; ");
            Bestellung_aufnehmen_Load(sender, e);
            MessageBox.Show("Bestellung verschickt.");
        }

        //zum entfernen von bereits im Warenkorb befindenden Artikeln
        private void btn_entfernen_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_AlleProdukte.SelectedRows[0];
            dgv_Warenkorb.ClearSelection();
            string Bezeichnung;
            try
            {
                Bezeichnung = db.select_string("select Bezeichnung from produktkategorie where KategorieID = '" + Convert.ToString(row.Cells[2].Value) + "'");
                Produkt P = new Produkt(Convert.ToInt32(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToDouble(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), Bezeichnung);
                WK.DeleteProduct(P);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv_Warenkorb.DataSource = WK.umwandelnTabelle();
            dgv_Warenkorb.ForeColor = Color.Black;
        }

        //zum anzeigen von Vorschlägen
        private void btn_vorschläge_Click(object sender, EventArgs e)
        {
            Form_Kaufvorschläge fv = new Form_Kaufvorschläge();
            fv.Show();
        }
    }
}
