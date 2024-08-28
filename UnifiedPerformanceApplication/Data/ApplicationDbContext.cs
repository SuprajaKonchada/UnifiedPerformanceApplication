using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UnifiedPerformanceApplication.Models;

namespace UnifiedPerformanceApplication.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

}
