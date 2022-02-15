using Bl.Services.Interfaces.CRUD;
using DAL.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Services.Interfaces
{
    public interface IUserPolicyService : ICrudService<UserPolicyDto>
    {
        Task<Dictionary<string, short>> GetPolicy(int userId);
    }
}
