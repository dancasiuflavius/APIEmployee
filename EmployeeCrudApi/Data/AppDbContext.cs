using Microsoft.EntityFrameworkCore;
using EmployeeCrudApi.Employees.Model;

namespace EmployeeCrudApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
