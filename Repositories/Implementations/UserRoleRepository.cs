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
        public UserRoleRepository(WebApiContext context,IUserRepository userRepository, IMapper mapper) : base(context, mapper)
        {
            _userRepository = userRepository;
        }

        private IUserRepository _userRepository;

        public async Task<UserDto> BanUser(UserRoleDto user)
        {
            var banneduser = await _userRepository.GetByIdAsync(user.UserId);
            if(banneduser == null)
                await CreateAsync(user);
            else
                throw new NullReferenceException("Can't Ban user because user is not exist");
            return banneduser;
        }

        public async Task<UserDto> UnBanUser(int id)
        {
            var banneduser = await _userRepository.GetByIdAsync(id);
            if (banneduser == null)
                await DeleteAsync(id);
            else
                throw new NullReferenceException("Can't Unban user because user is not exist");
            return banneduser;
        }
    }
}
