using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Infrastructure.Persistence;
using AutoTurn.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Infrustructure.Persistence;

public class ForeignRepository : PagedList<Foreign>, IForeignRepository
{
    private readonly AutoTurnDbContext _context;

    public ForeignRepository(AutoTurnDbContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Foreign>> GetAllAsync(int PageIndex, int PageSize,
        int? officeId = null)
    {
        IQueryable<Foreign> foreigns = _context.Foreigns.Include(f => f.Offices);

        if(officeId is not null)
        {
            
            foreigns = foreigns.Where(f => f.Offices.Contains(
                _context.Offices.FirstOrDefault(o => o.Id == officeId))
            );
        }

        return await PageList(foreigns, PageIndex, PageSize).ToListAsync();
    }

    public async Task<Foreign?> GetByFaragir(long faragirCode)
    {
        return await _context.Foreigns.SingleOrDefaultAsync(
            s => s.FaragirCode == faragirCode
            );
    }

    public async Task<Foreign?> GetByIdAsync(int id)
    {
        return await _context.Foreigns.SingleOrDefaultAsync(
            s => s.Id == id
            );
    }

    public async Task<Foreign?> GetByPassport(string passportCode)
    {
        return await _context.Foreigns.SingleOrDefaultAsync(
            s => s.PassportCode == passportCode
            );
    }

    public async Task<Foreign?> GetBySpecificAsync(long specificCode)
    {
        return await _context.Foreigns.SingleOrDefaultAsync(
            s => s.SpecificCode == specificCode
            );
    }

    public async Task<Foreign?> GetByYektaAsync(long yektaCode)
    {
        return await _context.Foreigns.SingleOrDefaultAsync(
            s => s.YektaCode == yektaCode
            );
    }
}
