using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using DAL.Domain;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApi.SocialNetWorkAdministration.Infrastructure.AuthOptions;
using WebApi.SocialNetWorkAdministration.Swagger;
using static DAL.Domain.User;

namespace WebApi.SocialNetWorkAdministration.Controllers
{
    [ApiController]
    [ApiExplorerSettings(GroupName = SwagDocParts.Administration)]
    public class AccountController : ControllerBase
    {
        IMapper _mapper;
        AdminContext _context;
        IOptions<AuthOption> _options;
        public AccountController(IMapper Mapper, AdminContext ctx, IOptions<AuthOption> options)
        {
            _mapper = Mapper;
            _context = ctx;
            _options = options;
        }
        [HttpPost]
        [Route("[controller]/Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (user != null)
            {
                var token = GenerateJWT(user);


                return Ok(new {
                access_token = token
                });
            }
            else
            {
                return Unauthorized();
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(NewUser))]
        [Route("[controller]/Registration")]
        public async Task<IActionResult> Registration(NewUser newuser)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == newuser.Email);
            if (user == null)
            {
                user = _mapper.Map<User>(newuser);
                user.Role = new Roles[] { Roles.user };
                _context.Add(user);
                _context.SaveChanges();
                return Ok(user);
            }
            else
            {
                return StatusCode(401, "User with this email already exist");
            }
        }

        private string GenerateJWT(User user)
        {
            var authParam = _options.Value;

            var securityKey = authParam.GetSymmetricSecurityKey();
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString())
            };

            foreach (var role in user.Role)
            {
                claims.Add(new Claim("Role", role.ToString()));
            }

            var token = new JwtSecurityToken(authParam.Issuer, authParam.Audience, claims, expires: DateTime.Now.AddSeconds(authParam.TokenLifeTime), signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
