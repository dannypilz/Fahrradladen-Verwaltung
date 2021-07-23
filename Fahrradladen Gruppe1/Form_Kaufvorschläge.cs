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
    public partial class Form_Kaufvorschläge : Form
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

        public Form_Kaufvorschläge()
        {
            InitializeComponent();
        }

        //Hier werden die Labels für X und - programmiert
        private void lbl_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Form_kaufvorschläge_Load(object sender, EventArgs e)
        {
            //Die folgenden drei Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);
            //zum anzeigen aller bisherigen Konfigurationen
            try
            {                
                dt = db.select_datatable("select * from konfigurationen");
                dgv_konfig.DataSource = dt;
                dgv_konfig.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_konfig.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        //um Details zu einer Konfiguration anzeigen zu lassen
        private void dgv_konfig_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_konfig.SelectedRows[0];
            dgv_konfigdetails.ClearSelection();
            try
            {
                string konfid = Convert.ToString(row.Cells[0].Value);
                
                dt = db.select_datatable("select k.KonfigurationID, k.Position, k.ProduktID, p.Bezeichnung from Konfigurationenpos k join produkte p on k.ProduktID = p.ProduktID where KonfigurationID = " + konfid);
                dgv_konfigdetails.DataSource = dt;
                dgv_konfigdetails.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
