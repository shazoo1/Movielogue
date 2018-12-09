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
    public class UserStore : UserStore<User, Role, Guid, UserLogin, UserRole, UserClaim>
    {
        public UserStore(IMovielogueDbContext context)
            : base(context.DbContext) { }
    }
}
