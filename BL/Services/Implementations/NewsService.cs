using BL.Services.Interfaces;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces.CRUD;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services.Implementations
{
    public class NewsService : BaseService<NewsDto, News>, INewsService
    {
        public NewsService(ICrudRepository<NewsDto, News> crudRepository) : base(crudRepository)
        {
        }

    }
}
