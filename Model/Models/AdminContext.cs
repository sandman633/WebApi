using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class AdminContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Сomment> Comments { get; set; }

        public AdminContext(DbContextOptions options) : base(options)
        {

        }
    }
}
