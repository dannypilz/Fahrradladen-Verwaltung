using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Fahrradladen_Gruppe1
{
    class WarenkorbBestellung //Klasse für einen Warenkorb
    {
        private List<Produkt> liste_produkt = new List<Produkt>();
        private List<int> liste_menge = new List<int>();
        private double gesammtwert;

        //get set Methoden
        public List<Produkt> Liste_Produkt
        {
            get
            {
                return liste_produkt;
            }
                set
            {

                liste_produkt  = value;

            }
        }

        public List<int> Liste_Menge
        {
            get
            {
                return liste_menge;
            }
            set
            {

                liste_menge = value;

            }
        }

        public double Gesammtwert
        {
            get
            {
                return gesammtwert;
            }
            set
            {

                gesammtwert = value;

            }
        }

        //Konstruktor
        public WarenkorbBestellung()
        {
            List<Produkt> liste_produkt = new List<Produkt>();
            List<int> liste_menge = new List<int>();
            gesammtwert = 0;
        }

        //Methode zum hinzufügen eines Produktes zum Warenkorb
        public void AddProduct(Produkt P)
        {
            if (Liste_Prüfen(this.liste_produkt, P) == -1)
            {
                this.liste_produkt.Add(P);
                this.liste_menge.Add(1);
            }
            else
            {
                this.liste_menge[Liste_Prüfen(this.liste_produkt, P)] += 1;
            }
            this.gesammtwert += P.Preis;
        }

        //Methode zum löschen eines Produktes zum Warenkorb
        public void DeleteProduct(Produkt P)
        {
            if (Liste_Prüfen(this.liste_produkt, P) == -1)
            {
                MessageBox.Show("Produkt nicht Teil der Bestellung.");
            }
            else
            {
                int i = this.Liste_Prüfen(this.liste_produkt, P);
                if (this.liste_menge[i] == 1)
                {
                    this.liste_produkt.RemoveAt(i);
                }
                else
                {
                    this.liste_menge[i] -= 1;
                }
            }
        }

        //Methode zum prüfen auf doppelung
        public int Liste_Prüfen(List<Produkt> Liste, Produkt P)
        {
            for (int i = 0; i < Liste.Count; i++)
            {
                if (Liste[i].produktid == P.produktid)
                {
                    return i;
                }
            }

            return -1;
        }

        //Methode zum konvertieren eines Warenkorbes in eine Datatable
        public DataTable umwandelnTabelle()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProduktID", typeof(int));
            dt.Columns.Add("ProduktBezeichnung", typeof(String));
            dt.Columns.Add("KategorieID", typeof(int));
            dt.Columns.Add("KategorieBezeichnung", typeof(String));
            dt.Columns.Add("Preis", typeof(double));
            dt.Columns.Add("Menge", typeof(int));
            for (int i = 0; i < this.liste_produkt.Count; i++)
            {
                DataRow dtrow = dt.NewRow(); //neues Objekt "Zeile" erstellen
                dtrow[0] = Convert.ToInt32(this.liste_produkt[i].ProduktID); //mittels Index der DT befüllen
                dtrow[1] = Convert.ToString(this.liste_produkt[i].Bezeichnung);
                dtrow[2] = Convert.ToInt32(this.liste_produkt[i].KategorieID);
                dtrow[3] = Convert.ToString(this.liste_produkt[i].KategorieBezeichnung);
                dtrow[4] = Convert.ToDouble(this.liste_produkt[i].Preis);
                dtrow[5] = Convert.ToInt32(this.liste_menge[i]);
                dt.Rows.Add(dtrow);
            }
            return dt;
        }        
    }
}
