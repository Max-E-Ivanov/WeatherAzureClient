using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.DALInteraface
{

    public enum enumTemp {eC, eF }
    public enum enumSpeed { eKH, eMH }

    public class WeatherSettings
    {
        public enumTemp eeTemp
        {
            get;set;
        }

        public enumSpeed eeSpeed
        {
            get; set;
        }

    }

    #region Current weather

    public class WeatherDetails
    {
        public WeatherDetails()
        { }
        
        public string observation_time { get; set; }
        
        public Location observation_location { get; set; }
      
        public string local_time_rfc822 { get; set; }
        public DateTime local_time_typed
        {
            get
            {
                return DateTime.Parse(local_time_rfc822);
            }
        }
       
        public string observation_time_rfc822 { get; set; }
        public DateTime observation_time_typed
        {
            get
            {
                return DateTime.Parse(observation_time_rfc822);
            }
        }
       
        public string weather { get; set; }
      
        public double temp_f { get; set; }
       
        public double temp_c { get; set; }
       
        public string relative_humidity { get; set; }
       
        public string wind_dir { get; set; }
       
        public double wind_kph { get; set; }
      
        public double pressure_mb { get; set; }
        
        public double feelslike_f { get; set; }
        
        public double feelslike_c { get; set; }
       
        public double visibility_mi { get; set; }
        
        public double visibility_km { get; set; }
       
        public string solarradiation { get; set; }
       
        public double UV { get; set; }
       
        public string icon_url { get; set; }
    }

   
    public class Location
    {
        public Location()
        { }
       
        public string country { get; set; }
       
        public string city { get; set; }
       
        public string state { get; set; }
       
        public double latitude { get; set; }
        
        public double longitude { get; set; }
       
        public string elevation { get; set; }
    }
    #endregion

    #region MinMax weather
 
 
    public class AlmanacDetails
    {
        public AlmanacDetails()
        { }
       
        public string airport_code { get; set; }
      
        public AlmanacRecord temp_high { get; set; }
       
        public AlmanacRecord temp_low { get; set; }
    }

   
    public class AlmanacRecord
    {
        public AlmanacRecord()
        { }
      
        public Record normal { get; set; }
    
        public Record record { get; set; }
      
        public int recordyear { get; set; }
    }

 
    public class Record
    {
        public Record()
        { }
       
        public double F { get; set; }
       
        public double C { get; set; }
    }
    #endregion
}
