using MyAzureTeamManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyAzureTeamManager.Models
{
    public class Board : IBoard
    {
        [Key]
        public int BoardId { get; set; }
        public List<Bug> Bugs { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Feedback>Feedbacks { get; set; }
    }
}