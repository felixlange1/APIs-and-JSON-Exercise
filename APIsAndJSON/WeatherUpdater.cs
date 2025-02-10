using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class WeatherUpdater
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public WeatherUpdater(HttpClient httpClient, string apiKey)
    {
        _httpClient = httpClient;
        _apiKey = apiKey;
    }
    
    
    
    public void CurrentWeather(string city)
    {
        var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=imperial";
        var response = _httpClient.GetStringAsync(weatherURL).Result;
        var temp =  Math.Round(JObject.Parse(response)["main"]["temp"].Value<double>());
        
        Console.WriteLine($"The current temperature in {city} is {temp} degrees Fahrenheit");
    }
    
}