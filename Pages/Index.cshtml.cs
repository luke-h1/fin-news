using fin_news.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace fin_news.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly INewsService _newsService;

    public IndexModel(ILogger<IndexModel> logger, INewsService newsService)
    {
        _logger = logger;
        _newsService = newsService;
    }

    public void OnGet()
    {
        _newsService.GetFinanceNews();
    }
}