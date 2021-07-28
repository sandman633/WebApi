using AutoMapper;
using Models.Dto;
using DAL.Domain;

namespace Repositories.Mappings
{
    /// <summary>
    /// Mapping profile for "UserRole" entity.
    /// </summary>
    public class UserRoleProfile : Profile
    {
        /// <summary>
        /// Initializes the instance <see cref="UserRoleProfile"/>.
        /// </summary>
        public UserRoleProfile()
        {
            CreateMap<UserRole, UserRoleDto>().ReverseMap();
        }
    }
}
