using AutoMapper;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.SocialNetWorkAdministration.Swagger;

namespace WebApi.SocialNetWorkAdministration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = SwagDocParts.News)]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;
        private readonly IMapper _mapper;

        public NewsController(INewsService newsService, IMapper mapper)
        {
            _newsService = newsService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(_newsService.GetAsync().Result);

        }
    }
}
