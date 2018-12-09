using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Movielogue.Domain.Entities.Identity;
using Movielogue.Domain.Models.Entities;
using Movielogue.Service.Models;

namespace Movielogue.Service.Mapping
{
    public class EntityToModel : Profile
    {
        public EntityToModel() {
            CreateMap<User, UserModel>();
            CreateMap<MovieEntity, MovieModel>();
        }
    }
    
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<MovieModel, MovieEntity>();
            CreateMap<UserModel, User>();
        }
    }
}
