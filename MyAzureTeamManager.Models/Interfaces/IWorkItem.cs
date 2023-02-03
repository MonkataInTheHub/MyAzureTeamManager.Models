using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAzureTeamManager.Models.Interfaces
{
    public interface IWorkItem
    {
        public int BoardId { get; set; }
        public List<Comment> Comments { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string Title { get; set; }

    }
}
