using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forciner.Web.Pages;

public class BadPageModel : PageModel
{
    private readonly ILogger<BadPageModel> _logger;

    public BadPageModel(ILogger<BadPageModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        _logger.LogError("You have reached the Bad Page.");
        throw new Exception("This is the Bad Page. It always throws.");
    }
}
