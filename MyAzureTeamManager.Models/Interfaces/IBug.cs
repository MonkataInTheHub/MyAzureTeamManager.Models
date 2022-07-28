
namespace MyAzureTeamManager.Models.Interfaces
{
    public interface IBug
    {
        public int BoardId { get; set; }
        public Status BugStatus { get; set; }
        public List<string> Comments { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public int BugId { get; set; }
        public Priority Priority { get; set; }
        public Severity Severity { get; set; }
        public string Title { get; set; }
    }
}