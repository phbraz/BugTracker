using BugTrackerProject.Data;
using BugTrackerProject.DTOs.Issues;
using BugTrackerProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugTrackerProject.Pages.Issues;

public class Details : PageModel
{
    private readonly ApplicationDbContext _dbContext;

    public Details(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<IssueDetailsDto>  Issue;

    [BindProperty] public IssueList IssueInput { get; set; }

    public void OnGet(int id)
    {

        Issue = _dbContext.Issues.Select(x => new IssueDetailsDto()
        {
            Id = x.Id,
            Reporter = x.Reporter,
            Description = x.Description,
            Status = x.Status,
            Title = x.Title,
            CreatedDate = x.CreatedDate,
            TicketNumber = x.TicketNumber
        }).Where(x => x.Id == id);
    }

    public ActionResult OnPostDelete(int id)
    {
        var issue = _dbContext.Issues.FirstOrDefault(x => x.Id == id);
        
        if (issue == null)
        {
            return NotFound();
        }

        issue.IsActive = false;

        _dbContext.Issues.Update(issue);

        _dbContext.SaveChanges();
        
        return RedirectToPage("/Issues/Index");
    }
}