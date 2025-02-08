using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        
    static void Main(string[] args)
        {
            var quoteGetter = new QuoteGetter();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kanye: " + quoteGetter.KanyeQuote());
                Console.WriteLine("Ron: " + quoteGetter.RonQuote());
            }
            
            
        
    
          
            
            
            
            
            
            
        }
    }
}
