using MyAzureTeamManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAzureTeamManager.Models

{
    public class Bug : IBug
    {
        public Bug()
        {

        }
        public Bug(int bugId, string title, string description, int boardId, Priority priority, Status bugStatus)
        {
            BugId = bugId;
            Title = title;
            Description = description;
            BoardId = boardId;
            Priority = priority;
            BugStatus = bugStatus;
            Comments = new List<string>();
        }
        [Key]
        public int BugId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Comments { get; set; }
        public string History { get; set; }
        [ForeignKey("Board")]
        public int BoardId { get; set; }
        public Priority Priority { get; set; }
        public Severity Severity { get; set; }
        public Status BugStatus { get; set; }
    }
}