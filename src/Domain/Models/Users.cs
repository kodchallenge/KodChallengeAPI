
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models;
public class Users : Entity
{
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsDeleted { get; set; }
    public int BadgeId { get; set; }
    public int RoleId { get; set; } 
    public DateTime CreatedAt { get; set; }
    public Users(string fullName, string userName, string email, string password, DateTime createdAt, int roleId, int badgeId)
    {
        FullName = fullName;
        UserName = userName;
        Email = email;
        Password = password;
        IsDeleted = false;
        CreatedAt = createdAt;  
        RoleId = roleId;
        BadgeId = badgeId;
    }

    public Users(int id, string fullName, string username, string email, string password, bool isDeleted, DateTime createdAt, int badgeId, int roleId) : this(fullName, username, email, password, isDeleted, createdAt, roleId, badgeId)
    {
        Id = id;
    }

    public Users(string fullName, string userName, string email, string password, bool isDeleted, DateTime createdAt, int roleId, int badgeId)
    {
        FullName = fullName;
        UserName = userName;
        Email = email;
        Password = password;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
        RoleId = roleId;
        BadgeId = badgeId;
    }
}
