using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class Administrator : User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdministratorId { get; set; }
        public Administrator() { }
        public Administrator(string email, string brojTelefona, string sifra, List<Rezervacija> rezervacije) : base(email, brojTelefona, sifra, rezervacije)
        {
        }
    }
}
