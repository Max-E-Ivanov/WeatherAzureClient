using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.DALInteraface
{
    public interface WeatherAPI
    {
       
        WeatherDetails GetCurrentWeather(string sCountry, string sCity, string sLang);

      
        AlmanacDetails GetAlmanacWeather(string sCountry, string sCity, string sLang);
    }
}
