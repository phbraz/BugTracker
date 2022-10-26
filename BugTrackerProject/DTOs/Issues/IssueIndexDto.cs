namespace BugTrackerProject.DTOs.Issues;

public class IssueIndexDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Reporter { get; set; }
    public DateTime CreatedDate { get; set; }
}
