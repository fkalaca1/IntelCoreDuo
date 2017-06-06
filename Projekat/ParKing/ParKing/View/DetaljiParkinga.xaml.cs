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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ParKing.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetaljiParkinga : Page
    {
        public DetaljiParkinga()
        {
            this.InitializeComponent();
            this.DataContext = new ViewModel.ParkingViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                var parking = (ParkingRezervacija)e.Parameter;
                ((ViewModel.ParkingViewModel)this.DataContext).parking = parking;
                RezervisiBtn.IsEnabled = true;
            }
            catch (Exception ex)
            {
                var park = (Parking)e.Parameter;
                ((ViewModel.ParkingViewModel)this.DataContext).parking = park;
                RezervisiBtn.IsEnabled = false;
            }
        }
    }
}
