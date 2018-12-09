using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Movielogue.Domain.Contracts;
using Movielogue.Domain.Models.Entities;
using Movielogue.Service.Interfaces.Base;
using Movielogue.Service.Models.Base;

namespace Movielogue.Service.Services.Base
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IMapper _mapper;

        public BaseService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
    }
}
