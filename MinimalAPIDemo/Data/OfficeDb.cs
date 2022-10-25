using Microsoft.EntityFrameworkCore;
using MinimalAPIDemo.Models;
namespace MinimalAPIDemo.Data
{
    public class OfficeDb : DbContext
    {
        public OfficeDb(DbContextOptions<OfficeDb> options) : base(options)
        {

        }
        public DbSet<Employee> Employees => Set<Employee>();
    }
}

