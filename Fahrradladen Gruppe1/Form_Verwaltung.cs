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
    public partial class Form_Verwaltung : Form
    {
        public Form_Verwaltung()
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

        private void pb_REerstellen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tr = new ToolTip();
            tr.SetToolTip(this.pb_REerstellen, "Rechnung erstellen");
        }

        private void pb_MAerstellen_MouseHover(object sender, EventArgs e)
        {
            ToolTip tm = new ToolTip();
            tm.SetToolTip(this.pb_MAerstellen, "Mitarbeiter");
        }

        //Form_Load wird hier nur benötigt, um die Form verschieben zu können
        private void Form_Verwaltung_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);
        }

        //Beim Klicken auf die jeweiligen Pictureboxen sollen die entsprechenden Formen aufgerufen werden
        private void pb_REerstellen_Click(object sender, EventArgs e)
        {
            Form_Rechnungerstellen re = new Form_Rechnungerstellen();
            re.Show();
        }
        
        private void pb_MAerstellen_Click(object sender, EventArgs e)
        {
            Form_Mitarbeiter me = new Form_Mitarbeiter();
            me.Show();
        }

        
    }
}
