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
    public class ListaParkingaViewModel
    {
        public ObservableCollection<Parking> Parkinzi { get; set; }

        public ICommand Back { get; set; }
        INavigationService NavigationService { get; set; }
        private Parking selectedItem;
        public Parking SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;

                NavigationService.Navigate(typeof(View.DetaljiParkinga), selectedItem);
            }
        }
        public ListaParkingaViewModel()
        {
            ObservableCollection<Parking> p = new ObservableCollection<Parking>();
            Ocjena o1 = new Ocjena(5, "Dobar", new Parking(), new User());
            Ocjena o2 = new Ocjena(2, "Dobar", new Parking(), new User());
            Ocjena o3 = new Ocjena(2, "Dobar", new Parking(), new User());
            Ocjena o4 = new Ocjena(2, "Dobar", new Parking(), new User());
            Ocjena o5 = new Ocjena(1, "Dobar", new Parking(), new User());
            List<Ocjena> ocjene = new List<Ocjena>();
            ocjene.Add(o1);
            ocjene.Add(o2);
            Parking tmp = new Parking();
            tmp.Adresa = "Lozionicka";
            tmp.Cijena = 2.5;
            tmp.Kapacitet = 100;
            tmp.Ocjene = ocjene;

            List<Ocjena> ocjene1 = new List<Ocjena>();
            ocjene1.Add(o1);
            ocjene1.Add(o2);
            ocjene1.Add(o3);
            Parking tmp1 = new Parking();
            tmp1.Adresa = "Lozionicka 1";
            tmp1.Cijena = 1.5;
            tmp1.Kapacitet = 1000;
            tmp1.Ocjene = ocjene1;

            List<Ocjena> ocjene2 = new List<Ocjena>();
            ocjene2.Add(o1);
            ocjene2.Add(o2);
            ocjene2.Add(o3);
            ocjene2.Add(o4);
            ocjene2.Add(o5);
            Parking tmp2 = new Parking();
            tmp2.Adresa = "Lozionicka 2";
            tmp2.Cijena = 3;
            tmp2.Kapacitet = 250;
            tmp2.Ocjene = ocjene2;

            p.Add(tmp);
            p.Add(tmp1);
            p.Add(tmp2);

            Parkinzi = p;


            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);      
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }
    }
}
