using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Movielogue.Domain.Contracts;
using Movielogue.Domain.Entities.Identity;

namespace Movielogue.Domain.Store
{
    public class RoleStore : RoleStore<Role, Guid, UserRole>
    {
        public RoleStore(IMovielogueDbContext context)
            : base (context.DbContext) { }
    }
}
