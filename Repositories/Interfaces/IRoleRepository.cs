using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    internal interface IRoleRepository : ICrudRepository<RoleDto,Role>
    {

    }
}
