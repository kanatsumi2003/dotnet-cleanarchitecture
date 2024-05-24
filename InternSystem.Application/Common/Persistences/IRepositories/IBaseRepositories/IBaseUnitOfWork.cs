using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternSystem.Application.Common.Persistences.IRepositories.IBaseRepositories
{
    public interface IBaseUnitOfWork
    {
        Task<int> SaveChangeAsync();
        void Dispose();
    }
}
