using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAzureTeamManager.Models.Interfaces;

namespace MyAzureTeamManager.Models
{
    public class Task : ITask
    {
        public Task()
        {

        }
        public Task(int TaskId, string title, string description, int boardId, Priority priority, Status taskStatus)
        {
            this.TaskId = TaskId;
            Title = title;
            Description = description;
            BoardId = boardId;
            Priority = priority;
            TaskStatus = taskStatus;
            Comments = new List<string>();
        }
        [Key]
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Comments { get; set; }
        public string History { get; set; }
        [ForeignKey("Board")]
        public int BoardId { get; set; }
        public Priority Priority { get; set; }
        public Status TaskStatus { get; set; }
    }
}
