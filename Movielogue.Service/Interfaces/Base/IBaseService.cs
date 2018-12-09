using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movielogue.Domain.Models.Entities;
using Movielogue.Service.Models.Base;
namespace Movielogue.Service.Interfaces.Base
{
    public interface IBaseService<T> : IService where T : BaseEntity
    {
        
    }
}
