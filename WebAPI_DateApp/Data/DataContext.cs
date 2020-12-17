using Microsoft.EntityFrameworkCore;
using WebAPI_DateApp.Entities;

namespace WebAPI_DateApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; }
    }
}