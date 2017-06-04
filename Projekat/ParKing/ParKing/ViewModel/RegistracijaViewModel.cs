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
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;
using Windows.Security.Cryptography;

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
        private String errorMessage;
        private String imeErrorMessage;
        private String prezimeErrorMessage;
        private String emailErrorMessage;
        private String passwordErrorMessage;
        private String repeatPasswordErrorMessage;
        private String checkBoxErrorMessage;
        private bool boxChecked;

        public String ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                Set(ref errorMessage, value);
            }
        }

        public String ImeErrorMessage
        {
            get
            {
                return imeErrorMessage;
            }
            set
            {
                Set(ref imeErrorMessage, value);
            }
        }

        public String PrezimeErrorMessage
        {
            get
            {
                return prezimeErrorMessage;
            }
            set
            {
                Set(ref prezimeErrorMessage, value);
            }
        }
        public String EmailErrorMessage
        {
            get
            {
                return emailErrorMessage;
            }
            set
            {
                Set(ref emailErrorMessage, value);
            }
        }

        public String PasswordErrorMessage
        {
            get
            {
                return passwordErrorMessage;
            }
            set
            {
                Set(ref passwordErrorMessage, value);
            }
        }
        public String RepeatPasswordErrorMessage
        {
            get
            {
                return repeatPasswordErrorMessage;
            }
            set
            {
                Set(ref repeatPasswordErrorMessage, value);
            }
        }
        public String CheckBoxErrorMessage
        {
            get
            {
                return checkBoxErrorMessage;
            }
            set
            {
                Set(ref checkBoxErrorMessage, value);
            }
        }
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
        public bool BoxChecked
        {
            get
            {
                return boxChecked;
            }
            set
            {
                Set(ref boxChecked, value);
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
            //NavigationService.GoBack();
            NavigationService.Navigate(typeof(View.Pocetna), new Gost());
        }

        public void RegistrujSe(object parameter)
        {
            using (var db = new ParkingDBContext())
            {
                ImeErrorMessage = PrezimeErrorMessage = EmailErrorMessage = PasswordErrorMessage = RepeatPasswordErrorMessage = "";
                bool flag = false;
                if(Ime == null || Prezime == null || Password == null || RepeatPassword == null || Email == null)
                {
                    ErrorMessage = "Obavezno polje";
                    flag = true;
                    return;
                }
                if(Ime.Length < 3 || Ime.Length > 12)
                {
                    ImeErrorMessage = "Ime mora imati minimalno 3 i maximalno 12 karaktera";
                    flag = true;
                }
                if(Prezime.Length < 3)
                {
                    PrezimeErrorMessage = "Prezime mora imati minimalno 3 i maximalno 12 karaktera";
                    flag = true;
                }
                if(!(new EmailAddressAttribute().IsValid(Email)))
                {
                    EmailErrorMessage = "Pogresan email";
                    flag = true;
                }
                if(Password.Length < 8 || Password.Length > 24)
                {
                    PasswordErrorMessage = "Password mora imati minimalno 8 i maximalno 24 karaktera";
                    flag = true;
                }
                
                if(RepeatPassword != Password)
                {
                    RepeatPasswordErrorMessage = "Password se ne podudara";
                    flag = true;
                }

                if(!BoxChecked)
                {
                    CheckBoxErrorMessage = "Morate prihvatiti uslove koristenja";
                    flag = true;
                }

                if (flag) return;
                User noviKorisnik = new User();

                noviKorisnik.Ime = Ime;
                noviKorisnik.Prezime = Prezime;
                noviKorisnik.Email = Email;
                noviKorisnik.Sifra =  Validacija.createMD5(Password);

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
