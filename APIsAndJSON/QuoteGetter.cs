using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class QuoteGetter
{
    private readonly HttpClient _client;

    public QuoteGetter(HttpClient client)
    {
        _client = client;
    }

    
    public string KanyeQuote()
    {
        var kanyeURL = "https://api.kanye.rest/";
        var kanyeResponse = _client.GetStringAsync(kanyeURL).Result;
        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        return kanyeQuote;
    }

    public string RonQuote()
    {
        var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        var ronResponse = _client.GetStringAsync(ronUrl).Result;
        var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        return ronQuote;
    }
}