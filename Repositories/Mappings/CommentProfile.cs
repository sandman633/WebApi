using AutoMapper;
using Models.Dto;
using DAL.Domain;
using Models.Response.Comments;

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
            CreateMap<CommentsDto, CommentsResponse>()
                .ForMember(x => x.UserName, y => y.MapFrom(src =>  $"{src.User.Name} {src.User.Surname}" ))
                .ForMember(x => x.CommentId, y => y.MapFrom(src => src.Id ));
        }
    }
}
