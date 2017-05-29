using ParKing.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ParKing.Model;

namespace ParKing.ViewModel
{
    public class RegistracijaViewModel : INotifyPropertyChanged
    {
        public ICommand Back { get; set; }
        public ICommand Register { get; set; }
        INavigationService NavigationService { get; set; }

        private String ime;
        private String prezime;
        private String email;
        private String password;
        private String repeatPassword;

        public String Ime
        {
            get
            {
                return ime;
            }
            set
            {
                Set(ref ime, value);
            }
        }
        public String Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                Set(ref prezime, value);
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                Set(ref email, value);
            }
        }
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                Set(ref password, value);
            }
        }
        public String RepeatPassword
        {
            get
            {
                return repeatPassword;
            }
            set
            {
                Set(ref repeatPassword, value);
            }
        }


        public RegistracijaViewModel()
        {
            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);
            Register = new RelayCommand<object>(RegistrujSe);
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }

        public String ErrorMessage { get; set; }

        public void RegistrujSe(object parameter)
        {
            using (var db = new ParkingDBContext())
            {
                User noviKorisnik = new User();

                noviKorisnik.Ime = Ime;
                noviKorisnik.Prezime = Prezime;
                noviKorisnik.Sifra = Password;
                noviKorisnik.Email = Email;

                db.Useri.Add(noviKorisnik);

                db.SaveChanges();

                NavigationService.Navigate(typeof(View.Pocetna), noviKorisnik);
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
