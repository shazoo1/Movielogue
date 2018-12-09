using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Movielogue.Domain.Entities.Identity;
using Movielogue.Service.Models;
using Movielogue.Web.Models.Home;

namespace Movielogue.Web.Mapping
{
    public class ModelToViewModel : Profile
    {
        public ModelToViewModel()
        {
            CreateMap<MovieModel, MovieViewModel>()
                .ForMember(d => d.Editable, opt => opt.Ignore());
        }
    }

    public class ViewModelToModel : Profile
    {
        public ViewModelToModel()
        {
            CreateMap<MovieViewModel, MovieModel>()
                .ForSourceMember(s => s.Editable, opt => opt.DoNotValidate());
        }
    }
}