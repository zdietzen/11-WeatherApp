using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApp.Classes;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // should we add this?----> public static CurrentConditions currentconditions;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

            string zip = SearchBar.Text;

            using (WebClient webClient = new WebClient())


            {
                //Tells the Weather Underground API who's boss
                webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                // Grabs json info from github and saves it to a string.
                string json = webClient.DownloadString("http://api.wunderground.com/api/a3bf043be8c7fc4a/geolookup/conditions/q/" + zip + ".json");

                //this converts the json info into usable information for us
                var o = JObject.Parse(json);

                var CurrentObservation = o["current_observation"];

                //This stores the information that was converted to strings
                string Weather = CurrentObservation["weather"].ToString();
                string Elevation = CurrentObservation["display_location"]["elevation"].ToString();
                string Longitude = CurrentObservation["display_location"]["longitude"].ToString();
                string Latitude = CurrentObservation["display_location"]["latitude"].ToString();
                string LocationState = CurrentObservation["display_location"]["state"].ToString();
                string LocationCity = CurrentObservation["display_location"]["city"].ToString();
                string Temperature = CurrentObservation["temperature_string"].ToString();
                string FeelsLike = CurrentObservation["feelslike_string"].ToString();
                string Wind = CurrentObservation["wind_string"].ToString();
                string WindDirection = CurrentObservation["wind_dir"].ToString();
                string Humidity = CurrentObservation["relative_humidity"].ToString();
                string UV = CurrentObservation["UV"].ToString();
                string Visibility = CurrentObservation["visibility_mi"].ToString();
                string Percipitation = CurrentObservation["precip_today_string"].ToString();

                // writes the information out to the console


                // writes the information out to the console
                TWind.Text = Wind;
                TWeather.Text = Weather;
                TElevation.Text = Elevation;
                TLatitude.Text = Latitude;
                TLongitude.Text = Longitude;
                TCity.Text = LocationCity;
                TTemperature.Text = Temperature;
                TFeelsLike.Text = FeelsLike;
                TWind.Text = Wind;
                TWindDirection.Text = WindDirection;
                THumidity.Text = Humidity;
                TUV.Text = UV;
                TVisibility.Text = Visibility;
                TPrecipitation.Text = Percipitation;


            }
        }
    }

}