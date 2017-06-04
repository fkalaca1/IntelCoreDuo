using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
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
    public sealed partial class EditElement : UserControl
    {
        public EditElement()
        {
            this.InitializeComponent();
        }
        public String PropertyTextBox { get { return (String)GetValue(TextBoxTextProperty); } set { SetValue(TextBoxTextProperty, value); } }
        public static readonly DependencyProperty TextBoxTextProperty = DependencyProperty.Register("PropertyTextBox", typeof(string), typeof(EditElement), new PropertyMetadata(""));
        public String PropertyTextBlock { get { return (String)GetValue(TextBlockTextProperty); } set { SetValue(TextBlockTextProperty, value); } }
        public static readonly DependencyProperty TextBlockTextProperty = DependencyProperty.Register("PropertyTextBlock", typeof(string), typeof(EditElement), new PropertyMetadata(""));
        public String HyperLinkContent { get { return (String)GetValue(HyperLinkContentProperty); } set { SetValue(HyperLinkContentProperty, value); } }
        public static readonly DependencyProperty HyperLinkContentProperty = DependencyProperty.Register("HyperLinkContent", typeof(string), typeof(EditElement), new PropertyMetadata(""));
        public bool EditProperty { get { return (bool)GetValue(EditPropertyProperty); } set { SetValue(EditPropertyProperty, value); } }
        public static readonly DependencyProperty EditPropertyProperty = DependencyProperty.Register("EditProperty", typeof(bool), typeof(EditElement), new PropertyMetadata(""));
        public ICommand EditLinkClick { get { return (ICommand)GetValue(EditLinkClickProperty); } set { SetValue(EditLinkClickProperty, value); } }
        public static readonly DependencyProperty EditLinkClickProperty = DependencyProperty.Register("EditLinkClick", typeof(ICommand), typeof(EditElement), new PropertyMetadata(""));
    }
}
