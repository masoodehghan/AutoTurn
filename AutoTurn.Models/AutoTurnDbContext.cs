using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AutoTurn.Models;

public class AutoTurnDbContext : IdentityDbContext<User>
{
    public AutoTurnDbContext(DbContextOptions<AutoTurnDbContext> options) : base(options)
    {
    }

    public DbSet<Foreign> Foreigns { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Plan> Plans { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<Turn> Turns { get; set; }
    public DbSet<User> Users {  get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<Office>().HasQueryFilter(f => f.IsActive);
        builder.Entity<Plan>().HasQueryFilter(f => f.IsActive);
        builder.Entity<Turn>().HasQueryFilter(f => f.IsActive);

        builder.ApplyConfigurationsFromAssembly(typeof(AutoTurnDbContext).Assembly);
        base.OnModelCreating(builder);
    }
}