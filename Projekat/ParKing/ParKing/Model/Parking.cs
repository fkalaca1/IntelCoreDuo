using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ParKing.Model
{
    public class Parking : INotifyPropertyChanged
    {
        private String adresa;
        private int kapacitet;
        private double cijena;
        private List<Ocjena> ocjene;

        public Parking()
        {

        }

        public Parking(String adresa, int kapacitet, List<Ocjena> ocjene, double cijena)
        {
            this.adresa = adresa;
            this.kapacitet = kapacitet;
            this.cijena = cijena;
            this.ocjene = ocjene;
        }
        //geteri seteri

        public virtual String KapacitetP { get { return "(-/" + kapacitet + ")"; } }

        public String Adresa
        {
            get { return adresa; }
            set
            {
                Set(ref adresa, value);
            }
        }
        public int Kapacitet
        {
            get { return kapacitet; }
            set
            {
                Set(ref kapacitet, value);
            }
        }
        public double Cijena
        {
            get { return cijena; }
            set
            {
                Set(ref cijena, value);
            }
        }

        public String DajCijenu { get { return Cijena.ToString() + " KM"; } }

        public List<Ocjena> Ocjene
        {
            get { return ocjene; }
            set
            {
                Set(ref ocjene, value);
            }
        }

        public double Prosjek
        {
            get
            {
                double povratna = 0;
                for (int i = 0; i < ocjene.Count; i++)
                {
                    povratna += ocjene[i].OcjenaP;
                }
                return povratna / (5 * ocjene.Count);
            }
        }

        public String BrOcjena { get { return "(" + ocjene.Count + ")"; } }

        protected virtual void OnPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Set<T>(ref T storage, T value, [CallerMemberName] String propertyName=null)
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
