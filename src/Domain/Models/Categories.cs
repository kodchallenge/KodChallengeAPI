using Kod.Core.Domain.Models;


namespace Kod.Domain.Models
{
    public class Categories : Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }

        public Categories(int id, string name, string slug) : this(name, slug)
        {
            Id = id;
        }
        public Categories(string name, string slug)
        {
            Name = name;
            Slug = slug;
        }

    }
}
