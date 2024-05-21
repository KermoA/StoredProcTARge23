using Microsoft.EntityFrameworkCore;
using StoredProcTARge23.Models;


namespace StoredProcTARge23.Data
{
    public class StoredProcDbContext : DbContext
    {
        public StoredProcDbContext(DbContextOptions<StoredProcDbContext> options)
            : base() { }

        public DbSet<Employee> Employees { get; set; }
    }
}
