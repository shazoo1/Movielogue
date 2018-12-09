using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movielogue.Domain.Models.Entities;

namespace Movielogue.Persistence.Mapping
{
    public class MovieMap : EntityTypeConfiguration<MovieEntity>
    {
        public MovieMap()
        {
            ToTable("Movies");
            HasKey(x => x.Id);

            Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Director)
                .HasMaxLength(100);

            Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500);

            Property(x => x.Year)
                .IsRequired();

            Property(x => x.PosterLink)
                .IsOptional();
        }
    }
}
