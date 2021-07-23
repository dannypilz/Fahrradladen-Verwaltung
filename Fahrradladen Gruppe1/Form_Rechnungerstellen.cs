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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;

namespace Fahrradladen_Gruppe1
{
    public partial class Form_Rechnungerstellen : Form
    {
        DBVerbindung db = new DBVerbindung("Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
        DataTable dt;

        public Form_Rechnungerstellen()
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
        private void pb_REerstellen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_REerstellen, "Rechnung erstellen");
        }

        private void pb_suchen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tk = new ToolTip();
            tk.SetToolTip(this.pb_suchen, "Kunden suchen");
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

        //Im Datagridview sollen beim Laden der Form alle Kunden der Tabelle Kunden angezeigt werden
        private void Form_Rechnungerstellen_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);

            dgv_Kundenview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                dt = db.select_datatable("select k.KundenID, k.Nachname, k.Name, k.Firma, k.PLZ , k.Ort, k.Strasse, k.Hausnummer, b.Datum, b.Bestellsumme from Kunden k join Bestellung b on k.KundenID = b.KundenID");
                dgv_Kundenview.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pb_suchen_Click(object sender, EventArgs e)
        {

            //Sobald man auf das Suchenicon klickt soll nach dem Nachnamen des Kunden gesucht werden 
            if (tb_suchen.Text != "")
            {
                string suchen = tb_suchen.Text;
                try
                {
                    dt = db.select_datatable("select k.KundenID, k.Nachname, k.Name, k.Firma, k.PLZ, k.Ort, k.Strasse, k.Hausnummer, b.Datum, b.Bestellsumme from Kunden k join Bestellung b on k.KundenID = b.KundenID where (k.Nachname Like '%" + suchen + "%'  or k.Firma Like '%" + suchen + "%')");
                    dgv_Kundenview.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Form_Rechnungerstellen_Load(sender, e);
            }
            tb_suchen.Text = "";            
        }            

        private void pb_REerstellen_Click(object sender, EventArgs e)
        {           
            object oMissing = System.Reflection.Missing.Value;
            object oEndofDoc = "//endofdoc";

            //Word starten und ein neues Dokument erstellen
            Word.Application oWord;
            Word.Document Rechnung;
            oWord = new Word.Application();
            oWord.Visible = true;
            Rechnung = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            // Text ausgeben lassen
            DataGridViewRow row = dgv_Kundenview.SelectedRows[0];

            //Für das Datum müssen wir die Uhrzeit entfernen, deshalb wird eine extra Variable erstellt,
            //um mit dem substring Befehl zu arbeiten.
            string date = Convert.ToString(row.Cells[8].Value);

            //Hier entsteht der Text für die Ausgabe des Word-Dokumentes.           

            string cmdText = Convert.ToString(row.Cells[2].Value) + " " + Convert.ToString(row.Cells[1].Value)
                + Environment.NewLine + Convert.ToString(row.Cells[3].Value)
                + Environment.NewLine + Convert.ToString(row.Cells[6].Value) + " " + Convert.ToInt32(row.Cells[7].Value)
                + Environment.NewLine + Convert.ToInt64(row.Cells[4].Value) + " " + Convert.ToString(row.Cells[5].Value)
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine + "Sehr geehrte Damen und Herren des Hauses " + Convert.ToString(row.Cells[1].Value)
                + Environment.NewLine
                + Environment.NewLine + "Ihre Bestellung vom " + date.Substring(0, 10) + " wird nun zahlungsfällig."
                + Environment.NewLine + "Deshalb bitten wir Sie die geforderte Summe von " + Convert.ToDouble(row.Cells[9].Value) + "€ inkl. MwSt. an uns zu überweisen."
                + Environment.NewLine
                + Environment.NewLine + "Mit freundlichen Grüßen"
                + Environment.NewLine + "Die Fahrradladen AG";

            string text = cmdText;

            //kleine Formatierung, um das Worddokument ein wenig anzupassen
            object start = 0;
            object end = 0;
            Word.Range rng = Rechnung.Range(ref start, ref end);
            rng.Text = text;
            rng.Paragraphs.Format.LineSpacing = 9;
            rng.Font.Name = "Calibri";
            rng.Select();
        }

    }
}
