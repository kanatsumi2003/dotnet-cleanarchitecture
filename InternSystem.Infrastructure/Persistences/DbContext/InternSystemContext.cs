using InternSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InternSystem.Infrastructure.Persistences.DbContext;

public class InternSystemContext : Microsoft.EntityFrameworkCore.DbContext
{
    public InternSystemContext(DbContextOptions<InternSystemContext> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<AspNetUser> Users => Set<AspNetUser>();
}