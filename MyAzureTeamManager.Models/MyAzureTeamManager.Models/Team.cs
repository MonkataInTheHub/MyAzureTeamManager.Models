using MyAzureTeamManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyAzureTeamManager.Models
{
    public class Team : ITeam
    {
        public Team()
        {

        }
        public Team(int teamId, string teamName)
        {
            TeamId = teamId;
            TeamName = teamName;
        }
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<Person> Members { get; set; }
        public List<Board> Boards { get; set; }
    }
}