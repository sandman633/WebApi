using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IUserPolicyRepository : ICrudRepository<UserPolicyDto, UserPolicy>
    {
    }
}
