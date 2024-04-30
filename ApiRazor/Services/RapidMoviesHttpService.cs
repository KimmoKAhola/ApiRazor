using System.Text.Json;
using ApiRazor.KrisInfo;
using ApiRazor.RapidMovies;

namespace ApiRazor.Services;

public class RapidMoviesHttpService : IHttpService<MoviesRoot>
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonOptions =
        new() { PropertyNameCaseInsensitive = true };

    public RapidMoviesHttpService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<MoviesRoot> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<MoviesRoot> Get(string id)
    {
        var httpResponseMessage = await _httpClient.GetAsync(id);
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
        var listOfAllMovies = JsonSerializer.Deserialize<MoviesRoot>(jsonContent, _jsonOptions);
        return listOfAllMovies;
    }

    public async Task<List<MoviesRoot>> GetAll(int numberOfDays)
    {
        var httpResponseMessage = await _httpClient.GetAsync($"/titles");
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
        var listOfAllMovies = JsonSerializer.Deserialize<List<MoviesRoot>>(jsonContent, _jsonOptions);
        return listOfAllMovies;
    }
    
    public async Task<MoviesRoot> GetAll()
    {
        var httpResponseMessage = await _httpClient.GetAsync($"/titles");
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
        var listOfAllMovies = JsonSerializer.Deserialize<MoviesRoot>(jsonContent, _jsonOptions);
        return listOfAllMovies;
    }
}