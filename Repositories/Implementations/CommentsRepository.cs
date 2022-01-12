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





    }
}
