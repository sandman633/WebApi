using AutoMapper;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations
{
    public class CommentsRepository : BaseRepository<CommentsDto, Comments>, ICommentsRepository
    {
        public CommentsRepository(WebApiContext context, IMapper mapper) : base(context, mapper)
        {
        }


        public async Task<CommentsDto> LeaveComment(CommentsDto comment)
        {
            if(comment.LinkedCommentId == null)
            {
                var linkedComment = await GetByIdAsync((int)comment.LinkedCommentId);
                if (linkedComment.Root == 5)
                {
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
