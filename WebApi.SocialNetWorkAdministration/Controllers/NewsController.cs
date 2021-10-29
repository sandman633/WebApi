using AutoMapper;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.SocialNetWorkAdministration.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;
        private readonly IMapper _mapper;

        public NewsController(INewsService newsService, IMapper mapper)
        {
            _newsService = newsService;
            _mapper = mapper;
        }
    }
}
