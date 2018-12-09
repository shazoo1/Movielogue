using AutoMapper;
using Microsoft.AspNet.Identity;
using Movielogue.Service.Interfaces;
using Movielogue.Service.Models;
using Movielogue.Web.Models.Home;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movielogue.Web.Controllers
{
    public class HomeController : BaseController
    {
        private IMovieService _movieService;

        public HomeController(IMapper mapper, IMovieService movieService) : base(mapper)
        {
            _movieService = movieService;
        }

        public ActionResult Index(int? page)
        {
            var movies = _mapper.Map<List<MovieViewModel>>(_movieService.GetAll());
            var model = new MoviesListViewModel
            {
                PageNumber = page ?? 1,
                Movies = movies,
                MoviesPagedList = movies.ToPagedList(page ?? 1, 3),
            };
            model.PageCount = model.MoviesPagedList.PageCount;
            return View(model);
        }

        [Authorize]
        public ActionResult Edit(Guid? id)
        {
            var model = new MovieViewModel();
            if (id.HasValue)
            {
                model = _mapper.Map<MovieViewModel>(_movieService.GetById(id.Value));
            }
            return View(model);
        }

        public ActionResult Details(Guid id)
        {
            var movie = _mapper.Map<MovieViewModel>(_movieService.GetById(id));
            movie.Editable = false;
            if (User.Identity.IsAuthenticated && movie.OwnerId == Guid.Parse(User.Identity.GetUserId()))
                movie.Editable = true;
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(MovieViewModel movie)
        {
            if (ModelState.IsValid)
            {
                movie.OwnerId = Guid.Parse(User.Identity.GetUserId());
                _movieService.AddOrUpdate(_mapper.Map<MovieModel>(movie));
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "");
            return View(movie);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult UploadPoster()
        {
            string path = "";
            try
            {
                foreach (string fileName in Request.Files)
                {
                    HttpPostedFileBase file = Request.Files[fileName];
                    //Save file content goes here
                    if (file != null && file.ContentLength > 0)
                    {
                        var originalDirectory = new DirectoryInfo(string.Format("{0}Uploads\\", Server.MapPath("~/")));
                        var fileExtension = Path.GetExtension(file.FileName);
                        var randomFileName = Path.GetRandomFileName();
                        var pathString = originalDirectory.ToString();
                        bool exists = System.IO.Directory.Exists(pathString);
                        if (!exists)
                            System.IO.Directory.CreateDirectory(pathString);
                        path = string.Format("{0}{1}", pathString, randomFileName + fileExtension);
                        file.SaveAs(path);
                        path = string.Format("{0}{1}", "~/Uploads/", randomFileName + fileExtension);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return Json(new { Message = path });
        }
    }
}