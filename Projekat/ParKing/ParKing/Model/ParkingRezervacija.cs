using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    class ParkingRezervacija : Parking
    {
        private Izvjestaj izvjestaj;
        private int brojZauzetihMjesta;
        private int brojMjestaZaRezervaciju;
        private int brojZauzetihMjestaZaRezervaciju;
       // private String telefon;



            //geteri seteri
        public int BrojZauzetihMjesta
        {
            get { return brojZauzetihMjesta; }
            set
            {
                Set(ref brojZauzetihMjesta, value);
            }
        }
        public int BrojMjestaZaRezervaciju
        {
            get { return brojMjestaZaRezervaciju; }
            set
            {
                Set(ref brojMjestaZaRezervaciju, value);
            }
        }
        public int BrojZauzetihMjestaZaRezervaciju
        {
            get { return brojZauzetihMjestaZaRezervaciju; }
            set
            {
                Set(ref brojZauzetihMjestaZaRezervaciju, value);
            }
        }
        public Izvjestaj Izvjestaj
        {
            get { return izvjestaj; }
            set
            {
                Set(ref izvjestaj, value);
            }
        }

    }
}
