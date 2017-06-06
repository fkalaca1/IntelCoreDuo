using ParKing.Helper;
using ParKing.Model;
using ParKing.ViewModel;
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
    public sealed partial class UserMenu : UserControl
    {
        INavigationService NavigationService { get; set; }
        public UserMenu()
        {
            this.InitializeComponent();
            NavigationService = new NavigationService();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ProfilListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.Profil));
            }
            else if(PocetnaListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.Pocetna), PocetnaViewModel.Korisnik);
            }
            else if(ListaParkingaListBoxItem.IsSelected || PopularnoListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.ListaParkinga));
            }
            else if(RegistrujParkingListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.RegistracijaParkinga));
            }
            else if(RezervacijeListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.MojeRezervacije), PocetnaViewModel.Korisnik);
            }
            else if(OdjavaListBoxItem.IsSelected)
            {
                NavigationService.Navigate(typeof(View.Prijava));
            }
        }
    }
}
