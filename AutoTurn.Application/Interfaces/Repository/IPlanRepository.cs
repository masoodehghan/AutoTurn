using AutoTurn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTurn.Application.Interfaces.Repository
{
    public interface IPlanRepository
    {
        Task AddPlanAsync(Plan plan);
        Task UpdatePlanAsync(Plan plan);

        Task<Plan?> GetPlanById(int Id);
        Task<IEnumerable<Plan>> GetPlansListAsync(); 
        Task DeletePlanAsync(Plan plan);
    }
}
