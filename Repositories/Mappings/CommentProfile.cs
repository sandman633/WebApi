using AutoMapper;
using Models.Dto;
using DAL.Domain;

namespace Repositories.Mappings
{
    /// <summary>
    /// Mapping profile for "Comments" entity.
    /// </summary>
    public class CommentProfile : Profile
    {
        /// <summary>
        /// Initializes the instance <see cref="CommentProfile"/>.
        /// </summary>
        public CommentProfile()
        {
            CreateMap<Comments, CommentsDto>().ReverseMap();
        }
    }
}
