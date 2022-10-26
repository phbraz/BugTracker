using BugTrackerProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BugTrackerProject.Pages.Issues;

public class Index : PageModel
{
    private ApplicationDbContext _dbContext;

    public Index(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public void OnGet()
    {
    }
    
    public List<DTOs.Issues.IssueIndexDto> GetIssues()
    {
        var issues = _dbContext.Issues.Where(x => x.IsActive).Select(x =>
            new DTOs.Issues.IssueIndexDto
            {
                Id = x.Id,
                Title = x.Title,
                Reporter = x.Reporter,
                CreatedDate = x.CreatedDate,

            }).ToList();
        
        return issues;
    }
}