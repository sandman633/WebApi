using AutoMapper;
using Microsoft.EntityFrameworkCore;
using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories
{
    //public class AdminRepository : IAdminRepository
    //{

    //    private readonly WebApiContext _adminContext;
    //    private readonly IMapper _mapper;

    //    public AdminRepository(WebApiContext adminContext, IMapper mapper)
    //    {
    //        _adminContext = adminContext;
    //        _mapper = mapper;
    //    }

    //    public void BanUser(int userId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<News> CreateNews()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void DeleteComment(int commentId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void DeleteNews(int newsId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void EditNews(int newsId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<IEnumerable<NewsResponse>> GetNews()
    //    {
    //        DbSet<News> n = _adminContext.News;
    //        DbSet<User> u = _adminContext.Users;
    //        DbSet<Сomment> c = _adminContext.Comments;
    //        var allnews = _mapper.Map<IEnumerable<NewsResponse>>(n.AsEnumerable());
    //        foreach (var news in allnews)
    //        {
    //            news.AuthorName = u.Where(x => x.Id == news.AuthorId).Select(x => x.Name).FirstOrDefault();
    //            news.Сomments = c.Where(x => x.NewsId.Id == news.Id).Select(x => x).ToList();
    //        }
    //        return allnews;
    //    }

    //    public void UnbanUser(int userId)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
