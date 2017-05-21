using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class ParkingRezervacija : Parking
    {
        private Izvjestaj izvjestajP;
        private String brojTelefona;
        private int brojZauzetihMjesta;
        private int brojMjestaZaRezervaciju;
        private int brojZauzetihMjestaZaRezervaciju;
       // private String telefon;

        public ParkingRezervacija(string adresa, int kapacitet, List<Ocjena> ocjene, int cijena, Izvjestaj izvjestajP,
            String brojTelefona, int brojZauzetihMjesta, int brojMjestaZR, int brojZauzetihMjestaZR) : base(adresa, kapacitet, ocjene, cijena)
        {
            this.izvjestajP = izvjestajP;
            this.brojTelefona = brojTelefona;
            this.brojZauzetihMjesta = brojZauzetihMjesta;
            this.brojMjestaZaRezervaciju = brojMjestaZR;
            this.brojZauzetihMjestaZaRezervaciju = brojZauzetihMjestaZR;
        }

        public Izvjestaj IzvjestajP { get { return izvjestajP; } set { Set(ref izvjestajP, value); } }
        public String BrojTelefona { get { return brojTelefona; } set { Set(ref brojTelefona, value); } }
        public int BrojZauzetihMjesta { get { return brojZauzetihMjesta; } set { Set(ref brojZauzetihMjesta, value); } }
        public int BrojMjestaZR { get { return brojMjestaZaRezervaciju; } set { Set(ref brojMjestaZaRezervaciju, value); } }
        public int BrojZauzetihMjestaZR { get { return brojZauzetihMjestaZaRezervaciju; } set { Set(ref brojZauzetihMjestaZaRezervaciju, value); } }
    }
}