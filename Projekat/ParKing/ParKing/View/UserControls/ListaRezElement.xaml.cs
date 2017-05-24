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
    public sealed partial class ListaRezElement : UserControl
    {
        public ListaRezElement()
        {
            this.InitializeComponent();
        }
        public String ParkingTextBlock { get { return (String)GetValue(ParkingTextBlockProperty); }set { SetValue(ParkingTextBlockProperty, value); } }
        public static readonly DependencyProperty ParkingTextBlockProperty = DependencyProperty.Register("ParkingTextBlock", typeof(string), typeof(ListaRezElement), new PropertyMetadata(""));
        public String CijenaTextBlock { get { return (String)GetValue(CijenaTextBlockProperty); } set { SetValue(CijenaTextBlockProperty, value); } }
        public static readonly DependencyProperty CijenaTextBlockProperty = DependencyProperty.Register("CijenaTextBlock", typeof(string), typeof(ListaRezElement), new PropertyMetadata(""));
        public String PeriodRezervacijeTextBlock { get { return (String)GetValue(PeriodRezervacijeTextBlockProperty); } set { SetValue(PeriodRezervacijeTextBlockProperty, value); } }
        public static readonly DependencyProperty PeriodRezervacijeTextBlockProperty = DependencyProperty.Register("PeriodRezervacijeTextBlock", typeof(string), typeof(ListaRezElement), new PropertyMetadata(""));

        
    }
}
