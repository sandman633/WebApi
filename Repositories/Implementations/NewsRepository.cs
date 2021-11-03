using AutoMapper;
using DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementations
{
    public class NewsRepository : BaseRepository<NewsDto, News>, INewsRepository
    {
        public NewsRepository(WebApiContext context, IMapper mapper) : base(context, mapper)
        {

        }


        protected override IQueryable<News> DefaultIncludeProperties(DbSet<News> dbSet)
        {
            return base.DefaultIncludeProperties(dbSet).Include(er => er.User).Include(er => er.Сomments);
        }
    }
}
