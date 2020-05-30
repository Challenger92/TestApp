using Microsoft.EntityFrameworkCore;
using TestApp.API.Models;

namespace TestApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}
        public DbSet<Employee> Employees { get; set; }
    }
}