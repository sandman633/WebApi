using AutoMapper;
using DAL.Dto;
using DAL.Request.News;
using DAL.Response.News;
using Model.Domain;

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
            CreateMap<NewsDto, NewsResponse>()
                .ForMember(x => x.AuthorId, y => y.MapFrom(src => src.UserId ))
                .ForMember(x => x.AuthorName, y => y.MapFrom(src => src.User.Name+' '+src.User.Surname));
            CreateMap<NewNewsRequest, NewsDto>()
                .ForMember(x => x.UserId, y => y.MapFrom(src => src.AuthorId ));
        }
    }
}
