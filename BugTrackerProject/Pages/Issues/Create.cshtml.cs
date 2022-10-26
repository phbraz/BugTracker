using BugTrackerProject.Data;
using BugTrackerProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugTrackerProject.Pages.Issues;

public class Create : PageModel
{
    private readonly ApplicationDbContext _dbContext;
    private readonly SignInManager<IdentityUser> _signInManager;

    public Create(ApplicationDbContext dbContext, SignInManager<IdentityUser> signInManager)
    {
        _dbContext = dbContext;
        _signInManager = signInManager;
    }
    
    [BindProperty] public IssueList Issue { get; set; }
    
    public void OnGet()
    {
        
    }

    public ActionResult OnPost()
    {
        var maxId = _dbContext.Issues.Max(x => x.Id);
        
        Issue.IsActive = true;
        Issue.CreatedDate = DateTime.UtcNow;
        Issue.Reporter = _signInManager.UserManager.GetUserName(User);
        Issue.TicketNumber = $"BT-0{maxId}";
        Issue.Status = 0;

        _dbContext.Issues.Add(Issue);

        _dbContext.SaveChanges();

        return RedirectToPage("/Issues/Index");



    } 
}