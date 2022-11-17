using Microsoft.EntityFrameworkCore;
using BulkyBookWeb.Models;
namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        //Create tables with migration.
        public DbSet<Category> Categories { get; set; }
    }
}
