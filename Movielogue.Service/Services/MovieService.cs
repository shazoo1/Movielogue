using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Movielogue.Domain.Contracts;
using Movielogue.Domain.Contracts.Repositories.Interfaces;
using Movielogue.Domain.Models.Entities;
using Movielogue.Service.Interfaces;
using Movielogue.Service.Models;
using Movielogue.Service.Services.Base;

namespace Movielogue.Service.Services
{
    public class MovieService : BaseService<MovieEntity>, IMovieService
    {
        public MovieService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public void AddOrUpdate(MovieModel movieModel)
        {
            var movieRepo = _uow.Get<MovieEntity>();
            var movieEntity = movieRepo.GetById(movieModel.Id);
            bool isNew = movieEntity == null;
            if (isNew)
            {
                movieEntity = new MovieEntity();
                movieRepo.Add(movieEntity);
                movieModel.Id = Guid.NewGuid();
            }
            movieModel.LastUpdatedAt = DateTime.Now;
            _mapper.Map<MovieModel, MovieEntity>(movieModel, movieEntity);
            _uow.SaveChanges();
        }

        public MovieModel GetById(Guid id)
        {
            var movie = _uow.Get<MovieEntity>().GetById(id);
            return _mapper.Map<MovieModel>(movie);
        }

        public IEnumerable<MovieModel> GetAll()
        {
            var movies = _uow.Get<MovieEntity>()
                .GetAll()
                .OrderByDescending(x=>x.LastUpdatedAt)
                .ToList();
            return _mapper.Map<IEnumerable<MovieModel>>(movies);
        }

        public void Delete(Guid id)
        {
            _uow.Get<MovieEntity>().Remove(id);
        }
    }
}
