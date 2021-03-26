using AdminTool.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminTool.DataContext
{
    public class AdminUserContext : DbContext
    {
        public DbSet<AdminUser> User { get; set; }

        public DbSet<UserPermission> User_Permission { get; set; }

        // 복합 키 설정 오버라이딩 함수
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPermission>()
                .HasKey(k => new { k.Id, k.Permission_Id });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Database=admin;User=root;Password=123456");
        }
    }
}
