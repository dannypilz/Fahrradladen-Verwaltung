using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Fahrradladen_Gruppe1
{
    class Konfiguration //Klase für eine Konfiguration
    {
        private List<Produkt> liste_produkt = new List<Produkt>();
        private string bezeichnung;
        private int kundenid;

        //get und set Methoden
        public List<Produkt> Liste_Produkt
        {
            get
            {
                return liste_produkt;
            }
            set
            {
                liste_produkt = value;
            }

        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }
            set
            {
                bezeichnung = value;
            }

        }

        public int KundenID
        {
            get
            {
                return kundenid;
            }
            set
            {
                kundenid = value;
            }
        }

        //Konstruktor
        public Konfiguration()
        {
            List<Produkt> liste_produkt = new List<Produkt>();
            bezeichnung = "";
            kundenid=0;
        }

        //zum hinzufügen eines Produktes in die Konfiguration
        public void AddProduct(Produkt P)
        {
            if (Liste_Prüfen(this.liste_produkt, P) == -1)
            {
                this.liste_produkt.Add(P);
            }
            else
            {
                MessageBox.Show("Produkt ist schon Teil der Konfiguration.");
            }            
        }

        //zum löschen eines Produktes von der Konfiguration
        public void DeleteProduct(Produkt P)
        {
            if (Liste_Prüfen(this.liste_produkt, P) == -1)
            {
                MessageBox.Show("Produkt nicht Teil der Konfiguration.");
            }
            else
            {
                this.liste_produkt.RemoveAt(this.Liste_Prüfen(this.liste_produkt, P));
            }
        }

        //Methodezum prüfen auf dopplung
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

        //Methode zum konvertieren in eine DataTable
        public DataTable umwandelnTabelle()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProduktID", typeof(int));
            dt.Columns.Add("ProduktBezeichnung", typeof(String));
            dt.Columns.Add("KategorieID", typeof(int));
            dt.Columns.Add("KategorieBezeichnung", typeof(String));
            dt.Columns.Add("Preis", typeof(double));
            for (int i = 0; i < this.liste_produkt.Count; i++)
            {
                DataRow dtrow = dt.NewRow(); //neues Objekt "Zeile" erstellen
                dtrow[0] = Convert.ToInt32(this.liste_produkt[i].ProduktID); //mittels Index der DT befüllen
                dtrow[1] = Convert.ToString(this.liste_produkt[i].Bezeichnung);
                dtrow[2] = Convert.ToInt32(this.liste_produkt[i].KategorieID);
                dtrow[3] = Convert.ToString(this.liste_produkt[i].KategorieBezeichnung);
                dtrow[4] = Convert.ToDouble(this.liste_produkt[i].Preis);
                dt.Rows.Add(dtrow);
            }
            return dt;
        }

        //zum checken ob die Konfiguratio gegen eine bestehende Regel verstößt
        public bool RegelCheck()
        {
            DBVerbindung db = new DBVerbindung("Server=127.0.0.1;Uid=root;Pwd=;Database=fahrrad;");
            DataTable dt = db.select_datatable("select * from regelwerk");
            for (int i = 0; i < db.count_einträge("select Count(*) from regelwerk"); i++)
            {
                int TeilA = Convert.ToInt32(dt.Rows[i]["TeilA"].ToString());
                int TeilB = Convert.ToInt32(dt.Rows[i]["TeilB"].ToString());

                for (int j = 0; j < this.liste_produkt.Count; j++)
                {
                    if (this.liste_produkt[j].produktid == TeilA)
                    {
                        for (int k = 0; k < this.liste_produkt.Count; k++)
                        {
                            if (this.liste_produkt[k].produktid == TeilB)
                            {
                                return false;
                            }                            
                        }
                    }
                }
            }
            return true;
        }

    }    
}
