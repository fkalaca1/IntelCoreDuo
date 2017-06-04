using ParKing.Helper;
using ParKing.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParKing.ViewModel
{
    public class PrijavaViewModel : INotifyPropertyChanged
    {
        public ICommand Back { get; set; }
        public ICommand Login { get; set; }
        public ICommand Registracija { get; set; }
        INavigationService NavigationService { get; set; }

        private String username;
        private String password;
        private String errorMessage;

        public String Username { get { return username; } set { Set(ref username, value); } }
        public String Password { get { return password; } set { Set(ref password, value); } }
        public String ErrorMessage { get { return errorMessage; } set { Set(ref errorMessage, value); } }

        public PrijavaViewModel()
        {
            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(goBack);
            Login = new RelayCommand<object>(loginButton_click);
            Registracija = new RelayCommand<object>(registracija);
        }

        public void registracija (object parameter)
        {
            NavigationService.Navigate(typeof(View.Registracija), new Gost());
        }

        public void goBack(object parameter)
        {
            NavigationService.Navigate(typeof(View.Pocetna), new Gost());
        }

        public void loginButton_click(object parameter)
        {
            using (var db = new ParkingDBContext())
            {
                ErrorMessage = "";
                if (Username == null && Password == null)
                {
                    ErrorMessage = "Unesite podatke";
                    return;
                }
                foreach(User user in db.Useri)
                {
                    if (user.Email == Username)
                    {
                        if (user.Sifra == (Validacija.createMD5(Password)))
                        {
                            ErrorMessage = "Dobro";
                            NavigationService.Navigate(typeof(View.Pocetna), user);
                        }
                        ErrorMessage = "Pogresna sifra ili mail";
                        break;
                    }
                }
            }
        }

        protected virtual void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Set<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
