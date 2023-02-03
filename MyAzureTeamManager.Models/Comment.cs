using MyAzureTeamManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAzureTeamManager.Models
{
    public class Comment : IComment
    {
        public Comment()
        {

        }
        public Comment(int id)
        {
            CommentId = id;
        }
        public int CommentId { get; set; }
    }
}
