using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dotNetProjekt.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Weather.xaml
    /// </summary>
    public partial class Weather : UserControl
    {
        public Weather()
        {
            InitializeComponent();
            getWeather("Wrocław");
            getForecast("Wrocław");
        }

        void getWeather(string city)
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid=c673e9ca6ed3280af36b5fd5888246e2&units=metric&cnt=6", city);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                WeatherInfo.root output = result;

                textBoxCityName.Text = string.Format("{0}", output.name);
                textBoxCountry.Text = string.Format("{0}", output.sys.country);
                textBoxTemp.Text = string.Format("{0} \u00B0" + "C", output.main.temp);
            }
        }

        void getForecast(string city)
        {
            int day = 17;
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&appid=c673e9ca6ed3280af36b5fd5888246e2&units=metric&cnt={1}", city, day);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherForecast>(json);

                WeatherForecast forecast = result;

                tbDay1.Text = string.Format("{0}", getDate(forecast.list[8].dt).DayOfWeek);
                tbCond1.Text = string.Format("{0}", forecast.list[8].weather[0].main);
                tbDes1.Text = string.Format("{0}", forecast.list[8].weather[0].description);
                tbTemp1.Text = string.Format("{0}  \u00B0" + "C", forecast.list[8].main.temp);
                tbWind1.Text = string.Format("{0} km/h", forecast.list[8].wind.speed);

                tbDay2.Text = string.Format("{0}", getDate(forecast.list[16].dt).DayOfWeek);
                tbCond2.Text = string.Format("{0}", forecast.list[16].weather[0].main);
                tbDes2.Text = string.Format("{0}", forecast.list[16].weather[0].description);
                tbTemp2.Text = string.Format("{0}  \u00B0" + "C", forecast.list[16].main.temp);
                tbWind2.Text = string.Format("{0} km/h", forecast.list[16].wind.speed);

            }
        }

        DateTime getDate(double milisec)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milisec).ToLocalTime();

            return day;
        }
    }
}
