using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.DALInteraface;
using Weather.UIInterface;

namespace Weather.WeatherController
{
    public static class WeatherController
    {
        static WeatherAPI _weatherProvider;
        public static WeatherAPI weatherProvider
        {
            get
            {
                return _weatherProvider;
            }

            set
            {
                _weatherProvider = value;
            }
        }

        static WeatherUIInterface _weatherUIProvider;
        public static WeatherUIInterface weatherUIProvider
        {
            get
            {
                return _weatherUIProvider;
            }

            set
            {
                _weatherUIProvider = value;
            }
        }
    }
}
