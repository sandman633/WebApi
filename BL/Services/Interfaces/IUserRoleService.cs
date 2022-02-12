using Bl.Services.Interfaces.CRUD;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Interfaces
{
    public interface IUserRoleService : ICrudService<UserRoleDto>
    {
        //public Task<UserDto> BanUser(UserRoleDto id);
        //public Task<UserDto> UnBanUser(UserRoleDto id);
    }
}
