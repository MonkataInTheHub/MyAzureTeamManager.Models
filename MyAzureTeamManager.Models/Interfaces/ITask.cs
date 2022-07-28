
namespace MyAzureTeamManager.Models.Interfaces
{
    public interface ITask
    {
        public int BoardId { get; set; }
        public List<string> Comments { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public int TaskId { get; set; }
        public Priority Priority { get; set; }
        public Status TaskStatus { get; set; }
        public string Title { get; set; }
    }
}