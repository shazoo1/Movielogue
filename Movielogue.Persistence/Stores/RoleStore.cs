using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movielogue.Domain.Entities.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Movielogue.Persistence;
using Movielogue.Domain.Contracts;

namespace Movielogue.Domain.Stores
{
    public class RoleStore : RoleStore<Role, Guid, UserRole>
    {
        public RoleStore(IMovielogueDbContext context) : base(context.DbContext) { }
    }
}
