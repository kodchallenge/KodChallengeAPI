
using Kod.Core.Domain.Abstractions;
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models
{
    public class Problem : Entity
    {
        public int CategoriId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsPrivate { get; set; }

        public int Point { get; set; }

        public Problem(int categoriId, string title, string description, bool isPrivate, int point)
        {
            CategoriId = categoriId;
            Title = title;  
            Description = description;  
            IsPrivate = isPrivate;  
            Point = point;
        }

        public Problem(int id, int categoriId, string title, string description, bool isPrivate, int point) : this(categoriId, title, description, isPrivate, point)
        {
            Id = id;
        }
    }
}
