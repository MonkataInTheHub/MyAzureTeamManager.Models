namespace MyAzureTeamManager.Models.Interfaces
{
    public interface IPerson
    {
        public int PersonId { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeamId{ get; set; }
    }
}