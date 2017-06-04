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
        public virtual ObservableCollection<Rezervacija> Rezervacije { get; set; }

        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }

        public RezervacijaViewModel()
        {
            Rezervacije = new ObservableCollection<Rezervacija>();

            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }


    }
}
