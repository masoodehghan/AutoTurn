using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoTurn.Models.Configurations;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.Property<int>(o => o.Id).ValueGeneratedNever();
        builder.OwnsOne(s => s.Address).WithOwner();
        builder.Property<string>(o => o.Name).IsRequired().HasMaxLength(50);
        builder.OwnsMany(o => o.PlanSettings).WithOwner();
    }
}
