using MyAzureTeamManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyAzureTeamManager.Models
{
    public class Board : IBoard
    {
        public Board(int teamId)
        {
            TeamId = teamId;
            Bugs = new List<Bug>();
            Tasks = new List<Task>();
            Feedbacks = new List<Feedback>();
        }
        [Key]
        public int BoardId { get; set; }
        public List<Bug> Bugs { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Feedback>Feedbacks { get; set; }
        public int TeamId { get; set; }
    }
}