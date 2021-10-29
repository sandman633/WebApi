using AutoMapper;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementations
{
    public class NewsRepository : BaseRepository<NewsDto, News>, INewsRepository
    {
        public NewsRepository(WebApiContext context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
