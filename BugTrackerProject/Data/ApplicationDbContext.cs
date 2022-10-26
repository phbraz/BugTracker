using BugTrackerProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTrackerProject.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<IssueList> Issues { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IssueList>().HasData(
            new IssueList
            {
                Id = 1,
                Title = "Cannot access email",
                Description = "I am trying to access my account on someuser@test.com but it says locked, please help",
                Reporter = "someuser@test.com",
                Status = 0,
                IsActive = true,
                CreatedDate = DateTime.UtcNow,
                TicketNumber = "BT-01"
            },
            new IssueList
            {
                Id = 2,
                Title = "Cannot access Site",
                Description = "I am trying to access twitter.com but it doesn't display anything",
                Reporter = "someuser@test.com",
                Status = 0,
                IsActive = true,
                CreatedDate = DateTime.UtcNow,
                TicketNumber = "BT-02"
            }
        );
        
        base.OnModelCreating(modelBuilder);
    }
}