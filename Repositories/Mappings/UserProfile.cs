using AutoMapper;
using Models.Dto;
using DAL.Domain;
using Models.Request.User;

namespace Repositories.Mappings
{
    /// <summary>
    /// Mapping profile for "User" entity.
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Initializes the instance <see cref="UserProfile"/>.
        /// </summary>
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserDto, UserResponse>().ReverseMap();
            CreateMap<NewUserRequest, UserDto>().ReverseMap();
            CreateMap<UpdateUserRequest, UserDto>().ReverseMap();
        }
    }
}
