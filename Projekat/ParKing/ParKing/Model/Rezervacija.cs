using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParKing.Model
{
    public class Rezervacija : INotifyPropertyChanged
    {
        private DateTime pocetakRezervacije;
        private DateTime krajRezervacije;
        private String cijena;
        private User korisnik;
        private ParkingRezervacija rezervisaniParking;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RezervacijaId { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User Korisnik
        {
            get
            {
                return korisnik;
            }
            set
            {
                korisnik = value;
            }
        }

        public int ParkingRezervacijaId { get; set; }
        [ForeignKey("ParkingRezervacijaId")]
        public virtual ParkingRezervacija RezervisaniParking
        {
            get
            {
                return rezervisaniParking;
            }
            set
            {
                rezervisaniParking = value;
            }
        }
        public String ImeTmp
        {
            get { return "Scc Parking"; }
        }

        public String PocKrajRez
        {
           get { return pocetakRezervacije + "/" + krajRezervacije; }
        }

        public DateTime PocetakRezervacije
        {
            get
            {
                return pocetakRezervacije;
            }
            set
            {
                Set(ref pocetakRezervacije, value);
            }
        }
        public DateTime KrajRezervacije
        {
            get
            {
                return krajRezervacije;
            }
            set
            {
                Set(ref krajRezervacije, value);
            }
        }
        public String Cijena
        {
            get
            {
                return cijena+" KM";
            }
            set
            {
                Set(ref cijena, value);
            }
        }

        public Rezervacija()
        {

        }

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
        }
    }
}
