using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class User : INotifyPropertyChanged
    {
        private String email;
        private String brojTelefona;
        private String sifra;
        //private List<Rezervacija> mojeRezervacije;

        public event PropertyChangedEventHandler PropertyChanged;

        public User(String email, String brojTelefona, String sifra/*, Lista<Rezervacija> mojeRezervacije*/)
        {
            this.email = email;
            this.brojTelefona = brojTelefona;
            this.sifra = sifra;
            //mojeRezervacije = MojeRezervacije;
        }

        public String Email { get { return email; } set { Set(ref email, value); } }
        public String BrojTelefona { get { return brojTelefona; } set { Set(ref brojTelefona, value); } }
        public String Sifra { get { return sifra; } set { Set(ref sifra, value); } }
        //public List<Rezervacija> MojeRezervacije { get { return mojeRezervacije; } set { mojeRezervacije = value; } }

        protected virtual void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public bool Set<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
