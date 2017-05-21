using ParKing.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ParKing.ViewModel
{
    public class ParkingViewModel
    {
        public ObservableCollection<Parking> Parkinzi { get; set; }
        public Parking parking { get; set; }
        public ParkingViewModel()
        {
            ObservableCollection<Parking> p=new ObservableCollection<Parking>();
            Parking tmp = new Parking();
            tmp.Adresa = "Lozionicka";
            tmp.Cijena=2.5;
            tmp.Kapacitet = 100;
            Image slika = new Image();
            Uri imageUri = new Uri("ms-appx:///Assets/testpark.png");
            p.Add(tmp);
            Parkinzi = p;
            parking = tmp;

        }

    }
}
