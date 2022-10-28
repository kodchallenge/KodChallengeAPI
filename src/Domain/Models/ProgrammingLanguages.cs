
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models;
public class ProgrammingLanguages : Entity
{
    public string Name { get; set; }
    public string Slug { get; set; }

    public ProgrammingLanguages()
    {

    }

    public ProgrammingLanguages(int id, string name, string slug) : this()
    {
        Name = name;
        Slug = slug;
        Id = id;
    }
    public ProgrammingLanguages(string name, string slug) : this(0, name, slug) { }
}