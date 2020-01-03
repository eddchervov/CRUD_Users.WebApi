using CRUD_Users.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Users.DAL.DBContext.Implementation
{
    internal class AppDBContext : BaseDbContext, IAppDBContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated(); // создаем базу данных при первом обращении
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            BuldUserTable(modelBuilder);
            BuldUserLogTable(modelBuilder);
        }

        #region helpers
        private void BuldUserTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable(name: "Users", schema: "dbo");

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(b => b.LastName)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(b => b.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(b => b.MiddleName)
                .HasMaxLength(100);
        }

        private void BuldUserLogTable(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLog>()
                .ToTable(name: "UserLogs", schema: "dbo");

            modelBuilder.Entity<UserLog>()
                .HasKey(ul => ul.Id);

            modelBuilder.Entity<User>()
                .Property(b => b.LastName)
                .HasMaxLength(100);

            modelBuilder.Entity<User>()
                .Property(b => b.FirstName)
                .HasMaxLength(100);

            modelBuilder.Entity<User>()
                .Property(b => b.MiddleName)
                .HasMaxLength(100);
        }
        #endregion
    }
}
