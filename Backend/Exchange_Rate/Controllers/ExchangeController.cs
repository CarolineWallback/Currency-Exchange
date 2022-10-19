using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Exchange_Rate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeController : Controller
    {
        // GET: ExchangeController
        [HttpGet]
        public double GetRate()
        {
            var client = new RestClient ("https://api.apilayer.com/exchangerates_data/latest?symbols=EUR&base=SEK");
            var request = new RestRequest();
            
            request.AddHeader("apikey", "bMx139OuNJfzGTPDcDMyD0Z3hBdMPoVP");

            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };

            var response = client.ExecuteGetAsync(request).GetAwaiter().GetResult();
            if (response != null)
            {
                JsonTextReader reader = new JsonTextReader(new StringReader(response.Content));
                JsonSerializer se = new JsonSerializer();
                ExchangeRate exchangeRate = se.Deserialize<ExchangeRate>(reader);

                return exchangeRate.rates.EUR;
            }
            else
                return 0;
        }
    }
}
