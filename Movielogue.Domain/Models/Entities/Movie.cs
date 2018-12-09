using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movielogue.Domain.Models.Entities
{
    public class MovieEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string PosterLink { get; set; }
        public Guid OwnerId { get; set; }
    }
}