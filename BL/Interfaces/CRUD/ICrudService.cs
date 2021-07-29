using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Interfaces.CRUD
{
    /// <summary>
    /// Interface for base operations(CRUD).
    /// </summary>
    /// <typeparam name="TDto"></typeparam>
    public interface ICrudService<TDto> :
        ICreatable<TDto>,
        IDeletable,
        IGettable<TDto>,
        IGettableById<TDto>,
        IUpdatable<TDto>
    {

    }

}
