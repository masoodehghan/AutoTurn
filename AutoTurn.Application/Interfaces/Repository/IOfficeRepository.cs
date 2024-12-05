using AutoTurn.Models;

namespace AutoTurn.Application.Interfaces.Repository;

public interface IOfficeRepository
{
    Task AddOfficeAsync(Office office);

    Task<Office?> GetOfficeByIdAsync(int id);
    Task<Office?> GetOfficeByIdAsyncWithPlan(int id);

    Task<Office?> ReadOnlyOfficeByIdAsync(int id);

    Task<ICollection<Office>> GetAllOfficeAsync(int? ProvinceId, int? pageIndex, int pageSize);
    Task<IEnumerable<Office>> GetAllOfficeAsync();


    Task DeleteOfficeAsync(Office office);
    Task SaveChangesAsync();
}