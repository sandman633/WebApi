using AutoMapper;
using Models.Dto;
using DAL.Domain;

namespace Repositories.Mappings
{
    /// <summary>
    /// Mapping profile for "Сomment" entity.
    /// </summary>
    public class CommentProfile : Profile
    {
        /// <summary>
        /// Initializes the instance <see cref="CommentProfile"/>.
        /// </summary>
        public CommentProfile()
        {
            CreateMap<Сomment, CommentDto>().ReverseMap();
        }
    }
}
