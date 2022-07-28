using MyAzureTeamManager.Models.Interfaces;

namespace MyAzureTeamManager.Models
{
    public class Writer : IWriter
    {
        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }

    }
}
