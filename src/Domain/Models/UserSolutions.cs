

using Kod.Core.Domain.Models;

namespace Kod.Domain.Models
{
    public class UserSolutions : Entity
    {
        public int UserId { get; set; }

        public string SolutionPath { get; set; }

        public int Score { get; set; }

        public UserSolutions( int userId, string solutionPath, int score)
        {
            UserId= userId;
            SolutionPath= solutionPath;
            Score= score;
        }

        public UserSolutions(int id, int userId, string solutionPath, int score) : this(userId, solutionPath, score)
        {
            Id = id;
        }
    }
}
