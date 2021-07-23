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
    public partial class Form_LBbuchen : Form
    {
        //Datenbankverbindung aufbauen
        DBVerbindung db = new DBVerbindung(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
        MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
        DataTable dt = new DataTable();
        DataTable datatb = new DataTable();

        public Form_LBbuchen()
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


        private void Lagerbeständebuchen_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            try
            {
                dt = db.select_datatable("select * from produkte");
                dgv_produkte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_produkte.DataSource = dt;
                dgv_produkte.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataGridViewRow row = dgv_produkte.SelectedRows[0];
            tb_aktuellemenge.Text = Convert.ToString(row.Cells[4].Value);
        }

        //zum abrufen der aktuellen Menge
        private void dg_produkte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_aktuellemenge.Text = Convert.ToString(dgv_produkte.SelectedRows[0].Cells[4].Value);
        }

        //zum hinzufügen einer gewissen Menge vom Lagerbestand und ändern in der DB
        private void btn_hinzufügen_Click(object sender, EventArgs e)
        {
            string hinzufügen = tb_menge.Text;
            DataGridViewRow row = dgv_produkte.SelectedRows[0];
            int zahl;
            if (int.TryParse(hinzufügen, out zahl))
            {
                db.insert_update("update produkte set Lagerbestand = Lagerbestand + '" + hinzufügen + "' where ProduktID = '" + row.Cells[0].Value + "'");

                // in der ausgewählten zeile wird die höhe des Lagerbestandes erhöht um das was in der tb_menge steht
                rtb_Menge.Text += "Lagerbestand von Produkt " + row.Cells[0].Value + ". " + row.Cells[1].Value + " um " + Convert.ToInt32(hinzufügen) + " erhöht. " + Environment.NewLine;
                Lagerbeständebuchen_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Bitte eine Zahl eingeben.");
            }
        }

        //zum abziehen einer gewissen Menge vom Lagerbestand und ändern in der DB
        private void btn_abziehen_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_produkte.SelectedRows[0];
            int zahl;
            if (int.TryParse(tb_menge.Text, out zahl))
            {
                db.insert_update("update produkte set Lagerbestand = Lagerbestand - '" + tb_menge.Text + "' where ProduktID = '" + row.Cells[0].Value + "'");
                rtb_Menge.Text += ("Lagerbestand von Produkt " + row.Cells[0].Value + ". " + row.Cells[1].Value + " um " + Convert.ToInt32(tb_menge.Text) + " verringert. ") + Environment.NewLine;

                // in datenbank direkt nach schauen (select Lagerbestand from Produkte where Lagerbestand < 10)
                rtb_lb10.Text = "";
                int Count = db.count_einträge("select Count(*) from produkte where Lagerbestand < 10");
                rtb_lb10.Text = db.reader_string_builder2("select ProduktID,Bezeichnung, Lagerbestand from produkte where Lagerbestand < 10", "ProduktID", "Bezeichnung");
                if (Count >0)
                {
                    MessageBox.Show("Der Lagerbestand von " + Count + " Produkt/en  ist unter 10!");
                }
                Lagerbeständebuchen_Load(sender,e);
            }
            else
            {
                MessageBox.Show("Bitte eine Zahl eingeben.");
            }
        }

        //löschen des Textes in der Infobox
        private void btn_TextClear_Click(object sender, EventArgs e)
        {
            rtb_Menge.Text = "";
        }

        
    }
}
