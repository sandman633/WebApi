using BL.Services.Interfaces;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Implementations
{
    public class CommentsService : BaseService<CommentsDto,Comments>, ICommentsService
    {
        public CommentsService(ICommentsRepository crudRepository) : base(crudRepository)
        {
        }

        public async Task<CommentsDto> LeaveComment(CommentsDto comment)
        {
            if (comment.LinkedCommentId != null)
            {
                var linkedComment = await GetByIdAsync((int)comment.LinkedCommentId);
                if (linkedComment.Root == 5)
                {
                    //TODO: добавить эксепшп для коммента 
                    return null;
                }
                comment.Root = linkedComment.Root++;
                return await CreateAsync(comment);
            }
            comment.Root = 1;
            return await CreateAsync(comment);
        }
    }
}
