using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Utils.UI;
using Weather.DALInteraface;
using Weather.WeatherController;

namespace Weather.ViewModels
{
    public class WeatherMainPageVM :BaseViewModels
    {

        public WeatherMainPageVM()
        {
            _settings = new WeatherSettings();
        }

        string sSelectedCountry;
        public string SelectedCountry
        {
            get
            {
                return sSelectedCountry;
            }

            set
            {
                sSelectedCountry = value;
                GetWeather();
                NotifyPropertyChanged("SelectedCountry");
            }
        }

        string sSelectedCity;
        public string SelectedCity
        {
            get
            {
                return sSelectedCity;
            }

            set
            {
                sSelectedCity = value;

                GetWeather();
                NotifyPropertyChanged("SelectedCity");
            }
        }

        WeatherDetails _wd;

        public string CityCoordinates
        {
            get
            {
                if ((_wd == null) || (_wd.observation_location == null))
                    return "--";

                return _wd.observation_location.latitude + "°, " + _wd.observation_location.longitude + "°, " + _wd.observation_location.elevation;
            }
        
        }


        WeatherSettings _settings;
        public WeatherSettings settings
        {
            get
            {
                return _settings;
            }
        }

        WeatherCurrentVM _weatherCurrentVM;
        public WeatherCurrentVM weatherCurrentVM
        {
            get
            {
                return _weatherCurrentVM;
            }
        }

        void GetWeather()
        {
            try
            {
                if (string.IsNullOrEmpty(SelectedCity) || (string.IsNullOrEmpty(SelectedCountry)))
                    return;

                WeatherController.WeatherController.weatherUIProvider.SetWaitCursor(true);

                // Current weather
                _wd = WeatherController.WeatherController.weatherProvider.GetCurrentWeather(SelectedCountry, SelectedCity, string.Empty);
                _weatherCurrentVM = new WeatherCurrentVM(_wd, settings);
                NotifyPropertyChanged("weatherCurrentVM");
                NotifyPropertyChanged("CityCoordinates");


                WeatherController.WeatherController.weatherUIProvider.SetWaitCursor(false);
            }
            catch (Exception ex)
            {
                WeatherController.WeatherController.weatherUIProvider.SetWaitCursor(false);
                WeatherController.WeatherController.weatherUIProvider.ShowErrorMessage(ex.Message);
            }
        }
    }
}
