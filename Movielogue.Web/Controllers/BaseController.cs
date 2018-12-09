using AutoMapper;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Movielogue.Service.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movielogue.Web.Controllers
{
    public class BaseController : Controller
    {
        protected IMapper _mapper;
        protected UserManager UserManager => Request.GetOwinContext().GetUserManager<UserManager>();
        protected RoleManager RoleManager => Request.GetOwinContext().GetUserManager<RoleManager>();
        protected SignInManager SignInManager => Request.GetOwinContext().GetUserManager<SignInManager>();
        protected IAuthenticationManager AuthenticationManager => Request.GetOwinContext().Authentication;

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}