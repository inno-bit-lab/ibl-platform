using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Shared.Models;
using Shared.Utils;
using System.Net;

namespace Api.Functions
{
    public class WeatherForecastFunction
    {
        private readonly ILogger<WeatherForecastFunction> _logger;

        public WeatherForecastFunction(ILogger<WeatherForecastFunction> logger)
        {
            _logger = logger;
        }

        [Function("WeatherForecast")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var randomNumber = new Random();
            var temp = 0;

            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = temp = randomNumber.Next(-20, 55),
                Summary = TemperatureConverter.GetSummary(temp)
            }).ToArray();

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(result);
            return response;
        }



    }
}
