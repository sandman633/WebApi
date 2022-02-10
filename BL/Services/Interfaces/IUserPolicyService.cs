using Bl.Services.Interfaces.CRUD;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services.Interfaces
{
    public interface IUserPolicyService : ICrudService<UserPolicyDto>
    {
        Dictionary<string,short> GetPolicy(int userId);
    }
}
