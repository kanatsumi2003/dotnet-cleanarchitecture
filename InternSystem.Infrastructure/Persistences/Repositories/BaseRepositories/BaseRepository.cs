using InternSystem.Application.Common.Persistences.IRepositories.IBaseRepositories;
namespace InternSystem.Infrastructure.Persistences.Repositories.BaseRepositories;

public class BaseRepository<T> : IBaseRepository where T : class
{
    private readonly Microsoft.EntityFrameworkCore.DbContext _dbContext;

    public BaseRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }
}