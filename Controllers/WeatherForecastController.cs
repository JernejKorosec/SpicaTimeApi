using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace angular.net6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            HttpRequestMessage request = new HttpRequestMessage();
            HttpClient httpClient = new HttpClient();
            
            RequestCredential requestCredential = new RequestCredential();

            requestCredential.Token = "";
            requestCredential.TokenTimeStamp = DateTime.Now;


            //httpClient.

            String apiKey = "http://rdweb.spica.com:5213/timeapi";

            /*
                User: demo
                Pass: demo
                API GUID: 87F262C4-7FA6-46D3-880D-2F7E15B4F204
                http://rdweb.spica.com:5213/timeapi, 
            */

            AuthenticationHeaderValue t = GenerateClientAuthorizationHeader(request, httpClient, requestCredential, apiKey);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        public static AuthenticationHeaderValue GenerateClientAuthorizationHeader( 
            HttpRequestMessage request, 
            HttpClient httpClient, 
            RequestCredential requestCredential, 
            string apiKey)
        {
            if (httpClient.DefaultRequestHeaders.Authorization.Scheme == TokenAuthentication.Scheme 
                && httpClient.DefaultRequestHeaders.Authorization.Parameter != null)

                if (requestCredential != null)
                {
                    return new AuthenticationHeaderValue (TokenAuthentication.Scheme, string.Format("{0}:{1}", apiKey, requestCredential.Token));
                }
            return new AuthenticationHeaderValue (TokenAuthentication.Scheme, apiKey);
        }

        public class RequestCredential
        {
            public DateTime TokenTimeStamp { get; set; }
            public string Token { get; set; }
        }

        public static class TokenAuthentication
        {
            public static string Scheme { get; set; }
        }


    }
}