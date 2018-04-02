using Microsoft.EntityFrameworkCore;

namespace LdsMovies.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<LdsMovies.Models.Movie> Movie { get; set; }
    }
}
