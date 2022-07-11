namespace MyAzureTeamManager.Models.Interfaces
{
    public interface IBoard
    {
        public int BoardId { get; set; }
        public List<Bug> Bugs { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
}