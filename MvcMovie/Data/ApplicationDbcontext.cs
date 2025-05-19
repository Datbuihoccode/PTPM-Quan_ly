using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie.Models.Entities;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Employees> Employees { get; set; } = default!;
        public DbSet<MemberUnit> MemberUnit { get; set; } = default!;
    }
}
