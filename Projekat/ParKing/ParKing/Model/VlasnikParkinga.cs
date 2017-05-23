using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    class VlasnikParkinga : User
    {
        private List<Parking> mojiParkinzi;
        public VlasnikParkinga(string email, string brojTelefona, string sifra, List<Parking> mojiParkinzi, List<Rezervacija> rezervacije) : base(email, brojTelefona, sifra, rezervacije)
        {
            this.mojiParkinzi = mojiParkinzi;
        }
        public List<Parking> MojiParkinzi{ get { return mojiParkinzi; } set { Set(ref mojiParkinzi, value); } }
    }
}
