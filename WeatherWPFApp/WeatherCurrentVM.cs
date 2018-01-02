using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Utils.UI;
using Weather.DALInteraface;

namespace Weather.ViewModels
{
    public class WeatherCurrentVM
    {
        public WeatherCurrentVM(WeatherDetails _weatherDetails, WeatherSettings _settings)
        {
            this._weatherDetails = _weatherDetails;
            this._settings = _settings;
        }

        WeatherSettings _settings;

        WeatherDetails _weatherDetails;
        public WeatherDetails weatherDetails
        {
            get
            {
                return _weatherDetails;
            }
        }

        string TempSymbol
        {
            get
            {
                switch (_settings.eeTemp)
                {
                    case enumTemp.eC:
                        return "C";

                    case enumTemp.eF:
                        return "F";

                }

                return string.Empty;
            }
        }

        string SpeedSymbol
        {
            get
            {
                switch (_settings.eeSpeed)
                {
                    case enumSpeed.eKH:
                        return "km/h";

                    case enumSpeed.eMH:
                        return "mi/h";

                }

                return string.Empty;
            }
        }

        string DistanceSymbol
        {
            get
            {
                switch (_settings.eeSpeed)
                {
                    case enumSpeed.eKH:
                        return "km";

                    case enumSpeed.eMH:
                        return "mi";

                }

                return string.Empty;
            }
        }

        public string Temp
        {
            get
            {
                switch (_settings.eeTemp)
                {
                    case enumTemp.eC:
                        return  weatherDetails.temp_c + TempSymbol;

                    case enumTemp.eF:
                        return weatherDetails.temp_f + TempSymbol;

                }

                return string.Empty;
            }
        }

        public string Feel
        {
            get
            {
                switch (_settings.eeTemp)
                {
                    case enumTemp.eC:
                        return weatherDetails.feelslike_c + TempSymbol;

                    case enumTemp.eF:
                        return weatherDetails.feelslike_f + TempSymbol;

                }

                return string.Empty;
            }
        }

        public string Visibility
        {
            get
            {
                switch (_settings.eeSpeed)
                {
                    case enumSpeed.eKH:
                        return weatherDetails.visibility_km + DistanceSymbol;

                    case enumSpeed.eMH:
                        return weatherDetails.visibility_mi+ DistanceSymbol;

                }

                return string.Empty;
            }
        }


    }

   
}
