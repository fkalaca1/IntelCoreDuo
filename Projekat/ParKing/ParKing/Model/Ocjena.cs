using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class Ocjena : INotifyPropertyChanged
    {
        private int ocjenaP;
        private String komentar;
        private Parking maticni;

        public Ocjena(int ocjenaP, String komentar, Parking maticni)
        {
            this.ocjenaP = ocjenaP;
            this.komentar = komentar;
            this.maticni = maticni;
        }

        public int OcjenaP { get { return ocjenaP; } set { Set(ref ocjenaP, value); } }
        public String Komentar { get { return komentar; } set { Set(ref komentar, value); } }
        public Parking Maticni { get { return maticni; } set { Set(ref maticni, value); } }

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
