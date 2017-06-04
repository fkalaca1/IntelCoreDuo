using ParKing.Helper;
using ParKing.Model;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ParKing.View.UserControls
{
    public sealed partial class GuestMenu : UserControl
    {
        INavigationService NavigationService { get; set; }
        public GuestMenu()
        {
            this.InitializeComponent();
            NavigationService = new NavigationService();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PocetnaListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.Pocetna), new Gost());
            }
            else if (ListaParkingaListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.ListaParkinga));
            }
            else if(PrijavaListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.Prijava));
            }
            else if(RegistracijaListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.Registracija));
            }
        }
    }
}
