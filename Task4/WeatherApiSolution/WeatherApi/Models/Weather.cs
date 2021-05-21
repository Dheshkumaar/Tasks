using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApi
{
    public class Weather
    {
        [Key] 
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double highTemp { get; set; }
        public double lowTemp { get; set; }
        public string Forecast { get; set; }
    }
}
