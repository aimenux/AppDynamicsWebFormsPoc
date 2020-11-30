using System.Data.Entity;
using WebApp3.Models;

namespace WebApp3.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<SchoolDbContext>(new DatabaseContextInitializer());
        }
    }
}