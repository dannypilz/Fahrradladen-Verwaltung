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
    public partial class Form_Werkstatt : Form
    {
        public Form_Werkstatt()
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

        private void lbl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_min_Close(object sender, EventArgs e)
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

        private void pb_Produkte_MouseHover(object sender, EventArgs e)
        {
            ToolTip ts = new ToolTip();
            ts.SetToolTip(this.pb_Produkte, "Produkt anlegen");
        }

        private void pb_Lagerbestand_MouseHover(object sender, EventArgs e)
        {
            ToolTip ts = new ToolTip();
            ts.SetToolTip(this.pb_Lagerbestand, "Lagerbestand verwalten");
        }

        private void pb_Regelerstellen_MouseHover(object sender, EventArgs e)
        {
            ToolTip ts = new ToolTip();
            ts.SetToolTip(this.pb_Regelerstellen, "Neue Regel erstellen");
        }

        //Form_Load wird hier nur benötigt, um die Form verschieben zu können
        private void Form_Werkstatt_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);
        }

        //Beim Klicken auf die jeweiligen Pictureboxen sollen die dazugehörigen Formen geöffnet werden
        private void pb_Lagerbestand_Click(object sender, EventArgs e)
        {
            Form_LBbuchen re = new Form_LBbuchen ();
            re.Show();
        }

        private void pb_Produkte_Click(object sender, EventArgs e)
        {
            Produkt_anlegen pa = new Produkt_anlegen();
            pa.Show();
        }        

        private void pb_Regelerstellen_Click(object sender, EventArgs e)
        {
            Form_Regelerstellen re = new Form_Regelerstellen();
            re.Show();
        }

    }
}
