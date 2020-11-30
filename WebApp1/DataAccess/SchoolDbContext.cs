using System.Data.Entity;
using WebApp1.Models;

namespace WebApp1.DataAccess
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