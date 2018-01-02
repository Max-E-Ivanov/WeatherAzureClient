using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Weather.UIInterface
{
    public class WeatherUI_wpf : WeatherUIInterface
    {
        public void ShowErrorMessage(string sText)
        {
            MessageBox.Show(sText, WeatherWPFApp.Properties.Resources.ErrorCaption, MessageBoxButton.OK, MessageBoxImage.Stop);
        }

        public void SetWaitCursor(bool bWait)
        {
            //if (System.Threading.Thread.CurrentThread.GetApartmentState() == ApartmentState.STA)
            Mouse.OverrideCursor = bWait ? Cursors.Wait : null;
        }
    }
}
