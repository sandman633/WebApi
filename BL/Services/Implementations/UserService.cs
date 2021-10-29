using AutoMapper;
using BL.Services.Interfaces;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
    public class UserService : BaseService<UserDto, User>, IUserService
    {
        public UserService(IUserRepository userRepository) :base(userRepository)
        {

        }
        public async Task<UserDto> GetByEmailAsync(string email)
        {
            var user = await _crudRepository.GetByCriteriaAsync( x=>x.Email==email);
            return user.SingleOrDefault();
        }
    }
}
