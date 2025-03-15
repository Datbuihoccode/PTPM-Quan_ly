using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data
{
    using Microsoft.EntityFrameworkCore;
    using MvcMovie.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
        public DbSet<MvcMovie.Models.Person> Person { get; set; } = default!;

public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;

public DbSet<MvcMovie.Models.Student> Student { get; set; } = default!;
        
    }
}