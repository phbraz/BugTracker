namespace BugTrackerProject.Models;

public class IssueList
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Reporter { get; set; }
    public string Description { get; set; }
    public StatusEnum Status { get; set; }
    public bool IsActive { get; set; }
}

public enum StatusEnum
{
    Open,
    InProgress,
    Closed
} 