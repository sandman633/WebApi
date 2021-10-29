using Bl.Services.Interfaces.CRUD;
using Models.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services.Interfaces
{
    public interface INewsService : ICrudService<NewsDto>
    {
        
    }
}
