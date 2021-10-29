using BL.Services.Interfaces;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
    public class UserRoleService : BaseService<UserRoleDto, UserRole>, IUserRoleService
    {
        private IUserRepository _userRepository;
        public UserRoleService(IUserRoleRepository crudRepository,IUserRepository userRepository) : base(crudRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> BanUser(UserRoleDto user)
        {
            var rep = _crudRepository as IUserRoleRepository;
            var banneduser = await _userRepository.GetByIdAsync(user.UserId);
            if (banneduser == null)
                await rep.BanUser(user);
            else
                throw new NullReferenceException("Can't Ban user because user is not exist");
            
            return banneduser;
        }




        public async Task<UserDto> UnBanUser(UserRoleDto user)
        {
            var rep = _crudRepository as IUserRoleRepository;
            var banneduser = await _userRepository.GetByIdAsync(user.UserId);
            if(banneduser == null)
                await rep.UnBanUser(user.UserId);
            else
                throw new NullReferenceException("Can't Unban user because user is not exist");
            return banneduser;
        }
    }
}
