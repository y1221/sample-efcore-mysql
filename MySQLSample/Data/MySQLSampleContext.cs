using Microsoft.EntityFrameworkCore;

namespace MySQLSample.Data
{
    public class MySQLSampleContext : DbContext
    {
        public MySQLSampleContext (DbContextOptions<MySQLSampleContext> options) : base(options) { }

        public DbSet<MySQLSample.Models.User> User { get; set; } = default!;
    }
}
