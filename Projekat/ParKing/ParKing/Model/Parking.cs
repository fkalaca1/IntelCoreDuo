using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    class Parking
    {
        private String adresa;
        private int kapacitet;
        private List<Ocjena> ocjene;
        private int cijena;

        public event PropertyChangedEventHandler PropertyChanged;

        public Parking(String adresa, int kapacitet, List<Ocjena> ocjene, int cijena)
        {
            this.adresa = adresa;
            this.kapacitet = kapacitet;
            this.ocjene = ocjene;
            this.cijena = cijena;
        }
        public String Adresa { get { return adresa; } set { Set(ref adresa, value); } }
        public int Kapacitet { get { return kapacitet; } set { Set(ref kapacitet, value); } }
        public List<Ocjena> Ocjene { get { return ocjene; } set { Set(ref ocjene, value); } }
        public int Cijena { get { return cijena; } set { Set(ref cijena, value); } }

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
