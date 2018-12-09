using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Movielogue.Service.Mapping;
using Movielogue.Web.Mapping;

namespace Movielogue.Web.Mapping
{
    public class Configuration
    {
        public static MapperConfiguration Create()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EntityToModel());
                cfg.AddProfile(new ModelToEntity());
                cfg.AddProfile(new ViewModelToModel());
                cfg.AddProfile(new ModelToViewModel());
            });
        }

        public static IMapper CreateMapper() => new Mapper(Create());
    }
}