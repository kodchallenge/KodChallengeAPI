using Kod.Core.Domain.Models;


namespace Kod.Domain.Models
{
    public class Categories : Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }

        public DateTime CreatedAt { get; set; }
        public Categories(int id, string name, string slug, DateTime createdAt) : this(name, slug, createdAt)
        {
            Id = id;
        }
        public Categories(string name, string slug, DateTime createdAt)
        {
            Name = name;
            Slug = slug;
            CreatedAt = createdAt;
        }

        public Categories(int id)
        {
            Id = id;
        }

    }
}
