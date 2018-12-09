using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movielogue.Web.Models.Home
{
    public class MovieViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Введите название фильма")]
        public string Title { get; set; }

        [Display(Name = "Режиссёр")]
        [Required(ErrorMessage = "Это поле тоже обязательно")]
        public string Director { get; set; }

        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Описание фильму тоже нужно")]
        public string Description { get; set; }

        [Display(Name = "Год выпуска")]
        [Required(ErrorMessage = "Введите год выпуска фильма")]
        public int Year { get; set; }

        [Display(Name = "Постер")]
        public string PosterLink { get; set; }

        public Guid OwnerId { get; set; }
        public bool Editable { get; set; }
    }
}