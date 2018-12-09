using System;
using Movielogue.Domain.Entities.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Movielogue.Persistence;
using Movielogue.Domain.Contracts;

namespace Movielogue.Domain.Stores
{
    public class UserStore : UserStore<User, Role, Guid, UserLogin, UserRole, UserClaim>
    {
        public UserStore(IMovielogueDbContext context) : base(context.DbContext) { }
    }
}
