using ItemGenerator.Domain.Entities;
using ItemGenerator.Application.Common.Interfaces.Persistence;

namespace ItemGenerator.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new ();

    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByUsername(string username)
    {
        return _users.Find(u => u.Username == username);
    }
}