using System.Text.Json;
using Shared.Models;

namespace Client.Services;

public class SubscriptionService
{
    private readonly HttpClient _httpClient;

    public SubscriptionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    
    public async Task<List<Subscription>?> GetSubscriptions()
    {
        var response = await _httpClient.GetAsync("api/Subscription");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Subscription>>(content);
    }
}