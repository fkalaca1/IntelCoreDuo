using ParKing.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParKing.ViewModel
{
    class RegistracijaParkingaViewModel
    {
        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }

        public RegistracijaParkingaViewModel()
        {
            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }
    }
}
