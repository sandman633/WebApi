using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Domain
{
    public class WebApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Сomment> Comments { get; set; }

        public WebApiContext(DbContextOptions options) : base(options)
        {

        }
    }
}
