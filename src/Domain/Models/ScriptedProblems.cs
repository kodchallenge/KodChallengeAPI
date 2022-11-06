
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models
{
    public class ScriptedProblems : Entity
    {
        public int ProblemId { get; set; }

        public int LanguageId { get; set; }

        public DateTime CreatedAt { get; set; } 
        public ScriptedProblems(int problemId, int languageId, DateTime createdAt)
        {
            ProblemId = problemId;
            LanguageId = languageId;
            CreatedAt = createdAt;  
        }

        public ScriptedProblems(int id, int problemId, int languageId, DateTime createdAt) : this(problemId, languageId, createdAt)
        {
            Id = id;
        }
    }
}
