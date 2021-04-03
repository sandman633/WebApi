using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.SocialNetWorkAdministration.Models;
using static WebApi.SocialNetWorkAdministration.Models.User;

namespace WebApi.SocialNetWorkAdministration
{
    public  class SeedDb
    {
        AdminContext Context;
        public SeedDb(AdminContext context)
        {
            Context = context;
        }
        public List<User> users = new List<User>()
        {
            new User
            {
                Id = new Guid(),
                Name = "user1",
                Email = "user1@mail.ru",
                Role =  new Roles[] { Roles.user },
                Password = "1234"
            },
            new User
            {
                Id = new Guid(),
                Name = "user2",
                Email = "user2@mail.ru",
                Role =  new Roles[] { Roles.user },
                Password = "12345"
            },
            new User
            {
                Id = new Guid(),
                Name = "user3",
                Email = "user3@mail.ru",
                Role =  new Roles[] { Roles.admin },
                Password = "4321"
            }
        };


        public void Seed()
        {
            Context.Users.AddRange(users);
            Context.SaveChanges();
        }


    }
}
