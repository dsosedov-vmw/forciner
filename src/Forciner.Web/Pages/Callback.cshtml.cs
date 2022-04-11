using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Forciner.Web.Pages;

[Authorize]
[IgnoreAntiforgeryToken]
public class CallbackModel : PageModel
{
    private readonly ILogger<CallbackModel> _logger;

    public CallbackModel(ILogger<CallbackModel> logger)
    {
        _logger = logger;
    }

    public IActionResult OnPost()
    {
        return Redirect("/");
    }
}
