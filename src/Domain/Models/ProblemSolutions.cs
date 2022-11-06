

using Kod.Core.Domain.Models;

namespace Kod.Domain.Models
{
    public class ProblemSolutions : Entity
    {
        public int UserSolutionId { get; set; }

        public int ProblemId { get; set; }

        public DateTime CreatedAt { get; set; }
        public ProblemSolutions(int userSolutionId, int problemId, DateTime createdAt)
        {
            UserSolutionId = userSolutionId;
            ProblemId = problemId;
            CreatedAt = createdAt;  
        }

        public ProblemSolutions(int id, int userSolutionId, int problemId, DateTime createdAt) : this(userSolutionId, problemId, createdAt)
        {
            Id = id;
        }
    }
}
