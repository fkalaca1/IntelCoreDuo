using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Azure
{
    public class ParkingRezervacija
    {
        public String id { get; set; }
        public String Adresa { get; set; }
        public String BrojTelefona { get; set; }
        public double Cijena { get; set; }
        public double GeoDuzina { get; set; }
        public double GeoSirina { get; set; }

        public int Kapacitet { get; set; }
        public int BrojZauzetihMjesta { get; set; }
        public int BrojMjestaZR { get; set; }
        public int BrojZauzetihMjestaZR { get; set; }
    }
}
