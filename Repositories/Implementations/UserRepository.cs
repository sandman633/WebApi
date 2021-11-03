using AutoMapper;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations
{
    public class UserRepository :  BaseRepository<UserDto,User>, IUserRepository
    {
        public UserRepository(WebApiContext context, IMapper mapper):base(context, mapper)
        {

        }

        protected override IQueryable<User> DefaultIncludeProperties(DbSet<User> dbSet)
        {
            return base.DefaultIncludeProperties(dbSet).Include(er => er.UserRoles);
        }

    }
}
