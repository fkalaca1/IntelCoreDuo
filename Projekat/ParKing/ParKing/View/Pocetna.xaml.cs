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
            BasicGeoposition location = new BasicGeoposition();
            location.Latitude = 43.8563;
            location.Longitude = 18.4131;
            MapControl1.Center = new Geopoint(location);
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter is Gost)
            {
                userMenu.Visibility = Visibility.Collapsed;
                AdminMenu.Visibility = Visibility.Collapsed;
                GuestMenu.Visibility = Visibility.Visible;
            }
            else if(e.Parameter is Administrator)
            {
                userMenu.Visibility = Visibility.Collapsed;
                AdminMenu.Visibility = Visibility.Visible;
                GuestMenu.Visibility = Visibility.Collapsed;
            }
            else if(e.Parameter is User)
            {
                userMenu.Visibility = Visibility.Visible;
                AdminMenu.Visibility = Visibility.Collapsed;
                GuestMenu.Visibility = Visibility.Collapsed;
            }
        }

    }
}
