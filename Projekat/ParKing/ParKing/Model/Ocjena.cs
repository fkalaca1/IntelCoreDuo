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
        private double ocjenaVrijednost;
        private String kometar;

        public Ocjena()
        {

        }
        public String Komentar
        {
            get { return kometar; }
            set
            {
                Set(ref kometar, value);
            }
        }

        public double OcjenaVr
        {
            get { return ocjenaVrijednost; }
            set
            {
                Set(ref ocjenaVrijednost, value);
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
