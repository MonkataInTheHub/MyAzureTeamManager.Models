using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAzureTeamManager.Models.Factory
{
    public class TeamManagerFactory
    {
        public Person CreatePerson(int id,string firstName, string lastName, int age, int teamId)
        {
            return new Person(id, firstName, lastName, age, teamId);
        }
        public Board CreateBoard(int teamId)
        {
            return new Board(teamId);
        }
        public Bug CreateBug(int id, string title, string description, int boardId, Priority priority, Status bugStatus)
        {
            return new Bug(id, title, description, boardId, priority, bugStatus);
        }
        public Feedback CreateFeedback(int id, string title, string description, Status feedbackStatus, int rating, int boardId)
        {
            return new Feedback(id, title, description, feedbackStatus, rating, boardId);
        }
        public Task CreateTask(int id, string title, string description, int boardId, Priority priority, Status taskStatus)
        {
            return new Task(id, title, description, boardId, priority, taskStatus);
        }
        public Team CreateTeam(int id, string teamName)
        {
            return new Team(id, teamName);
        }
        public Comment CreateComment(int id)
        {
            return new Comment(id);
        }
    }
}
