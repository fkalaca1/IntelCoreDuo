using ParKing.Helper;
using ParKing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ParKing.ViewModel
{
    public class ParkingViewModel
    {
        public ObservableCollection<Parking> Parkinzi { get; set; }
        private Parking par;
        public Parking parking
        {
            get
            {
                PocetnaViewModel.ParkingRezervacija = par as ParkingRezervacija;

                return par;
            }

            set
            {
                par = value;
            }
        }
        public String BrTelefona
        {
            get
            {
                try
                {
                    return (par as ParkingRezervacija).BrojTelefona;
                }
                catch(Exception e)
                {
                    return "-";
                }
            }
        }
        public ICommand Back { get; set; }
        public ICommand RezervisiCommand { get; set; }
        INavigationService NavigationService { get; set; }
        public ParkingViewModel()
        {
            NavigationService = new NavigationService();
            Back = new RelayCommand<object>(GoBack);

            RezervisiCommand = PocetnaViewModel.RezervisiBtn;
        }

        public void GoBack(object parameter)
        {
            NavigationService.GoBack();
        }

    }
}
