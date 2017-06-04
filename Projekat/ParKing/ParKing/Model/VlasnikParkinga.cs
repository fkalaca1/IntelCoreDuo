using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class VlasnikParkinga : User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VlasnikParkingaId { get; set; }
        private List<Parking> mojiParkinzi;
        public VlasnikParkinga() { }
        public VlasnikParkinga(string email, string brojTelefona, string sifra, List<Parking> mojiParkinzi, List<Rezervacija> rezervacije) : base(email, brojTelefona, sifra, rezervacije)
        {
            this.mojiParkinzi = mojiParkinzi;
        }
        public virtual List<Parking> MojiParkinzi{ get { return mojiParkinzi; } set { Set(ref mojiParkinzi, value); } }
    }
}
