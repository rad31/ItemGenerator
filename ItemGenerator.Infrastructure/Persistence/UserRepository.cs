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

    public User? GetUserByUserName(string userName)
    {
        return _users.Find(u => u.UserName == userName);
    }
}