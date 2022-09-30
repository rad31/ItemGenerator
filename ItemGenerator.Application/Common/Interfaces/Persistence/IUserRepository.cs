using ItemGenerator.Domain.Entities;

namespace ItemGenerator.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByUsername(string username);
    void Add(User user);
}