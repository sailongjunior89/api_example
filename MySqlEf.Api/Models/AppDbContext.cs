
using Microsoft.EntityFrameworkCore;

namespace MySqlEf.Api.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

        public DbSet<Person> Person { get; set; }
}