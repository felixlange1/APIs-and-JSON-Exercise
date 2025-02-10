using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace APIsAndJSON
{
    public class Program
    {

        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            string apiKey = config["ApiSettings:ApiKey"];
            

            HttpClient connection = new HttpClient();


            var currentTemp = new WeatherUpdater(connection, apiKey);

            Console.WriteLine("Please enter the city you would like the current temperature for:");
            var city = Console.ReadLine();
            
            currentTemp.CurrentWeather(city);

            Console.WriteLine("-----------------------------------");
            
            var quoteGetter = new QuoteGetter(connection);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kanye: " + quoteGetter.KanyeQuote());
                Console.WriteLine("Ron: " + quoteGetter.RonQuote());
            }











        }
    }
}
