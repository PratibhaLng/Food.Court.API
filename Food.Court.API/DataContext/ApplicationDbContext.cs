using Microsoft.EntityFrameworkCore;
using Food.Model;
//using System.Data.Entity;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Food.Court.API.DBContext
{
    public class ApplicationDbContext: DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        
        {


        }

        public DbSet<Category> Category { get; set; }

    }
}
