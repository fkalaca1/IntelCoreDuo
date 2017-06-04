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
    public sealed partial class ParkingPopup : UserControl
    {
        public ParkingPopup()
        {
            this.InitializeComponent();
        }
        public String AdresaTextBlock { get { return (String)GetValue(AdresaTextBlockProperty); } set { SetValue(AdresaTextBlockProperty, value); } }
        public static readonly DependencyProperty AdresaTextBlockProperty = DependencyProperty.Register("AdresaTextBlock", typeof(string), typeof(ParkingPopup), new PropertyMetadata(""));
        public String BrTelefonaHyperlingButton { get { return (String)GetValue(BrTelefonaHyperlingButtonProperty); } set { SetValue(BrTelefonaHyperlingButtonProperty, value); } }
        public static readonly DependencyProperty BrTelefonaHyperlingButtonProperty = DependencyProperty.Register("BrTelefonaHyperlingButton", typeof(string), typeof(ParkingPopup), new PropertyMetadata(""));
        public double RatingP { get { return (double)GetValue(RatingPProperty); } set { SetValue(RatingPProperty, value); } }
        public static readonly DependencyProperty RatingPProperty = DependencyProperty.Register("RatingP", typeof(double), typeof(ListaParkingElement), new PropertyMetadata(""));
        public String RatingTextBlock { get { return (String)GetValue(RatingTextBlockPropery); } set { SetValue(RatingTextBlockPropery, value); } }
        public static readonly DependencyProperty RatingTextBlockPropery = DependencyProperty.Register("RatingTextBlock", typeof(string), typeof(ParkingPopup), new PropertyMetadata(""));
        public String CijenaTextBlock { get { return (String)GetValue(CijenaTextBlockProperty); } set { SetValue(CijenaTextBlockProperty, value); } }
        public static readonly DependencyProperty CijenaTextBlockProperty = DependencyProperty.Register("CijenaTextBlock", typeof(String), typeof(ParkingPopup), new PropertyMetadata(""));
        public String KapacitetTextBlock { get { return (String)GetValue(KapacitetTextBlockProperty); } set { SetValue(KapacitetTextBlockProperty, value); } }
        public static readonly DependencyProperty KapacitetTextBlockProperty = DependencyProperty.Register("KapacitetTextBlock", typeof(String), typeof(ParkingPopup), new PropertyMetadata(""));
    }
}
