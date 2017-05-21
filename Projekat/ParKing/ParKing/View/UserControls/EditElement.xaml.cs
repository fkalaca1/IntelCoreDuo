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
    public sealed partial class EditElement : UserControl
    {
        public EditElement()
        {
            this.InitializeComponent();
        }
        public String PropertyTextBox { get { return (String)GetValue(TextBoxTextProperty); } set { SetValue(TextBoxTextProperty, value); } }
        public String PropertyTextBlock { get { return (String)GetValue(TextBlockTextProperty); } set { SetValue(TextBlockTextProperty, value); } }
        public static readonly DependencyProperty TextBlockTextProperty = DependencyProperty.Register("PropertyTextBlock", typeof(string), typeof(EditElement), new PropertyMetadata(""));
        public static readonly DependencyProperty TextBoxTextProperty = DependencyProperty.Register("PropertyTextBox", typeof(string), typeof(EditElement), new PropertyMetadata(""));
    }
}
