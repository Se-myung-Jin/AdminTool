using AdminTool.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminTool.DataContext
{
    public class AdminUserContext : DbContext
    {
        public DbSet<AdminUser> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Database=admin;User=root;Password=123456");
        }
    }
}
