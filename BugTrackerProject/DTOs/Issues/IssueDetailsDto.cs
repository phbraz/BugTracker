using BugTrackerProject.Models;

namespace BugTrackerProject.DTOs.Issues;

public class IssueDetailsDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Reporter { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public string TicketNumber { get; set; }
    public StatusEnum Status { get; set;}
}