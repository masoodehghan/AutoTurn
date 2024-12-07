using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Infrustructure.Persistence;

public class PlanRepository : IPlanRepository
{
    private readonly AutoTurnDbContext _context;

    public PlanRepository(AutoTurnDbContext context)
    {
        _context = context;
    }

    public async Task AddPlanAsync(Plan plan)
    {
        await _context.Plans.AddAsync(plan);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePlanAsync(Plan plan)
    {
        plan.IsActive = false;
        await _context.SaveChangesAsync();
    }

    public async Task<Plan?> GetPlanById(int Id)
    {
        return await _context.Plans.Include(f => f.RelatedPlans).SingleOrDefaultAsync(p => p.Id == Id);
    }

    public async Task<IEnumerable<Plan>> GetPlansListAsync()
    {

        return await _context.Plans.ToListAsync();
    }

    public async Task UpdatePlanAsync(Plan plan)
    {
        await _context.SaveChangesAsync();
    }
}
