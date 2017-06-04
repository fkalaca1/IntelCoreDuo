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
    class UserViewModel
    {
        public User User { get; set; }
        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }

        public UserViewModel()
        {
            User = PocetnaViewModel.Korisnik;            
            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }
    }
}
