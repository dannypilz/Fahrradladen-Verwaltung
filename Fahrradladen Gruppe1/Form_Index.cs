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
    public partial class Form_Index : Form
    {
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

        public Form_Index()
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
        private void pb_Laden_MouseHover(object sender, EventArgs e)
        {
            ToolTip tl = new ToolTip();
            tl.SetToolTip(this.pb_Laden, "Ladenmitarbeiter");
        }

        private void pb_Verwaltung_MouseHover(object sender, EventArgs e)
        {
            ToolTip tv = new ToolTip();
            tv.SetToolTip(this.pb_Verwaltung, "Verwaltungsmitarbeiter");
        }

        private void pb_Werkstatt_MouseHover(object sender, EventArgs e)
        {
            ToolTip tw = new ToolTip();
            tw.SetToolTip(this.pb_Werkstatt, "Werkstattmitarbeiter");
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

        //Form_Load wird hier lediglich verwendet, damit man die Form verschieben kann
        private void Form_Index_Load(object sender, EventArgs e)
        {
            //Die folgenden Befehle machen die Form bewegbar
            this.MouseDown += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseUp += new MouseEventHandler(Form_Index_MouseAction);
            this.MouseMove += new MouseEventHandler(Form_Index_MouseMove);
        }

        //Beim Klicken auf die jeweiligen Pictureboxen sollen die jeweiligen Unterformen geöffnet werden
        private void pb_Laden_Click(object sender, EventArgs e)
        {
            Form_Laden fl = new Form_Laden();
            fl.Show();            
        }

        private void pb_Verwaltung_Click(object sender, EventArgs e)
        {
            Form_Verwaltung fv = new Form_Verwaltung();
            fv.Show();
        }

        private void pb_Werkstatt_Click(object sender, EventArgs e)
        {
            Form_Werkstatt fw = new Form_Werkstatt();
            fw.Show();
        }       
    }
}
