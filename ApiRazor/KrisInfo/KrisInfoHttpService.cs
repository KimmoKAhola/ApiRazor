using System.Net.Http.Headers;
using System.Text.Json;
using ApiRazor.KrisInfo;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ApiRazor;

public class KrisInfoHttpService : IHttpService<KrisInfoRoot>
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions =
        new() { PropertyNameCaseInsensitive = true };

    public KrisInfoHttpService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<KrisInfoRoot> Get(int id)
    {
        var httpResponseMessage = await _httpClient.GetAsync($"{id}");
        try
        {
            httpResponseMessage.EnsureSuccessStatusCode();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }

        var jsonContent = await httpResponseMessage.Content.ReadAsStringAsync();
        var blogpost = JsonSerializer.Deserialize<KrisInfoRoot>(jsonContent, _jsonOptions);
        return blogpost;
    }

    public Task<KrisInfoRoot> Get(string id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<KrisInfoRoot>> GetAll(int numberOfDays)
    {
        var httpResponseMessage = await _httpClient.GetAsync($"?days={numberOfDays}");
        try
        {
            httpResponseMessage.EnsureSuccessStatusCode();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        var jsonContent = await httpResponseMessage.Content.ReadAsStringAsync();
        var blogPosts = JsonSerializer.Deserialize<List<KrisInfoRoot>>(jsonContent, _jsonOptions);
        return blogPosts;
    }

    public Task<KrisInfoRoot> GetAll()
    {
        throw new NotImplementedException();
    }
}