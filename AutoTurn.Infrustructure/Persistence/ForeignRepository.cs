using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Infrustructure.Persistence;

public class ForeignRepository : IForeignRepository
{
    private readonly AutoTurnDbContext _context;

    public ForeignRepository(AutoTurnDbContext context)
    {
        _context = context;
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
