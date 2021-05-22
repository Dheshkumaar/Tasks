using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Weather
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public DateTime Date { get; set; }
        public double highTemp { get; set; }
        public double lowTemp { get; set; }
        public string Forecast { get; set; }
    }
}
