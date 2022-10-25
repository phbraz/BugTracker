using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugTrackerProject.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly SignInManager<IdentityUser> _signInManager;

    public IndexModel(ILogger<IndexModel> logger, SignInManager<IdentityUser> signInManager)
    {
        _logger = logger;
        _signInManager = signInManager;
    }

    public IActionResult OnGet()
    {
        if (_signInManager.IsSignedIn(User))
        {
            return RedirectToPage("Issues/Index");
        }

        return Page();
    }
}