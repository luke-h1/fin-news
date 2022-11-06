using Newtonsoft.Json;

namespace fin_news.Models
{
    public class Pagination
    {
        [JsonProperty("limit")] public int Limit { get; set; }

        [JsonProperty("offset")] public int Offset { get; set; }

        [JsonProperty("count")] public int Count { get; set; }

        [JsonProperty("total")] public int Total { get; set; }
    }

    public class NewsArticle
    {
        [JsonProperty("title")] public string Title { get; set; } = string.Empty;

        [JsonProperty("url")] public string Url { get; set; } = string.Empty;

        [JsonProperty("description")] public string Description { get; set; } = string.Empty;

        [JsonProperty("source")] public string Source { get; set; } = string.Empty;

        [JsonProperty("tickers")] public List<string> Tickers { get; set; } = new List<string>();

        [JsonProperty("tags")] public List<string> Tags { get; set; } = new List<string>();

        [JsonProperty("published_at")] public DateTime PublishedAt { get; set; }
    }

    public class FinanceNews
    {
        [JsonProperty("pagination")] public Pagination Pagination { get; set; } = new Pagination();

        [JsonProperty("data")] public List<NewsArticle> Data { get; set; } = new List<NewsArticle>();
    }
}