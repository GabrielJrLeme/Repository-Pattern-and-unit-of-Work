using Microsoft.EntityFrameworkCore;
using repository_pattern.Models;

namespace repository_pattern.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet <Costumers> Costumers { get; set; }

        public DbSet <Orders> Orders { get; set; }

    }
}
