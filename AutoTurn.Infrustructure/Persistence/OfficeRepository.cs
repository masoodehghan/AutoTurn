using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Infrastructure.Persistence;


public class OfficeRepository : IOfficeRepository
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
        return await _context.Offices.Include(o => o.Province).ToListAsync();
    }

    public async Task<Office?> GetOfficeByIdAsync(int id)
    {
       return await _context.Offices.Include(o=>o.Province).SingleOrDefaultAsync(o =>  o.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
