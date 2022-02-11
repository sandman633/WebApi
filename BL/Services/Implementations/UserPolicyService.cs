using BL.Services.Interfaces;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
    public class UserPolicyService : BaseService<UserPolicyDto, UserPolicy>, IUserPolicyService
    {
        public UserPolicyService(IUserPolicyRepository crudRepository) : base(crudRepository)
        {

        }

        public async Task<Dictionary<string, short>> GetPolicy(int userId)
        {
            var userPolicy  = await _crudRepository.GetByCriteriaAsync(u => u.UserId == userId);
            return userPolicy.Select(u => KeyValuePair.Create<string,short>(u.PolicyType,u.PolicyValue)).ToDictionary(kpv=>kpv.Key,kpv=>kpv.Value);
        }
    }
}
