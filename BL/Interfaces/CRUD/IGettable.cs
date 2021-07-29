using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces.CRUD
{
    /// <summary>
    /// Interface for getting all entities.
    /// </summary>
    /// <typeparam name="TDto"></typeparam>
    public interface IGettable<TDto>
    {
        /// <summary>
        /// Interface method for getting all entities.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<IEnumerable<TDto>> GetAsync();
    }
}