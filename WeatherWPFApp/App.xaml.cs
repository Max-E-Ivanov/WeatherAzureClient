using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Markup;
using System.Globalization;
using Weather.WeatherController;
using Weather.DALInteraface;
using Weather.UIInterface;

namespace WeatherWPFApp
{ 
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Подсунем текущую культуру ибо впф по умолчанию всего берет en-US
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            /* FrameworkElement.LanguageProperty.OverrideMetadata(
                 typeof(FrameworkElement),
                 new FrameworkPropertyMetadata(
                     XmlLanguage.GetLanguage(
                     CultureInfo.CurrentCulture.IetfLanguageTag)));*/

            FrameworkElement.LanguageProperty.OverrideMetadata(
                 typeof(FrameworkElement),
                 new FrameworkPropertyMetadata(
                     XmlLanguage.GetLanguage(
                     "ru-RU")));
            System.Threading.Thread.CurrentThread.CurrentUICulture =
            new System.Globalization.CultureInfo("uk-UA");


            // Кто у нас будет предоставлять погоду и методы визуального интерфейса
            WeatherController.weatherProvider = new WeatherAPI_1();
            WeatherController.weatherUIProvider = new WeatherUI_wpf();


            base.OnStartup(e);
        }
    }
}
