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
    public partial class Form_Laden : Form
    {
        //Datenbankverbindung herstellen
        DataTable dt = new DataTable();
        DBVerbindung db = new DBVerbindung(@"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad; allow zero datetime = true;");

        public Form_Laden()
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
        private void pb_suchen_MouseHover(object sender, EventArgs e)
        {
            ToolTip ts = new ToolTip();
            ts.SetToolTip(this.pb_suchen, "Kunde suchen");
        }            

        private void pb_Kerstellen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_Kerstellen, "Kunde erstellen");
        }

        private void pb_delete_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_delete, "Kunde entfernen");
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

        private void pb_BEaufnehmen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_BEaufnehmen, "Bestellung aufnehmen");
        }

        //Beim Laden der Form soll im DataGridView der Gesamte Kundendatensatz angezeigt werden. Durch
        //die Textbox tb_suchen soll man nach einem bestimmten Nachnamen suchen, damit man sehen kann,
        //ob der Kunde bereits im System exisitert oder nicht. Diese Funktion könnte in der Praxis
        //sehr hilfreich sein, da es Kunden gibt, die nicht wissen ob Sie noch Kunde sind oder nicht.
        //Außerdem kann der Mitarbeiter daran die KundenID erkennen, welche er im nächsten Schritt
        //bei der Bestellung aufnehmen gebrauchen kann
        private void Form_laden_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            dgv_Kundenview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt = db.select_datatable("select * from Kunden");
            dgv_Kundenview.DataSource = dt;

        }

        //Beim Klicken auf die Picturebox Kunde erstellen soll die Form Kundenerstellen geöffnet werden
        private void pb_Kerstellen_Click(object sender, EventArgs e)
        {
            Form_Kerstellen ke = new Form_Kerstellen();
            ke.Show();            
        }

        //Sobald man auf die Picturebox Suchen klickt soll in der Datenbank nach dem Nachnamen des Kunden in der 
        //Tabelle Kunden gesucht werden und dementsprechend auch in dem dgv_Kundenview angezeigt werden.
        private void pb_suchen_Click(object sender, EventArgs e)
        {
            if (tb_suchen.Text != "")
            {
                string suchen = tb_suchen.Text;
                try
                {
                    dt = db.select_datatable("select * from Kunden where Nachname = '" + suchen + "'");
                    dgv_Kundenview.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Form_laden_Load(sender, e);
            }
            tb_suchen.Text = "";
        }
               
        //Beim Klicken auf die Picturebox soll die Form_BEaufnehmen aufgerufen werden
        private void pb_BEaufnehmen_Click(object sender, EventArgs e)
        {
            Form_BEaufnehmen  ke = new Form_BEaufnehmen();
            ke.Show();
        }
                
        //Sobald man auf den Mülleimer klickt soll der Kunde aus dem System gelöscht werden können.
        //Dies geschieht durch den SQL Befehl DELETE from Kunden where KundenID=... Dies sagt aus, 
        //dass wenn man eine KundenID im DataGridView ausgewählt hat, der gesamte Datensatz des Kunden 
        //entfernt wird
        private void pb_delete_Click(object sender, EventArgs e)
        {
            {
                //String str = @"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;";
                //MySqlConnection con = null;
                //con = new MySqlConnection(str);
                //con.Open();

                //MySqlCommand cmd = new MySqlCommand("DELETE from Kunden where KundenID="
                //    + dgv_Kundenview.SelectedRows[0].Cells[0].Value.ToString(), con);

                if (dgv_Kundenview.Rows.Count > 1 && dgv_Kundenview.SelectedRows[0].Index != dgv_Kundenview.Rows.Count - 1)

                {
                    db.insert_update("DELETE from Kunden where KundenID=" + dgv_Kundenview.SelectedRows[0].Cells[0].Value.ToString());
                    //cmd.Connection = con;
                    //cmd.ExecuteNonQuery();
                    //con.Close();
                    dgv_Kundenview.Rows.RemoveAt(dgv_Kundenview.SelectedRows[0].Index);
                }
            }
        }

        private void pb_Konfigerstellen_Click(object sender, EventArgs e)
        {
            Form_Konfigerstellen ke = new Fahrradladen_Gruppe1.Form_Konfigerstellen();
            ke.Show();
        }

        private void pb_Konfigerstellen_MouseHover(object sender, EventArgs e)
        {
            ToolTip ke = new ToolTip();
            ke.SetToolTip(this.pb_Konfigerstellen, "Konfiguration");
        }
    }
}
