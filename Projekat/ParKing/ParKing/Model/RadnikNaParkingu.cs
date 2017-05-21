using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    class RadnikNaParkingu //: User, INotifyPropertyChanged
    {
        /*private Parking radnoMjesto;
        public RadnikNaParkingu(string email, string brojTelefona, string sifra, Parking radnoMjesto) : base(email, brojTelefona, sifra)
        {
            this.radnoMjesto = radnoMjesto;
        }
        public Parking RadnoMjesto { get { return radnoMjesto; } set { Set(ref radnoMjesto, value); } }

        public event PropertyChangedEventHandler PropertyChanged;

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
        }*/
    }
}