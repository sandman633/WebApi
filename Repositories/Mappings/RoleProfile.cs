using AutoMapper;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Domain;

namespace Repositories.Mappings
{
    /// <summary>
    /// Mapping profile for "Role" entity.
    /// </summary>
    public class RoleProfile : Profile
    {
        /// <summary>
        /// Initializes the instance <see cref="RoleProfile"/>.
        /// </summary>
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
        }
    }

}
