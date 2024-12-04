using AutoTurn.Models;

namespace AutoTurn.Application.Interfaces.Repository;

public interface IOfficeRepository
{
    Task AddOfficeAsync(Office office);

    Task<Office?> GetOfficeByIdAsync(int id);
    Task<Office?> ReadOnlyOfficeByIdAsync(int id);

    Task<ICollection<Office>> GetAllOfficeAsync(int? ProvinceId);
    Task<IEnumerable<Office>> GetAllOfficeAsync();


    Task DeleteOfficeAsync(Office office);
    Task SaveChangesAsync();
}