using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoTurn.Models.Configurations;


public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
{
    public void Configure(EntityTypeBuilder<Province> builder)
    {
        builder.Property(p => p.Name).HasMaxLength(50);
        builder.HasIndex(p => p.AdminId).IsUnique();
        builder.HasData(
        [
            new Province { Id = 1, Name = "tehran"},
            new Province { Id = 2, Name = "yazd"},
            new Province { Id = 3, Name = "esfahan"},
            new Province { Id = 4, Name = "kerman"},
            
        ]);

    }
}
