using AutoMapper;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations
{
    public class CommentsRepository : BaseRepository<CommentsDto, Comments>, ICommentsRepository
    {
        public CommentsRepository(WebApiContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Comments> DefaultIncludeProperties(DbSet<Comments> dbSet)
        {
            return base.DefaultIncludeProperties(dbSet).Include(er => er.LinkedComment).Include(er => er.User).Include(er => er.News).Include(er => er.LinkedComment.User);
        }


    }
}
