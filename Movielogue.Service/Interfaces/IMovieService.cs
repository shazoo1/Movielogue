using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movielogue.Domain.Models.Entities;
using Movielogue.Service.Interfaces.Base;
using Movielogue.Service.Models;

namespace Movielogue.Service.Interfaces
{
    public interface IMovieService : IBaseService<MovieEntity>
    {
        void AddOrUpdate(MovieModel movie);
        MovieModel GetById(Guid id);
        IEnumerable<MovieModel> GetAll();
        void Delete(Guid id);
    }
}
