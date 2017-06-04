using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;
using ParKing.Model;
using ParKing.ViewModel;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Storage.Streams;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ParKing.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Pocetna : Page
    {
        public Pocetna()
        {
            this.InitializeComponent();
            this.DataContext = new PocetnaViewModel();
            getLocation();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
        public void AddPushpin(double lat, double lon)
        {
            BasicGeoposition location = new BasicGeoposition();
            location.Latitude = lat;
            location.Longitude = lon;

            var icon = new MapIcon();
            icon.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/parkingMapIcon.png"));
            icon.Location = new Geopoint(location);
            icon.NormalizedAnchorPoint = new Point(0.5, 1);

            MapControl1.MapElements.Add(icon);
            Windows.UI.Xaml.Controls.Maps.MapControl.SetLocation(icon, new Geopoint(location));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Gost)
            {
                userMenu.Visibility = Visibility.Collapsed;
                AdminMenu.Visibility = Visibility.Collapsed;
                GuestMenu.Visibility = Visibility.Visible;
            }
            else if (e.Parameter is Administrator)
            {
                userMenu.Visibility = Visibility.Collapsed;
                AdminMenu.Visibility = Visibility.Visible;
                GuestMenu.Visibility = Visibility.Collapsed;
                PocetnaViewModel.Korisnik = e.Parameter as Administrator;
            }
            else if (e.Parameter is User)
            {
                userMenu.Visibility = Visibility.Visible;
                AdminMenu.Visibility = Visibility.Collapsed;
                GuestMenu.Visibility = Visibility.Collapsed;
                PocetnaViewModel.Korisnik = e.Parameter as User;
            }
        }
        private void MapControl1_MapElementClick(MapControl sender, MapElementClickEventArgs args)
        {
            var map = args.MapElements.FirstOrDefault(x => x is MapIcon) as MapIcon;
           
            var parking = ((ViewModel.PocetnaViewModel)this.DataContext).Parkinzi.ToList().Find(p1 =>(Math.Abs((p1.GeoSirina - map.Location.Position.Longitude)) < 0.001) && (Math.Abs((p1.GeoDuzina - map.Location.Position.Latitude)) < 0.001));

            var parkingRezervacija = ((ViewModel.PocetnaViewModel)this.DataContext).ParkinziRezervacije.ToList().Find(p1 => (Math.Abs((p1.GeoSirina - map.Location.Position.Longitude)) < 0.001) && (Math.Abs((p1.GeoDuzina - map.Location.Position.Latitude)) < 0.001));
            popUp.Visibility = Visibility.Visible;

            if (parking != null)
            {
                ((ViewModel.PocetnaViewModel)this.DataContext).Parking = parking;
                parkingElement.AdresaTextBlock = parking.Adresa;
                parkingElement.CijenaTextBlock = parking.DajCijenu;
                parkingElement.RatingP = parking.Prosjek;
                parkingElement.KapacitetTextBlock = parking.KapacitetP;
                rezervisiButton.IsEnabled = false;
                ((ViewModel.PocetnaViewModel)this.DataContext).UkupnaCijena = " " + parking.DajCijenu;

            }
            else
            {
                ((ViewModel.PocetnaViewModel)this.DataContext).ParkingRezervacija = parkingRezervacija;
                parkingElement.AdresaTextBlock = parkingRezervacija.Adresa;
                parkingElement.CijenaTextBlock = parkingRezervacija.DajCijenu;
                parkingElement.RatingP = parkingRezervacija.Prosjek;
                parkingElement.KapacitetTextBlock = parkingRezervacija.KapacitetP;
                rezervisiButton.IsEnabled = true;
                ((ViewModel.PocetnaViewModel)this.DataContext).UkupnaCijena = " " + parkingRezervacija.DajCijenu;
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Parking> parkinzi = ((ViewModel.PocetnaViewModel)this.DataContext).Parkinzi.ToList();
            List<ParkingRezervacija> parkinziRezervacija = ((ViewModel.PocetnaViewModel)this.DataContext).ParkinziRezervacije.ToList();

            foreach (var p in parkinzi)
                AddPushpin(p.GeoDuzina, p.GeoSirina);
            foreach (var p in parkinziRezervacija)
                AddPushpin(p.GeoDuzina, p.GeoSirina);
        }
        
        private async void getLocation()
        {
            Geolocator gl = new Geolocator
            {
                DesiredAccuracy = PositionAccuracy.High
            };

            try
            {
                Geoposition gp = await gl.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(1),
                    timeout: TimeSpan.FromSeconds(20));
                CenterMap(gp.Coordinate.Point.Position.Latitude, gp.Coordinate.Point.Position.Longitude);
            }
            catch (Exception e)
            {
                //message(e.Message, "ERROR!");

                BasicGeoposition location = new BasicGeoposition();
                location.Latitude = 43.8563;
                location.Longitude = 18.4131;
                MapControl1.Center = new Geopoint(location);
            }
        }
        private void CenterMap(double lat, double lon)
        {
            MapControl1.Center = new Geopoint(new BasicGeoposition()
            {
                Latitude = lat,
                Longitude = lon
            });
        }
    }
}
