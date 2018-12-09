using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movielogue.Service.Models.Base;
using Newtonsoft.Json;

namespace Movielogue.Service.Models
{
    public class UserModel : BaseModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
