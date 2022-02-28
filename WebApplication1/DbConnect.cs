using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DbConnect:DbContext
    {
        public DbConnect()
        {

        }
        public DbConnect(DbContextOptions<DbConnect> options):base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
    }
}
