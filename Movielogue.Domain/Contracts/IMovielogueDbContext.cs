using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movielogue.Domain.Contracts
{
    public interface IMovielogueDbContext : IDisposable
    {
        DbContext DbContext { get; }
    }
}
