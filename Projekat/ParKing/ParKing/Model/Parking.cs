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
        private Image slika;
        private String telefon;

        public Parking()
        {

        }
        //geteri seteri
        public String Telefon
        {
            get { return telefon; }
            set
            {
                Set(ref telefon, value);
            }
        }
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
        public List<Ocjena> Ocjene
        {
            get { return ocjena; }
            set
            {
                Set(ref ocjena, value);
            }
        }
        public Image Slika
        {
            get { return slika; }
            set
            {
                Set(ref slika, value);
            }
        }


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
