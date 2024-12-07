using AutoTurn.Models;

namespace AutoTurn.Application.Interfaces.Repository;


public interface IForeignRepository
{
    Task<Foreign?> GetByIdAsync(int id);
    Task<Foreign?> GetByYektaAsync(long yektaCode);
    Task<Foreign?> GetBySpecificAsync(long specificCode);
    Task<Foreign?> GetByPassport(string passportCode);
    Task<Foreign?> GetByFaragir(long faragirCode);

    Task<ICollection<Foreign>> GetAllAsync(
        int PageIndex,
        int PageSize,
        int? officeId = null);

}


