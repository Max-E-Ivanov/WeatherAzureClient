using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.DALInteraface;

namespace Weather.DALInteraface
{
    public class WeatherAPI_1 : WeatherAPI
    {
        public AlmanacDetails GetAlmanacWeather(string sCountry, string sCity, string sLang)
        {
            throw new NotImplementedException();
        }

        public WeatherDetails GetCurrentWeather(string sCountry, string sCity, string sLang)
        {
            try
            {
                using (WeatherDAL.WeatherServiceReference.WeatherServiceClient _client = new WeatherDAL.WeatherServiceReference.WeatherServiceClient())
                {
                    _client.Open();

                    WeatherDAL.WeatherServiceReference.WeatherDetails _detailsService = _client.GetCurrentWeather(sCountry, sCity, sLang);

                    //From autugenerated object to our object

                    WeatherDetails _wd = new WeatherDetails();
                    _wd.feelslike_c = _detailsService.feelslike_c;
                    _wd.feelslike_f = _detailsService.feelslike_f;
                    _wd.icon_url = _detailsService.icon_url;
                    _wd.local_time_rfc822 = _detailsService.local_time_rfc822;
                    _wd.observation_time = _detailsService.observation_time;
                    _wd.pressure_mb = _detailsService.pressure_mb;
                    _wd.relative_humidity = _detailsService.relative_humidity;
                    _wd.solarradiation = _detailsService.solarradiation;
                    _wd.temp_c = _detailsService.temp_c;
                    _wd.temp_f = _detailsService.temp_f;
                    _wd.UV = _detailsService.UV;
                    _wd.visibility_km = _detailsService.visibility_km;
                    _wd.visibility_mi = _detailsService.visibility_mi;
                    _wd.weather = _detailsService.weather;
                    _wd.wind_dir = _detailsService.wind_dir;
                    _wd.wind_kph = _detailsService.wind_kph;
                    _wd.observation_time_rfc822 = _detailsService.observation_time_rfc822;

                    _wd.observation_location = new Location();
                    _wd.observation_location.city = _detailsService.observation_location.city;
                    _wd.observation_location.country = _detailsService.observation_location.country;
                    _wd.observation_location.elevation = _detailsService.observation_location.elevation;
                    _wd.observation_location.latitude = _detailsService.observation_location.latitude;
                    _wd.observation_location.longitude = _detailsService.observation_location.longitude;
                    _wd.observation_location.state = _detailsService.observation_location.state;

                    _client.Close();
                    return _wd;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
