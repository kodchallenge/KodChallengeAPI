

using Kod.Core.Domain.Models;

namespace Kod.Domain.Models
{
    public class UserSolutions : Entity
    {
        public int UserId { get; set; }

        public string SolutionPath { get; set; }

        public int Score { get; set; }

        public DateTime CreatedAt { get; set; }
        public UserSolutions( int userId, string solutionPath, int score, DateTime createdAt)
        {
            UserId = userId;
            SolutionPath = solutionPath;
            Score = score;
            CreatedAt = createdAt;
        }

        public UserSolutions(int id, int userId, string solutionPath, int score, DateTime createdAt) : this(userId, solutionPath, score, createdAt)
        {
            Id = id;
        }
    }
}
