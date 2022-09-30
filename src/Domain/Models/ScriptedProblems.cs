
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models
{
    public class ScriptedProblems : Entity
    {
        public int ProblemId { get; set; }

        public int LanguageId { get; set; }

        public ScriptedProblems(int problemId, int languageId)
        {
            ProblemId = problemId;
            LanguageId = languageId;

        }

        public ScriptedProblems(int id, int problemId, int languageId) : this(problemId, languageId)
        {
            Id = id;
        }
    }
}
