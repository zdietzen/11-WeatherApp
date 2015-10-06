using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Classes
{
    class CurrentConditions
    {
        public string elevation { get; set; }
        public string lon { get; set; }
        public string lat { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string temperature_string { get; set; }
        public string feelslike_string { get; set; }
        public string wind_string { get; set; }
        public string wind_dir { get; set; }
        public string relative_humidity { get; set; }
        public string visibility_mi { get; set; }
        public string precip_today_string { get; set; }
        public string weather { get; set; }
        public string UV { get; set; }
    }
}
