using Kod.Core.Domain.Models;
using System.Text.Json.Serialization;

namespace Kod.Domain.Models
{
    public class Problems : Entity
    {
        public int CategoriId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public bool IsPrivate { get; set; }

        public int Point { get; set; }

        public DateTime CreatedAt { get; set; }

        [JsonConstructor]
        public Problems(int categoriId, string title, string description, bool isPrivate, int point, DateTime createdAt)
        {
            CategoriId = categoriId;
            Title = title;  
            Description = description;  
            IsPrivate = isPrivate;  
            Point = point;
            CreatedAt = createdAt;  
        }
        public Problems(int categoriId, string title, string description, bool isPrivate, int point)
        {
            CategoriId = categoriId;
            Title = title;
            Description = description;
            IsPrivate = isPrivate;
            Point = point;
        }

        public Problems(int id, int categoriId, string title, string description, bool isPrivate, int point, DateTime createdAt) : this(categoriId, title, description, isPrivate, point, createdAt)
        {
            Id = id;
        }

        public Problems(int id)
        {
            Id = id;
        }
    }
}
