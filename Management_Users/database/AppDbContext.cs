using Microsoft.EntityFrameworkCore;
using Management_Users.entity; 

namespace Management_Users.database
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = "C:\\ManagementUsersDB";
            Directory.CreateDirectory(folder);

            var path = Path.Combine(folder, "management_users.db");
            optionsBuilder.UseSqlite($"Data Source={path}");
        }
    }
}
