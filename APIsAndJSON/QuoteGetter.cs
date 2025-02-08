using Newtonsoft.Json.Linq;

namespace APIsAndJSON;

public class QuoteGetter
{
   
    
    public string KanyeQuote()
    {
        var client = new HttpClient();
        var kanyeURL = "https://api.kanye.rest/";
        var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        return kanyeQuote;
    }

    public string RonQuote()
    {
        var client = new HttpClient();
        var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        var ronResponse = client.GetStringAsync(ronUrl).Result;
        var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        return ronQuote;
    }
}