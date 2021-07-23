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
    public partial class Form_Mitarbeiter : Form
    {
        DBVerbindung db = new DBVerbindung("Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad; allow zero datetime = true;");
        //MySqlDataAdapter sda;
        DataTable dt = new DataTable();
        public Form_Mitarbeiter()
        {
            InitializeComponent();
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
        private void pb_MAerstellen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_MAerstellen, "Mitarbeiter erstellen");
        }

        private void pb_delete_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_delete, "Mitarbeiter entfernen");
        }

        private void pb_suchen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_suchen, "Mitarbeiter suchen");
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

        //Beim Laden der Form_Mitarbeiter sollen alle Mitarbeiter auf einem Blick einsehbar sein. Somit kann man
        //Beim Öffnen der Form direkt sehen welche Mitarbeiter es gibt und in welcher Abteilung sie tätig sind.
        private void Form_Mitarbeiter_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            dgv_MAview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt = db.select_datatable("select * from Mitarbeiter");
            dgv_MAview.DataSource = dt;

        }

        //Sobald man auf die Picturebox Suchen klickt, soll in der Datenbank nach einem Mitarbeiter in der 
        //Tabelle Mitarbeiter nach dem Nachnamen gesucht werden.
        private void pb_suchen_Click(object sender, EventArgs e)
        {
            if (tb_suchen.Text != "")
            {
                string suchen = tb_suchen.Text;
                try
                {
                    dt = db.select_datatable("select * from Mitarbeiter where Nachname = '" + suchen + "'");
                    dgv_MAview.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Form_Mitarbeiter_Load(sender,e);
            }
            tb_suchen.Text = "";
        }
                
        //Wenn man einen Mitarbeiter ausgewählt hat (durch eine Markierung der ganzen Zeile) soll dieser über die 
        //Picturebox Delete aus der Datenbank entfernt werden. Ist der Mitarbeiter einmal gelöscht, kann
        //man diesen nicht wieder herstellen. Er müsste neu angelegt werden.
        private void pb_delete_Click(object sender, EventArgs e)
        {
            //String str = @"Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;";
            //MySqlConnection con = null;
            //con = new MySqlConnection(str);
            //con.Open();

            //MySqlCommand cmd = new MySqlCommand("DELETE from Mitarbeiter where MAID="
            //    + dgv_MAview.SelectedRows[0].Cells[0].Value.ToString() + "", con);

            if (dgv_MAview.Rows.Count > 1 && dgv_MAview.SelectedRows[0].Index != dgv_MAview.Rows.Count - 1)

            {
                db.insert_update("DELETE from Mitarbeiter where MAID=" + dgv_MAview.SelectedRows[0].Cells[0].Value.ToString());
               
                dgv_MAview.Rows.RemoveAt(dgv_MAview.SelectedRows[0].Index);
            }
        }

        //Durch Klicken auf die Picturebox MAErstellen soll das Programm die neue Form MAerstellen erstellen
        private void pb_MAerstellen_Click(object sender, EventArgs e)
        {
            Form_MAerstellen me = new Form_MAerstellen();
            me.Show();
        }

        private void pb_delete_Click_1(object sender, EventArgs e)
        {
            if (dgv_MAview.Rows.Count > 1 && dgv_MAview.SelectedRows[0].Index != dgv_MAview.Rows.Count - 1)

            {
                db.insert_update("DELETE from mitarbeiter where MAID=" + dgv_MAview.SelectedRows[0].Cells[0].Value.ToString());
               
                dgv_MAview.Rows.RemoveAt(dgv_MAview.SelectedRows[0].Index);
            }
        }
    }
}

