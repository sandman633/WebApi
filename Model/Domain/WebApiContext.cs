using Microsoft.EntityFrameworkCore;
using System;
using System.Text;

namespace DAL.Domain
{
    public class WebApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<Comments> Comments { get; set; }

        public WebApiContext(DbContextOptions options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User[]
                {
                new User { Id=1, Name="Tom",    Age=23, Email ="emTom@gmail.com",   Password = "123123", Surname = "Surname"},
                new User { Id=2, Name="Alice",  Age=26, Email ="emAlice@gmail.com", Password = "123123", Surname = "Surname"},
                new User { Id=3, Name="Sam",    Age=28, Email ="emSam@gmail.com",   Password = "123123", Surname = "Surname"}
                });
            modelBuilder.Entity<News>().HasData(
                new News[]
                {
                    new News {Id=1, UserId = 1, Body = "BodyNews1", Header = "Header1" },
                    new News {Id=2, UserId = 2, Body = "BodyNews2", Header = "Header2" },
                    new News {Id=3, UserId = 2, Body = "BodyNews3", Header = "Header3" }
                });
        }
    }
}
