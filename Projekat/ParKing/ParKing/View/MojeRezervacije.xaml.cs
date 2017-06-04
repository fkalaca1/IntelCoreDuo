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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ParKing.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MojeRezervacije : Page
    {
        INavigationService NavigationService { get; set; }
        public MojeRezervacije()
        {
            this.InitializeComponent();
            this.DataContext = new ViewModel.RezervacijaViewModel();
            NavigationService = new NavigationService();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter is User)
            {
                using (var db = new ParkingDBContext())
                {
                    foreach (var r in db.Rezervacije)
                        if (r.UserId == (e.Parameter as User).UserId)
                            ((ViewModel.RezervacijaViewModel)this.DataContext).Rezervacije.Add(r);

                    foreach (var rezervacija in ((ViewModel.RezervacijaViewModel)this.DataContext).Rezervacije)
                        rezervacija.RezervisaniParking = db.ParkingRezervacija.FirstOrDefault(p => p.ParkingRezervacijaId == rezervacija.ParkingRezervacijaId);
                }

            }
        }
    }
}
