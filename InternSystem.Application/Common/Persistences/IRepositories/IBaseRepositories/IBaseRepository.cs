﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternSystem.Application.Common.Persistences.IRepositories.IBaseRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetByIdAsync(object id);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> GetAllASync();
    }
}
