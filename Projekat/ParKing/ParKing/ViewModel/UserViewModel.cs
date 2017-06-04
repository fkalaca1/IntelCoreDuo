using ParKing.Helper;
using ParKing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParKing.ViewModel
{
    class UserViewModel : INotifyPropertyChanged
    {
        public User User { get; set; }
        private String mail;
        private String brojTelefona;
        private String lozinka;
        private bool editEnableMail;
        private String editSaveMail;
        public ICommand EditMail { get; set; }
        private bool editEnableBrojTelefona;
        private String editSaveBrojTelefona;
        public ICommand EditBrojTelefona { get; set; }
        private bool editEnableLozinka;
        private String editSaveLozinka;
        public ICommand EditLozinka { get; set; }
        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }

        public bool EditEnableMail { get { return editEnableMail; } set { Set(ref editEnableMail, value); } }
        public String EditSaveMail { get { return editSaveMail; } set { Set(ref editSaveMail, value); } }
        public bool EditEnableBrojTelefona { get { return editEnableBrojTelefona; } set { Set(ref editEnableBrojTelefona, value); } }
        public String EditSaveBrojTelefona { get { return editSaveBrojTelefona; } set { Set(ref editSaveBrojTelefona, value); } }
        public bool EditEnableLozinka { get { return editEnableLozinka; } set { Set(ref editEnableLozinka, value); } }
        public String EditSaveLozinka { get { return editSaveLozinka; } set { Set(ref editSaveLozinka, value); } }
        public String Mail { get { return mail; } set { Set(ref mail, value); } }
        public String BrojTelefona { get { return brojTelefona; } set { Set(ref brojTelefona, value); } }
        public String Lozinka { get { return lozinka; } set { Set(ref lozinka, value); } }

        public UserViewModel()
        {
            User = PocetnaViewModel.Korisnik;    
            mail = User.Email;
            brojTelefona = User.BrojTelefona;
            lozinka = "Lozinka";
            editEnableMail = false;
            editSaveMail = "edit";
            editEnableBrojTelefona = false;
            editSaveBrojTelefona = "edit";
            editEnableLozinka = false;
            editSaveLozinka = "edit";
            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);
            EditMail = new RelayCommand<object>(editPropertyMail);
            EditBrojTelefona = new RelayCommand<object>(editPropertyBrojTelefona);
            EditLozinka = new RelayCommand<object>(editPropertyLozinka);
        }

        public void editPropertyMail(object parameter)
        {
            if (EditEnableMail)
            {
                EditSaveMail = "edit";
            }
            else
            {
                EditSaveMail = "save";
                Mail = "";
            }
            EditEnableMail = !EditEnableMail;
        }

        public void editPropertyBrojTelefona(object parameter)
        {
            if (EditEnableBrojTelefona)
            {
                EditSaveBrojTelefona = "edit";
            }
            else
            {
                EditSaveBrojTelefona = "save";
                BrojTelefona = "";
            }
            EditEnableBrojTelefona = !EditEnableBrojTelefona;
        }

        public void editPropertyLozinka(object parameter)
        {
            if (EditEnableLozinka)
            {
                EditSaveLozinka = "edit";
            }
            else
            {
                EditSaveLozinka = "save";
                Lozinka = "";
            }
            EditEnableLozinka = !EditEnableLozinka;
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

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }
    }
}
