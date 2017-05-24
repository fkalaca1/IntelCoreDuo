using ParKing.Helper;
using ParKing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParKing.ViewModel
{
    public class RezervacijaViewModel
    {
        public ObservableCollection<Rezervacija> Rezervacije { get; set; }

        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }


        public RezervacijaViewModel()
        {
            ObservableCollection<Rezervacija> r = new ObservableCollection<Rezervacija>();

            

            r.Add(new Rezervacija
            {
                PocetakRezervacije = DateTime.ParseExact("2009-05-08,531", "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture),
                KrajRezervacije = DateTime.ParseExact("2089-05-08,531", "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture),
                Cijena = "1.0"
            });
            r.Add(new Rezervacija
            {
                PocetakRezervacije = DateTime.ParseExact("2009-05-08,531", "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture),
                KrajRezervacije = DateTime.ParseExact("2019-05-08,531", "yyyy-MM-dd,fff", System.Globalization.CultureInfo.InvariantCulture),
                Cijena = "2.0"
            });

            Rezervacije = r;

        NavigationService = new NavigationService();
    Back = new RelayCommand<object>(GoBack);
        }

public void GoBack(object parameter)
{
    NavigationService.GoBack();
}


    }
}
