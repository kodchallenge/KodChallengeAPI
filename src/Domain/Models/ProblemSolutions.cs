

using Kod.Core.Domain.Models;

namespace Kod.Domain.Models
{
    public class ProblemSolutions : Entity
    {
        public int UserSolutionId { get; set; }

        public int ProblemId { get; set; }

        public ProblemSolutions(int userSolutionId, int problemId)
        {
            UserSolutionId = userSolutionId;
            ProblemId = problemId;
        }

        public ProblemSolutions(int id, int userSolutionId, int problemId) : this(userSolutionId, problemId)
        {
            Id = id;
        }
    }
}
