using fin_news.Models;
using Newtonsoft.Json;

namespace fin_news.Services;

public class NewsService : INewsService
{
    private readonly IConfiguration _configuration;

    public NewsService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public FinanceNews GetFinanceNews()
    {
        var apiKey = _configuration.GetValue<string>("API_KEY");
        var baseUrl = _configuration.GetValue<string>("API_URL");

        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseUrl);
        var response = client.GetAsync("?apikey=" + apiKey).Result;

        if (response.IsSuccessStatusCode)
        {
            var result = response.Content.ReadAsStringAsync().Result;
            var news = JsonConvert.DeserializeObject<FinanceNews>(result);
            if (news != null) return news;
        }
        else
        {
            return new FinanceNews()
            {
                Data = new List<NewsArticle>(),
                Pagination = new Pagination(),
            };
        }

        return null!;
    }
}