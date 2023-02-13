using Microsoft.EntityFrameworkCore;
using Mission6_DexterStephens.Models.Home;
using System.Reflection;

namespace Mission6_DexterStephens.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //nothing here for now
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel
                {
                    CategoryId= 1,
                    Name = "Action/Adventure"
                },
                new CategoryModel 
                { 
                    CategoryId= 2,
                    Name = "Comedy"
                },
                new CategoryModel
                {
                    CategoryId = 3,
                    Name = "Drama"
                },
                new CategoryModel
                {
                    CategoryId = 4,
                    Name = "Family"
                },
                new CategoryModel
                {
                    CategoryId = 5,
                    Name = "Horror/Suspense"
                },
                new CategoryModel
                {
                    CategoryId = 6,
                    Name = "Miscellaneous"
                },
                new CategoryModel
                {
                    CategoryId = 7,
                    Name = "Television"
                },
                new CategoryModel
                {
                    CategoryId = 8,
                    Name = "VHS"
                }

                );
            modelBuilder.Entity<MovieModel>().HasData(
                new MovieModel
                {
                    Title= "Dark Knight",
                    CategoryId = 1,
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
                    CategoryId = 1,
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
                    CategoryId = 1,
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
