using AutoMapper;
using Models.Dto;
using DAL.Domain;
using Models.Request.User;

namespace Repositories.Mappings
{
    /// <summary>
    /// Mapping profile for "News" entity.
    /// </summary>
    public class NewsProfile : Profile
    {
        /// <summary>
        /// Initializes the instance <see cref="NewsProfile"/>.
        /// </summary>
        public NewsProfile()
        {
            CreateMap<News, NewsDto>().ReverseMap();
        }
    }
}
