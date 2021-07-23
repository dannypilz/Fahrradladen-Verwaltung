using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrradladen_Gruppe1
{
    public partial class Form_Konfigerstellen : Form
    {
        DBVerbindung db = new DBVerbindung("Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
        DataTable dt = new DataTable();
        Konfiguration kon = new Konfiguration();

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

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
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

        public Form_Konfigerstellen()
        {
            InitializeComponent();
        }

        private void Form_Konfigerstellen_Load(object sender, EventArgs e)
        {
            //Die folgenden drei Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);
            //zum anzeigen aller Produkte und anzeigen der neuen KonfigurationsID
            try
            {
                int zahl = db.select_höchster_int("SELECT max(KonfigurationID) FROM konfigurationen");
                tb_konfigid.Text = Convert.ToString(zahl + 1);
                dt = db.select_datatable("select * from produkte");
                dgv_produkte.DataSource = dt;
                dgv_produkte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_produkte.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb_konfigname.Text = "";
            tb_kundenid.Text = "";
        }

        //zum hinzufügen eines Produktes
        private void btn_hinzufügen_Click(object sender, EventArgs e)
        {       
            DataGridViewRow row = dgv_produkte.SelectedRows[0];
            dgv_konfigprodukte.ClearSelection();
            string Bezeichnung;
            
            try
            {
                Bezeichnung = db.select_string("select Bezeichnung from produktkategorie where KategorieID = '" + Convert.ToString(row.Cells[2].Value) + "'");
                Produkt P = new Produkt(Convert.ToInt32(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToDouble(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), Bezeichnung);
                kon.AddProduct(P);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv_konfigprodukte.DataSource = kon.umwandelnTabelle();
            dgv_konfigprodukte.ForeColor = Color.Black;
        }

        //zum speichern einer Konfiguration und abschicken an die DB wenn sie nicht gegen das Regelwerk verstößt
        private void btn_speichern_Click(object sender, EventArgs e)
        {
            if (kon.RegelCheck())
            {
                db.insert_update("insert into konfigurationen(Bezeichnung, KundenID) values('" + tb_konfigname.Text + "', " + tb_kundenid.Text + ")");
                for (int j = 0; j < kon.Liste_Produkt.Count; j++)
                {
                    db.insert_update("insert into konfigurationenpos(KonfigurationID, Position, ProduktID) values(" + tb_konfigid.Text + ", " + Convert.ToString(j + 1) + ", " + Convert.ToString(kon.Liste_Produkt[j].ProduktID) + ")");
                }
                Form_Konfigerstellen_Load(sender, e);
                MessageBox.Show("Konfiguration erstellt.");
            }
            else
            {
                MessageBox.Show("Bauteile passen nicht zusammen.");
            }            
        }

        //zum entfernen eines bereits geisteten Produktes
        private void btn_entfernen_Click(object sender, EventArgs e)
        {            
            DataGridViewRow row = dgv_produkte.SelectedRows[0];
            dgv_konfigprodukte.ClearSelection();
            string Bezeichnung;
            try
            {
                Bezeichnung = db.select_string("select Bezeichnung from produktkategorie where KategorieID = '" + Convert.ToString(row.Cells[2].Value) + "'");
                Produkt P = new Produkt(Convert.ToInt32(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToDouble(row.Cells[3].Value), Convert.ToInt32(row.Cells[2].Value), Bezeichnung);
                kon.DeleteProduct(P);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgv_konfigprodukte.DataSource = kon.umwandelnTabelle();
            dgv_konfigprodukte.ForeColor = Color.Black;
        }
    }
}
