using Microsoft.EntityFrameworkCore;

namespace Catanks_backend.models
{
    public class ScoreContext : DbContext
    {
        public ScoreContext(DbContextOptions<ScoreContext> options)
            : base(options)
        {
        }

        public DbSet<Score> Scores { get; set; }
    }
}
