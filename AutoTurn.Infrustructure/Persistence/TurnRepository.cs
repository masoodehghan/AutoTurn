using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoTurn.Infrastructure.Persistence;

public class TurnRepository : PagedList<Turn>, ITurnRepository
{
    private readonly AutoTurnDbContext _context;

    public TurnRepository(AutoTurnDbContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Turn>> TurnListDescendByTime(int officeId, int planId)
    {
        return await _context.Turns
            .Where(
            t => t.OfficeId == officeId &&
            t.PlanId == planId ||
            t.TranferedOfficeId == officeId
            )
            .OrderBy(f => f.EndTime).ToListAsync();
    }

    public async Task AddTurnAsync(Turn turn)
    {
        await _context.Turns.AddAsync(turn);
        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<Turn>> TurnListWithFilters(
        int? PlanId = null,
        string? ForeignCode = null,
        bool? IsTransfered = null,
        DateTime? StartTime = null,
        DateTime? EndTime = null,
        bool? IsDeleted = null,
        int? OfficeId = null,
        int? PageSize = null,
        int? PageIndex = null)
    {
        IQueryable<Turn> turns= _context.Turns
            .Include(o => o.Plan)
            .Include(o => o.Office)
            .Include(o => o.Foreign);
        if (PlanId is not null)
        {
            turns = turns.Where(s => s.PlanId == PlanId);
        };

        if (ForeignCode is not null) 
        {
            long foreignCode;

            if(long.TryParse(ForeignCode, out foreignCode))
            {
                turns = turns.Where(
                    t => t.Foreign.SpecificCode == foreignCode || 
                    t.Foreign.FaragirCode == foreignCode ||
                    t.Foreign.YektaCode == foreignCode);
            }
            else
            {
                turns = turns.Where(t => t.Foreign.PassportCode == ForeignCode);
            }
        }

        if(StartTime is not null && EndTime is not null)
        {
            turns = turns.Where(t => StartTime <= t.StartTime && EndTime >= t.StartTime);
        }
        
        if(IsTransfered is not null)
        {
            turns = turns.Where(t => t.TranferedOfficeId != null);
        }

        if (OfficeId is not null)
        {
            turns = turns.Where(t => t.OfficeId == OfficeId);   
        }

        return  await PageList(turns, PageIndex , PageSize ?? 10).ToListAsync();
    }

    public async Task<Turn?> GetTurnByIdAsync(int turnId)
    {
        return await _context.Turns
            .Include(t => t.Office)
            .Include(t => t.Foreign)
            .Include(t => t.Plan)
            .SingleOrDefaultAsync(t => t.Id == turnId);
    }

    public async Task DeleteTurnAsync(Turn turn)
    {
        turn.IsActive = false;
        turn.DeletedCount++;
        await _context.SaveChangesAsync();
    }
}
