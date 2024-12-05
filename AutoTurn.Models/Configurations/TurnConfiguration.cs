using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoTurn.Models.Configurations;


public class TurnConfiguration : IEntityTypeConfiguration<Turn>
{
    public void Configure(EntityTypeBuilder<Turn> builder)
    {
        builder.HasIndex(s => new { s.PlanId, s.OfficeId, s.ForeignId }).IsUnique();
    }
}
