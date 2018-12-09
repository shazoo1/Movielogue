using System;
using System.Data.Entity;
using Movielogue.Domain.Entities.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Movielogue.Domain.Models.Entities;
using Movielogue.Persistence.Mapping;
using Persistence.Mapping;
using Movielogue.Domain.Contracts;
using Movielogue.Persistence.Migrations;

namespace Movielogue.Persistence
{
    public class MovielogueDbContext : IdentityDbContext<User, Role, Guid, UserLogin, UserRole, UserClaim>, IMovielogueDbContext
    {
        public MovielogueDbContext() : base("MovielogueDbContext") {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MovielogueDbContext, Configuration>());
        }
        
        public DbSet<MovieEntity> Movies { get; set; }

        public DbContext DbContext { get => this; }

        public static MovielogueDbContext Create()
        {
            return new MovielogueDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Configurations.Add(new MovieMap());

            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
