using System.Diagnostics;
using System.Net;
using JsonFlatFileDataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Shared.Models;
using static System.Formats.Asn1.AsnWriter;

namespace Api.Functions
{
    public class SubscriptionFunction
    {
        private readonly ILogger<SubscriptionFunction> _logger;
        private DataStore subscriptionStore;

        public SubscriptionFunction(ILogger<SubscriptionFunction> logger)
        {
            _logger = logger;
            subscriptionStore = new DataStore("./data/Subscription.json");
        }

        [Function("Subscription")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            
            var subscriptions = subscriptionStore.GetCollection<Subscription>().AsQueryable().ToList();
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.WriteAsJsonAsync(subscriptions);
            return response;            
        }
    }
}
