using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Popcorn.DAL.Models;

namespace Popcorn.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PopcornItem> Popcorns { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PopcornItem>().ToTable("Popcorn");

            modelBuilder.Entity<PopcornItem>().HasData(
                new PopcornItem { PopcornId = 1, Name = "Sucré", Description = "Pour les coeurs tendres" },
                new PopcornItem { PopcornId = 2, Name = "Salé", Description = "Pour les autres" },
                new PopcornItem { PopcornId = 3, Name = "Nature", Description = "Pour les indécis" }
            ); ;
        }
    }
}
