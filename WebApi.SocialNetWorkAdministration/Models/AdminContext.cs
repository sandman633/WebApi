using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.SocialNetWorkAdministration.Models
{
    public class AdminContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public AdminContext(DbContextOptions options):base(options)
        {

        }
    }
}
