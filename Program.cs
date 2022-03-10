using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Text;

namespace InterviewChallenge
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                var info_challenge = new Uri("https://si-interview-api.azurewebsites.net/api/Information/Challenge");
                var result1 = client.GetAsync(info_challenge).Result.Content.ReadAsStringAsync().Result;

                var weather_forecast_get = new Uri("https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast");
                var result2 = client.GetAsync(weather_forecast_get).Result.Content.ReadAsStringAsync().Result;

                var weather_forecast_location = new Uri("https://si-interview-api.azurewebsites.net/api/WeatherForecast/WeatherForecast/salt%20lake%20city");
                var result3 = client.GetAsync(weather_forecast_location).Result.Content.ReadAsStringAsync().Result;


            }
        }


    }
}
