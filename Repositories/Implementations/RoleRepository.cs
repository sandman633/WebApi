using AutoMapper;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
    public class RoleRepository : BaseRepository<RoleDto, Role>, IRoleRepository
    {
        public RoleRepository(WebApiContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
