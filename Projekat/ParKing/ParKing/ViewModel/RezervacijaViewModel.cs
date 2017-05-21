using ParKing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.ViewModel
{
    public class RezervacijaViewModel
    {
        public ObservableCollection<Rezervacija> Rezervacije { get; set; }

        public RezervacijaViewModel()
        {
            ObservableCollection<Rezervacija> r = new ObservableCollection<Rezervacija>();

            r.Add(new Rezervacija
            {
                PocetakRezervacije = DateTime.ParseExact("2009-05-08,531", "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture),
                KrajRezervacije = DateTime.ParseExact("2019-05-08,531", "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture),
                Cijena = "1.0"
            });

            Rezervacije = r;
        }


    }
}
