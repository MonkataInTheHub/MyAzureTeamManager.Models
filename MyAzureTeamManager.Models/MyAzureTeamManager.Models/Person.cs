using MyAzureTeamManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAzureTeamManager.Models
{
    public class Person : IPerson
    {
        public Person()
        {

        }
        public Person(int personId, string firstName, string lastName, int age, int teamId)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            TeamId = teamId;
        }
        [Key]
        public int PersonId{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
    }
}
