using AutoMapper;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Dto;
using Models.Request.News;
using Models.Response.News;
using System.Collections.Generic;
using System.Threading;
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
        private readonly ILogger<NewsController> _logger;

        public NewsController(INewsService newsService, IMapper mapper, ILogger<NewsController> logger)
        {
            _newsService = newsService;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<NewsResponse>))]
        public async Task<IActionResult> GetAsync()
        {
            _logger.LogInformation("Users/Get was requested.");
            var response = await _newsService.GetAsync();
            return Ok(_mapper.Map<IEnumerable<NewsResponse>>(response));
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NewsResponse))]
        public async Task<IActionResult> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Users/GetById was requested.");
            var response = await _newsService.GetByIdAsync(id);
            return Ok(_mapper.Map<NewsResponse>(response));
        }
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NewsResponse))]
        public async Task<IActionResult> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Users/Delete was requested.");
            await _newsService.DeleteAsync(id);
            return NoContent();
        }
        [HttpPost("Update")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NewsResponse))]
        public async Task<IActionResult> UpdateAsync(UpdateNewsRequest news, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Users/Update was requested.");
            var newsDto = _mapper.Map<NewsDto>(news);
            var response = await _newsService.UpdateAsync(newsDto);
            return Ok(_mapper.Map<NewsResponse>(response));
        }
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NewsResponse))]
        public async Task<IActionResult> CreateAsync(NewNewsRequest news, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Users/Create was requested.");
            var newsDto = _mapper.Map<NewsDto>(news);
            var response = await _newsService.CreateAsync(newsDto);
            return Ok(_mapper.Map<NewsResponse>(response));
        }
    }
}
