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
    public sealed partial class Profil : Page
    {
        public Profil()
        {
            this.InitializeComponent();
            DataContext = new ViewModel.UserViewModel();
        }

        private void profilButton_Click(object sender, RoutedEventArgs e)
        {
            profilParkinzi.Visibility = Visibility.Collapsed;
            profilKontrola.Visibility = Visibility.Visible;
        }

        private void parkinziButton_Click(object sender, RoutedEventArgs e)
        {
            profilKontrola.Visibility = Visibility.Collapsed;
            profilParkinzi.Visibility = Visibility.Visible;
        }
    }
}
