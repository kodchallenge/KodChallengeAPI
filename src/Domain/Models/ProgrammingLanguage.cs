
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models;
public class ProgrammingLanguage : Entity
{
    public string Name { get; set; }
    public string Slug { get; set; }

    public ProgrammingLanguage()
    {

    }

    public ProgrammingLanguage(int id, string name, string slug) : this()
    {
        Name = name;
        Slug = slug;
        Id = id;
    }
    public ProgrammingLanguage(string name, string slug) : this(0, name, slug) { }
}