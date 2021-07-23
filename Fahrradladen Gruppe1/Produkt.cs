using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Fahrradladen_Gruppe1
{
    class Produkt //Klasse um Produkte zu erstellen unf mit ihnen zu arbeiten
    {
        public int produktid;
        public string bezeichnung;
        public double preis;
        public int kategorieid;
        public string kategoriebezeichnung;

        //get und set Methoden
        public int ProduktID
        {
            get
            {
                return produktid;
            }
            set
            {

                produktid = value;

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

        public double Preis
        {
            get
            {
                return preis;
            }
            set
            {

                preis = value;

            }
        }

        public int KategorieID
        {
            get
            {
                return kategorieid ;
            }
            set
            {

                kategorieid = value;

            }
        }

        public string KategorieBezeichnung
        {
            get
            {
                return kategoriebezeichnung;
            }
            set
            {

                kategoriebezeichnung = value;

            }
        }

        //Konstruktor
        public Produkt(int PrID, string Bez, double Pr, int KatID, string KatBez) 
        {
            produktid = PrID;
            bezeichnung = Bez;
            preis = Pr;
            kategorieid = KatID;
            kategoriebezeichnung = KatBez;
        }        
    }
}
