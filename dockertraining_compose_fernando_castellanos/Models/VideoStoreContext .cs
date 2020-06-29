using Microsoft.EntityFrameworkCore;

namespace dockertraining_compose_fernando_castellanos.Models
{
    public class VideoStoreContext :DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public VideoStoreContext (DbContextOptions options):base(options)
        {

        }
    }
}
