using fin_news.Models;

namespace fin_news.Services;

public interface INewsService
{
    FinanceNews GetFinanceNews();
}