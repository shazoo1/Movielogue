using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movielogue.Domain.Models.Entities;
using Movielogue.Service.Models.Base;

namespace Movielogue.Service.Models
{
    public class MovieModel : BaseModel
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string PosterLink { get; set; }
        public Guid OwnerId { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}