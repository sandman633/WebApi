using AutoMapper;
using BL.AdminLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Domain;
using DAL.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.SocialNetWorkAdministration.Swagger;

namespace WebApi.SocialNetWorkAdministration.Controllers
{
    [ApiController]
    [ApiExplorerSettings(GroupName = SwagDocParts.Administration)]
    public class AdminController : Controller
    {
        IMapper _mapper;
        IAdminService _service;
        
        public AdminController(IMapper Mapper, IAdminService service)
        {
            _mapper = Mapper;
            _service = service;
        }
        //[Authorize (Roles =("admin"))]
        [HttpGet] 
        [Route("[controller]/News")]
        public async Task<IActionResult> GetNews()
        {
            var news = await _service.GetNews();
            if(news != null)
            {
                return Ok(news);
            }
            return NotFound();
        }
    }
}
