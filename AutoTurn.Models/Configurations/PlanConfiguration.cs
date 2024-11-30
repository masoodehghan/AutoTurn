using AutoTurn.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoTurn.Models.Configurations;

public class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property<int>(p => p.Id).ValueGeneratedNever();
        builder.Property(p => p.Name).HasMaxLength(50);

        builder.Property(p => p.PlanType).HasConversion(
            v => v.ToString(),
            value => (PlanType)Enum.Parse(typeof(PlanType), value)
        );

        builder.Property(p => p.CodeType).HasConversion(
            v => v.ToString(),
            value => (CodeType)Enum.Parse(typeof(CodeType), value)
        );
    }
}
