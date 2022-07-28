using MyAzureTeamManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyAzureTeamManager.Models
{
    public class Feedback : IFeedback
    {
        public Feedback()
        {

        }
        public Feedback(int feedbackId, string title, string description, Status feedbackStatus, int rating)
        {
            FeedbackId = feedbackId;
            Title = title;
            Description = description;
            FeedbackStatus = feedbackStatus;
            Rating = rating;
            Comments = new List<string>();
        }
        [Key]
        public int FeedbackId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Comments { get; set; }
        public string History { get; set; }
        public Status FeedbackStatus { get; set; }
        public int Rating { get; set; }
    }
}