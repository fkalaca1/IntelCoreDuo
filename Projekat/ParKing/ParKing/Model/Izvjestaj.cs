using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class Izvjestaj
    {
        private double prihod;
        private int promet;
        private ParkingRezervacija maticni;

        public Izvjestaj(double prihod, int promet, ParkingRezervacija maticni)
        {
            this.prihod = prihod;
            this.promet = promet;
            this.maticni = maticni;
        }
        //geteri seteri
        public double Prihod
        {
            get { return prihod; }
            set
            {
                Set(ref prihod, value);
            }
        }

        public int Promet
        {
            get { return promet; }
            set
            {
                Set(ref promet, value);
            }
        }
        public ParkingRezervacija Maticni { get { return maticni; } set { Set(ref maticni, value); } }

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

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
