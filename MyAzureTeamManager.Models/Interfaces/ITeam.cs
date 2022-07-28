
namespace MyAzureTeamManager.Models.Interfaces
{
    public interface ITeam
    {
        public List<Board> Boards { get; set; }
        public List<Person> Members { get; set; }
        public string TeamName { get; set; }
    }
}