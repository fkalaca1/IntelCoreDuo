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
    public class ListaParkingaViewModel
    {
        public ObservableCollection<Parking> Parkinzi { get; set; }

        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }

        public ListaParkingaViewModel()
        {
            ObservableCollection<Parking> p = new ObservableCollection<Parking>();
            Parking tmp = new Parking();
            tmp.Adresa = "Lozionicka";
            tmp.Cijena = 2.5;
            tmp.Kapacitet = 100;
            
            p.Add(tmp);
            p.Add(tmp);
            p.Add(tmp);
            p.Add(tmp);
            Parkinzi = p;


            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);
       
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }
    }
}
