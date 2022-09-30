using ItemGenerator.Domain.Entities;

namespace ItemGenerator.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByUserName(string userName);
    void Add(User user);
}