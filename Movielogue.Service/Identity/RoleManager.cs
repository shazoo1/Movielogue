using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Movielogue.Domain.Entities.Identity;

namespace Movielogue.Service.Identity
{
    public class RoleManager : RoleManager<Role, Guid>
    {
        public RoleManager(IRoleStore<Role, Guid> roleStore)
            : base(roleStore) { }
    }
}
