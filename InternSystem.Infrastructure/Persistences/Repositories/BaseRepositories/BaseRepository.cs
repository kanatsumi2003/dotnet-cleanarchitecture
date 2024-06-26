﻿using InternSystem.Application.Common.Persistences.IRepositories.IBaseRepositories;
using Microsoft.EntityFrameworkCore;
namespace InternSystem.Infrastructure.Persistences.Repositories.BaseRepositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DbContext _dbContext;

    public BaseRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<T> GetByIdAsync(object id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }
    public async Task<T> AddAsync(T entity)
    {
        if(_dbContext.Entry(entity).State == EntityState.Detached)
        {
            _dbContext.Set<T>().Attach(entity);
        }
        await _dbContext.Set<T>().AddAsync(entity);
        return entity;
    }
    public async Task<IEnumerable<T>> GetAllASync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }
}