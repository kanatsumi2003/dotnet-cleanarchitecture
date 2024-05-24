using InternSystem.Application.Common.Persistences.IRepositories;
using InternSystem.Application.Common.Persistences.IRepositories.IBaseRepositories;
using InternSystem.Infrastructure.Persistences.DBContext;
using InternSystem.Infrastructure.Persistences.Repositories.BaseRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternSystem.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork : BaseUnitOfWork, IUnitOfWork 
    {
        private readonly ApplicationDbContext _dbContext;
        private IUserRepository? _userRepository;
        public UnitOfWork(ApplicationDbContext dbContext) : base(dbContext) { 
            _dbContext = dbContext;
        }
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_dbContext);
    }
}
