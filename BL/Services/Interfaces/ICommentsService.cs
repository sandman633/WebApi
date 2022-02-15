using Bl.Services.Interfaces.CRUD;
using DAL.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Interfaces
{
    public interface ICommentsService : ICrudService<CommentsDto>
    {
        Task<CommentsDto> LeaveComment(CommentsDto comment);
    }
}
