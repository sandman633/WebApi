using Bl.Services.Interfaces.CRUD;
using DAL.Dto;
using System.Threading.Tasks;

namespace BL.Services.Interfaces
{
    public interface IUserService : ICrudService<UserDto>
    {
        /// <summary>
        /// Returns User by given email.
        /// </summary>
        /// <param name="email">Email</param>
        Task<UserDto> GetByEmailAsync(string email);
    }
}
