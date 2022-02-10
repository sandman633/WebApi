using AutoMapper;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories.Implementations
{
    public class UserRoleRepository : BaseRepository<UserRoleDto, UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(WebApiContext context, IMapper mapper) : base(context, mapper)
        {
            
        }

        public override IQueryable<UserRole> DefaultIncludeProperties(DbSet<UserRole> dbSet)
        {
            return base.DefaultIncludeProperties(dbSet);
        }
    }
}
