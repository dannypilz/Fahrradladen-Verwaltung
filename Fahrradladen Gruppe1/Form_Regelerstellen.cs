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
    public partial class Form_Regelerstellen : Form
    {
        //Datenbankverbindung herstellen
        DBVerbindung db = new DBVerbindung(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
        DataTable dt = new DataTable();

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

        public Form_Regelerstellen()
        {
            InitializeComponent();
        }

        //Hier werden die Labels für X und - programmiert
        private void lbl_close_Click_1(object sender, EventArgs e)
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
        
        private void Form_Regelerstellen_Load(object sender, EventArgs e)
        {
            //Die folgenden drei Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);
            //anzeigen aller Produkte zur erleichterten Bedienung
            try
            {
                dt = db.select_datatable("select ProduktID, Bezeichnung from produkte");
                dgv_produkte.DataSource = dt;
                dgv_produkte.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //anzeigen aller bisherigen Regeln
            try
            {
                dt = db.select_datatable("select * from regelwerk");
                dgv_regel.DataSource = dt;
                dgv_regel.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb_teila.Text = "";
            tb_teilb.Text = "";
        }

        //zum abschicken der neuen Regel an die DB
        private void btn_erstellen_Click(object sender, EventArgs e)
        {
            db.insert_update("insert into regelwerk values (" + tb_teila.Text  + "," + tb_teilb.Text + ")");
            MessageBox.Show("Regel wurde erstellt.");
        }
    }
}
