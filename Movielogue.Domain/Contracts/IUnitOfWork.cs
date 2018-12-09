using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movielogue.Domain.Contracts.Repositories.Interfaces;
using Movielogue.Domain.Models.Entities;

namespace Movielogue.Domain.Contracts
{
    public interface IUnitOfWork
    {
        IBaseRepository<T> Get<T>() where T : BaseEntity;
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
