
namespace MyAzureTeamManager.Models.Interfaces
{
    public interface IFeedback : IWorkItem
    {
        public List<Comment> Comments { get; set; }
        public string Description { get; set; }
        public Status FeedbackStatus { get; set; }
        public string History { get; set; }
        public int FeedbackId { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
    }
}