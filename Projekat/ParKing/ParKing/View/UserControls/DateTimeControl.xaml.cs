using ParKing.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class DateTimeControl : UserControl
    {
        private DateTime dateTimeOd;
        private DateTime dateOd;

        private DateTime dateTimeDo;
        private DateTime dateDo;
        public String RezervisanoOd { get { return (String)GetValue(OdTextBlockProperty); } set { SetValue(OdTextBlockProperty, value); } }
        public static readonly DependencyProperty OdTextBlockProperty = DependencyProperty.Register("RezervisanoOd", typeof(string), typeof(DateTimeControl), new PropertyMetadata(""));

        public String RezervisanoDo { get { return (String)GetValue(DoTextBlockProperty); } set { SetValue(DoTextBlockProperty, value); } }
        public static readonly DependencyProperty DoTextBlockProperty = DependencyProperty.Register("RezervisanoDo", typeof(string), typeof(DateTimeControl), new PropertyMetadata(""));
        public DateTimeControl()
        {
            this.InitializeComponent();
            RezervisanoOd = String.Format("{0:d MMMM yyyy, HH:mm}", DateTime.Now);
            RezervisanoDo = String.Format("{0:d MMMM yyyy, HH:mm}", DateTime.Now.AddHours(1.0));
            dateTimeOd = DateTime.Now;
            dateTimeDo = DateTime.Now.AddHours(1.0);
        }

        private void DatePickerFlyout_DatePicked(DatePickerFlyout sender, DatePickedEventArgs args)
        {
            var dateTimePicker = sender;

            var timepicker = new TimePickerFlyout();
            timepicker.Placement = FlyoutPlacementMode.Full;
            
            timepicker.ShowAt(OdButton);

            dateOd = new DateTime(dateTimePicker.Date.Year, dateTimePicker.Date.Month, dateTimePicker.Date.Day, 0, 0, 0);
            timepicker.TimePicked += Timepicker_TimePicked;

        }

        private void Timepicker_TimePicked(TimePickerFlyout sender, TimePickedEventArgs args)
        {
            var timePicker = sender;

            dateTimeOd = new DateTime(dateOd.Year, dateOd.Month, dateOd.Day, timePicker.Time.Hours, timePicker.Time.Minutes, 0);
            RezervisanoOd = String.Format("{0:d MMMM yyyy, HH:mm}", dateTimeOd);
        }

        private void DoDatePickerFlyout_DatePicked(DatePickerFlyout sender, DatePickedEventArgs args)
        {
            var dateTimePicker = sender;

            var secondTimepicker = new TimePickerFlyout();
            secondTimepicker.Placement = FlyoutPlacementMode.Full;
            secondTimepicker.ShowAt(OdButton);

            dateDo = new DateTime(dateTimePicker.Date.Year, dateTimePicker.Date.Month, dateTimePicker.Date.Day, 0, 0, 0);
            secondTimepicker.TimePicked += SecondTimepicker_TimePicked;
        }

        private void SecondTimepicker_TimePicked(TimePickerFlyout sender, TimePickedEventArgs args)
        {
            var timePicker = sender;

            dateTimeDo = new DateTime(dateDo.Year, dateDo.Month, dateDo.Day, timePicker.Time.Hours, timePicker.Time.Minutes, 0);
            if (dateTimeOd.CompareTo(dateTimeDo) >= 0)
            {
                string s = "Pogresan datum rezervacije! Izaberite ponovo";
                Validacija.message(s, "Greska");
            }
            RezervisanoDo = String.Format("{0:d MMMM yyyy, HH:mm}", dateTimeDo);
        }
    }
}
