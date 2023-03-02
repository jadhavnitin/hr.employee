using hr.employee.Model;
using Microsoft.EntityFrameworkCore;

namespace hr.employee.main.Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employee {get;set;}
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
    }
}
