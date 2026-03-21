using Microsoft.EntityFrameworkCore;
using MvcProjectAspNet.Models;

namespace MvcProjectAspNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
    