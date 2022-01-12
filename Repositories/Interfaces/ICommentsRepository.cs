using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ICommentsRepository : ICrudRepository<CommentsDto, Comments>
    {
        
    }
}
