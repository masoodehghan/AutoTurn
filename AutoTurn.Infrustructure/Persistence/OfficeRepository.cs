using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Infrastructure.Persistence;


public class OfficeRepository :  PagedList<Office>, IOfficeRepository
{
    private readonly AutoTurnDbContext _context;

    public OfficeRepository(AutoTurnDbContext context)
    {
        _context = context;
    }

    public async Task AddOfficeAsync(Office office)
    {
        await _context.AddAsync(office);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteOfficeAsync(Office office)
    {
        office.IsActive = false;
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Office>> GetAllOfficeAsync()
    {
        var paged = PageList(_context.Offices.Include(o => o.Province));
        return await paged.ToListAsync();
    }

    public async Task<ICollection<Office>> GetAllOfficeAsync(
        int? ProvinceId = null,
        int? pageIndex = null,
        int pageSize = 10
        )
    {

        IQueryable<Office> offices = _context.Offices.Include(s => s.Province);

        if (ProvinceId is not null)
        {
            offices = offices.Where(s => s.ProvinceId == ProvinceId);
        }

        var paged = PageList(offices.Include(s => s.Admins).AsNoTracking(),
            pageIndex, pageSize);

        return await paged.ToListAsync();
    }

    public async Task<Office?> GetOfficeByIdAsync(int id)
    {
       return await _context.Offices.Include(o=>o.Province).SingleOrDefaultAsync(o =>  o.Id == id);
    }

    public async Task<Office?> GetOfficeByIdAsyncWithPlan(int id)
    {
        return await _context.Offices.Include(o => o.Plans).
            SingleOrDefaultAsync(f => f.Id == id);
    }

    public async Task<Office?> ReadOnlyOfficeByIdAsync(int id)
    {
        return await _context.Offices.Include(o => o.Admins).Include(o => o.Province)
            .AsNoTracking().SingleOrDefaultAsync(o => o.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
