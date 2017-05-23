using ParKing.Helper;
using ParKing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParKing.ViewModel
{
    class UserViewModel
    {
        public User User { get; set; }
        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }
        public UserViewModel()
        {
            List<Parking> parkinzi = new List<Parking>();
            List<Ocjena> ocjene = new List<Ocjena>();
            ParkingRezervacija temp = new ParkingRezervacija();
            ocjene.Add(new Ocjena(4, "Top parking", temp, User));
            ocjene.Add(new Ocjena(4, "Top parking hue", temp, User));
            ocjene.Add(new Ocjena(5, "Top parking hahaha", temp, User));
            temp.Adresa = "Teheranski trg 14";
            temp.Cijena = 2.5;
            temp.Kapacitet = 40;
            temp.Ocjene = ocjene;
            temp.BrojTelefona = "062/157-463";
            temp.BrojZauzetihMjesta = 23;
            parkinzi.Add(temp); 
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            //kupljenje parkinga iz baze
            User tempU;
            if (parkinzi.Count != 0) tempU = new VlasnikParkinga("riktash38@gmail.com", "062/157-463", "huehuehue", parkinzi, rezervacije);
            else tempU = new User("riktash38@gmail.com", "062/157-463", "huehuehue", rezervacije);
            User = tempU;
            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);
        }
        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }
    }
}
