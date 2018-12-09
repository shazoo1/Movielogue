using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movielogue.Web.Models.Home
{
    public class MoviesListViewModel
    {
        public List<MovieViewModel> Movies { get; set; }
        public PagedList.IPagedList<MovieViewModel> MoviesPagedList { get; set; }
        public int PageCount { get; set; }
        public int PageNumber { get; set; }
    }
}