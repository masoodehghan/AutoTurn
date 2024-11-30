using AutoTurn.Models;

namespace AutoTurn.Application.Interfaces.Repository;

public interface IUserRepository
{
    Task<User?> GetUserByUserNameAsync(string userName);
    Task<User?> GetUserByIdAsync(string Id);

}

