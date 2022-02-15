using AutoMapper;
using Model.Domain;
using Microsoft.EntityFrameworkCore;
using DAL.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Repositories.Implementations
{
    public class UserPolicyRepository : BaseRepository<UserPolicyDto, UserPolicy>, IUserPolicyRepository
    {
        public UserPolicyRepository(WebApiContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<UserPolicy> DefaultIncludeProperties(DbSet<UserPolicy> dbSet) => dbSet.Include(scr => scr.User);
    }
}
