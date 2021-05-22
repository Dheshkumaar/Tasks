using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class WeatherContext:DbContext
    {
        public WeatherContext()
        {
        }
        public WeatherContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Weather> Weathers { get; set; }
    }
}
