using AutoTurn.Models;

namespace AutoTurn.Application.Interfaces.Repository;

public interface ITurnRepository
{
    Task<ICollection<Turn>> TurnListDescendByTime(int officeId, int planId);
    Task AddTurnAsync(Turn turn);
    Task<ICollection<Turn>> TurnListWithFilters(
        int? PlanId,
        string? ForeignCode,
        bool? IsTransfered,
        DateTime? StartTime,
        DateTime? EndTime,
        bool? IsDeleted,
        int? OfficeId,
        int? PageIndex,
        int? PageSize);


    Task<Turn?> GetTurnByIdAsync(int turnId);

    Task<bool> IsForeignAndPlanExists(int relatedPlanId, int ForeignId);
    Task DeleteTurnAsync(Turn turn);
}