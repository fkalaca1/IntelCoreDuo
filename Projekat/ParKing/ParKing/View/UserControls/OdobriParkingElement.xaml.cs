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
    public sealed partial class OdobriParkingElement : UserControl
    {
        public OdobriParkingElement()
        {
            this.InitializeComponent();
        }

        public String Adresa { get { return (String)GetValue(AdresaProperty); } set { SetValue(AdresaProperty, value); } }
        public static readonly DependencyProperty AdresaProperty = DependencyProperty.Register("Adresa", typeof(string), typeof(OdobriParkingElement), new PropertyMetadata(""));

        public String ImeVlasnika { get { return (String)GetValue(ImeVlasnikaProperty); } set { SetValue(ImeVlasnikaProperty, value); } }
        public static readonly DependencyProperty ImeVlasnikaProperty = DependencyProperty.Register("ImeVlasnika", typeof(string), typeof(OdobriParkingElement), new PropertyMetadata(""));

        public String Telefon { get { return (String)GetValue(TelefonProperty); } set { SetValue(TelefonProperty, value); } }
        public static readonly DependencyProperty TelefonProperty = DependencyProperty.Register("Telefon", typeof(string), typeof(OdobriParkingElement), new PropertyMetadata(""));

        public String EMail { get { return (String)GetValue(EmailProperty); } set { SetValue(EmailProperty, value); } }
        public static readonly DependencyProperty EmailProperty = DependencyProperty.Register("EMail", typeof(string), typeof(OdobriParkingElement), new PropertyMetadata(""));


    }
}
