
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models;
public class ProgrammingLanguages : Entity
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public DateTime CreatedAt { get; set; }
    public ProgrammingLanguages()
    {

    }

    public ProgrammingLanguages(string name, string slug, DateTime createdAt) : this()
    {
        Name = name;
        Slug = slug;
        CreatedAt = createdAt;  
    }
    public ProgrammingLanguages(int id, string name, string slug, DateTime createdAt) : this(name, slug, createdAt)
    {
        Id = id;
    }
}