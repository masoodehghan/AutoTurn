using AutoTurn.Models;

namespace AutoTurn.Application.Interfaces.Repository;

public interface IUserRepository
{
    Task<User?> GetUserByUserNameAsync(string userName);
    Task<User?> GetUserByIdAsync(string Id);

    Task<User?> GetUserByIdWithProvinceAsync(string Id);
    Task<User?> GetUserByIdWithOfficeAsync(string Id);
    Task<User?> GetUserByIdWithPlanAsync(string Id);

    Task<ICollection<User>> GetUserListAsync(int PageSize, int PageIndex);


}

