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
    public sealed partial class UserElement : UserControl
    {
        public UserElement()
        {
            this.InitializeComponent();
        }
        public String MailTextBlock { get { return (String)GetValue(MailTextBlockProperty); } set { SetValue(MailTextBlockProperty, value); } }
        public static readonly DependencyProperty MailTextBlockProperty = DependencyProperty.Register("MailTextBlock", typeof(string), typeof(UserElement), new PropertyMetadata(""));
    }
}
