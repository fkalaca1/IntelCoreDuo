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
        public ObservableCollection<ParkingRezervacija> ParkinziRezervacije { get; set; }


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
            Parkinzi = new ObservableCollection<Parking>();
            ParkinziRezervacije = new ObservableCollection<ParkingRezervacija>();
            using (var db = new ParkingDBContext())
            {
                foreach (var p in db.Parkingzi)
                    Parkinzi.Add(p);
                foreach (var p in db.ParkingRezervacija)
                    Parkinzi.Add(p);

            }


                NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);      
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }
    }
}
