using AutoMapper;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Dto;
using Models.Request.Comments;
using Models.Request.User;
using Models.Response.Comments;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WebApi.SocialNetWorkAdministration.Swagger;

namespace WebApi.SocialNetWorkAdministration.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = SwagDocParts.Comments)]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsService _commentsService;
        private readonly IMapper _mapper;
        private readonly ILogger<CommentsController> _logger;

        public CommentsController(ICommentsService commentsService, IMapper mapper, ILogger<CommentsController> logger)
        {
            _commentsService = commentsService;
            _mapper = mapper;
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CommentsResponse>))]
        public async Task<IActionResult> GetAsync()
        {
            _logger.LogInformation("Comments/Get was requested.");
            var response = await _commentsService.GetAsync();
            return Ok(_mapper.Map<IEnumerable<CommentsResponse>>(response));
        }


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CommentsResponse))]
        public async Task<IActionResult> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Comments/GetById was requested.");
            var response = await _commentsService.GetByIdAsync(id);
            return Ok(_mapper.Map<CommentsResponse>(response));
        }
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Comments/Delete was requested.");
            await _commentsService.DeleteAsync(id);
            return NoContent();
        }
        [HttpPost("Update")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CommentsResponse))]
        public async Task<IActionResult> UpdateAsync(UpdateCommentRequest comment, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Comments/Update was requested.");
            var commentDto = _mapper.Map<CommentsDto>(comment);
            var response = await _commentsService.UpdateAsync(commentDto);
            return Ok(_mapper.Map<CommentsResponse>(response));
        }
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CommentsResponse))]
        public async Task<IActionResult> CreateAsync(NewCommentRequest comment, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Comments/Create was requested.");
            var commentDto = _mapper.Map<CommentsDto>(comment);
            var response = await _commentsService.LeaveComment(commentDto);
            return Ok(_mapper.Map<CommentsResponse>(response));
        }
    }
}
