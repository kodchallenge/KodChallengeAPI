using Kod.Core.Domain.Models;


namespace Kod.Domain.Models
{
    public class Categori : Entity
    {
        public string Name { get; set; }
        public string Slug { get; set; }

        public Categori(int id, string name, string slug) : this()
        {
            Name = name;
            Slug = slug;
            Id = id;
        }
        public Categori(string name, string slug) : this(0, name, slug) { }

        public Categori()
        {

        }
    }
}
