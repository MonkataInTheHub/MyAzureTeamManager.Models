using MyAzureTeamManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAzureTeamManager.Models
{
    public class Feedback : IFeedback
    {
        public Feedback()
        {

        }
        public Feedback(int feedbackId, string title, string description, Status feedbackStatus, int rating, int boardId)
        {
            FeedbackId = feedbackId;
            Title = title;
            Description = description;
            FeedbackStatus = feedbackStatus;
            Rating = rating;
            Comments = new List<Comment>();
            BoardId = boardId;
        }
        [Key]
        public int FeedbackId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public string History { get; set; }
        public Status FeedbackStatus { get; set; }
        public int Rating { get; set; }
        [ForeignKey("Board")]
        public int BoardId { get; set; }
    }
}