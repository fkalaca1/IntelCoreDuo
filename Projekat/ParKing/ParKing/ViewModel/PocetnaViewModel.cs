using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ParKing.Model;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ParKing.Helper;

namespace ParKing.ViewModel
{
    public class PocetnaViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Parking> Parkinzi { get; set; }
        public ObservableCollection<ParkingRezervacija> ParkinziRezervacije { get; set; }
        public Parking Parking { get; set; }
        public static ParkingRezervacija ParkingRezervacija { get; set; }
        public static User Korisnik { get; set; }
        public VlasnikParkinga Vlasnik { get; set; }
        public Administrator Admin { get; set; }
        public Gost Gost { get; set; }


        public static ICommand RezervisiBtn { get; set; }

        private String rezervisanoOd;
        private String rezervisanoDo;
        private String ukupnaCijena;

        public String UkupnaCijena
        {
            get
            {
                return ukupnaCijena;
            }
            set
            {
                Set(ref ukupnaCijena, value);
            }
        }
        public String RezervisanoOd
        {
            get
            {
                return rezervisanoOd;
            }
            set
            {
                Set(ref rezervisanoOd, value);
            }
        }
        public String RezervisanoDo
        {
            get
            {
                return rezervisanoDo;
            }
            set
            {
                Set(ref rezervisanoDo, value);
            }
        }
        public PocetnaViewModel()
        {
            Parkinzi = new ObservableCollection<Parking>();
            ParkinziRezervacije = new ObservableCollection<ParkingRezervacija>();
            //ParkingRezervacija = new ParkingRezervacija();
            Parking = new Parking();
            //Korisnik = new User();
            Admin = new Administrator();
            Vlasnik = new VlasnikParkinga();

            RezervisanoOd = String.Format("{0:d MMMM yyyy, HH:mm}", DateTime.Now);
            RezervisanoDo = String.Format("{0:d MMMM yyyy, HH:mm}", DateTime.Now.AddHours(1.0));
            RezervisiBtn = new RelayCommand<object>(Rezervisi);

            using (var db = new ParkingDBContext())
            {
                foreach (var par in db.Parkingzi)
                    Parkinzi.Add(par);
                foreach (var par in db.ParkingRezervacija)
                    ParkinziRezervacije.Add(par);
            }
            
        }

        public void Rezervisi(object parameter)
        {
            DateTime rezervacijaOd = DateTime.ParseExact(RezervisanoOd, "d MMMM yyyy, HH:mm", null);
            DateTime rezervacijaDo = DateTime.ParseExact(RezervisanoDo, "d MMMM yyyy, HH:mm", null);

            if (rezervacijaOd.CompareTo(rezervacijaDo) >= 0)
            {
                return;
            }
            UkupnaCijena = (ParkingRezervacija.Cijena * (int)(rezervacijaDo - rezervacijaOd).TotalHours).ToString();

            Rezervacija rezervacija = new Rezervacija();
            rezervacija.PocetakRezervacije = RezervisanoOd;
            rezervacija.KrajRezervacije = RezervisanoDo;
            rezervacija.Cijena = UkupnaCijena;
            rezervacija.ParkingRezervacijaId = ParkingRezervacija.ParkingRezervacijaId;
            rezervacija.UserId = Korisnik.UserId;
            
            using(var db = new ParkingDBContext())
            {
                db.Rezervacije.Add(rezervacija);

                db.SaveChanges();
                rezervacija.RezervisaniParking = db.ParkingRezervacija.FirstOrDefault(p => p.ParkingRezervacijaId == ParkingRezervacija.ParkingRezervacijaId);

                Validacija.message(rezervacija.ToString(), "Uspjesna rezervacija");
            }            
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
