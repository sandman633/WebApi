using BL.Services.Interfaces;
using DAL.Domain;
using Models.Dto;
using Repositories.Interfaces;


namespace BL.Services.Implementations
{
    public class NewsService : BaseService<NewsDto, News>, INewsService
    {
        public NewsService(INewsRepository crudRepository) : base(crudRepository)
        {
        }

    }
}
