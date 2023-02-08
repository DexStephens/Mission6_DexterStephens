using Microsoft.EntityFrameworkCore;
using Mission6_DexterStephens.Models.Home;
using System.Reflection;

namespace Mission6_DexterStephens.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
        
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //nothing here for now
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    Title= "Dark Knight",
                    Category= "Action/Adventure",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited= false,
                    LentTo = null,
                    Notes = null
                },
                new MovieModel
                {
                    Title = "Cars",
                    Category = "Action/Adventure",
                    Year = 2006,
                    Director = "John Lasseter",
                    Rating = "G",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new MovieModel
                {
                    Title = "Harry Potter and the Chamber of Secrets",
                    Category = "Action/Adventure",
                    Year = 2002,
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
            );
        }
    }
}
