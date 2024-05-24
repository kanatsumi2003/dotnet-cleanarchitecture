using InternSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternSystem.Infrastructure.Persistences.DBContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<AspNetUser> Users => Set<AspNetUser>();
}