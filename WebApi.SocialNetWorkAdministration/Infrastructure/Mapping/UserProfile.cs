using AutoMapper;
using Model.Models;
using Model.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.SocialNetWorkAdministration.Infrastructure.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, NewUser>().ReverseMap();
            CreateMap<News, NewsResponse>().IncludeMembers();
        }
    }
}
