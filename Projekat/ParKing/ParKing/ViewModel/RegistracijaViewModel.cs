using ParKing.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParKing.ViewModel
{
    public class RegistracijaViewModel
    {
        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }

        public RegistracijaViewModel()
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
