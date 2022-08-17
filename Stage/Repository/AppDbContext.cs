using Microsoft.EntityFrameworkCore;
using Stage.Model;

namespace Stage.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Cheque> Cheques { get; set; }

    }
}
