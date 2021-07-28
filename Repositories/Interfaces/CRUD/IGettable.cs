using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Interface for getting all entities.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// /// <typeparam name="TEntity">Entity type.</typeparam>
    public interface IGettable<TDto, TEntity>
    {
        /// <summary>
        /// Returns all entities.
        /// </summary>
        Task<IEnumerable<TDto>> GetAsync();

    }
}