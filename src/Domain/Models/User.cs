
using Kod.Core.Domain.Models;

namespace Kod.Domain.Models;
public class User : Entity
{
    public string FullName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsDeleted { get; set; }

    public User(string fullName, string username, string email, string password)
    {
        FullName = fullName;
        Username = username;
        Email = email;
        Password = password;
        IsDeleted = false;
    }

    public User(int id, string fullName, string username, string email, string password) : this(fullName, username, email, password)
    {
        Id = id;
    }
}
