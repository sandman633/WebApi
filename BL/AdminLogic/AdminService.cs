﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using Model.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.AdminLogic
{
    public class AdminService : IAdminService
    {
        private AdminContext _adminContext;
        private IMapper _mapper;
        public AdminService(AdminContext adminContext, IMapper mapper)
        {
            _adminContext = adminContext;
            _mapper = mapper;
        }
        public void BanUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<News> CreateNews()
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public void DeleteNews(int newsId)
        {
            throw new NotImplementedException();
        }

        public void EditNews(int newsId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NewsResponse>> GetNews()
        {
            DbSet<News> n = _adminContext.News;
            DbSet<User> u = _adminContext.Users;
            DbSet<Сomment> c = _adminContext.Comments;
            var allnews = _mapper.Map<IEnumerable<NewsResponse>>(n.AsEnumerable());
            foreach(var news in allnews)
            {
                news.AuthorName =  u.Where(x => x.Id == news.AuthorId).Select(x => x.Name).FirstOrDefault();
                news.Сomments = c.Where(x => x.NewsId == news.Id).Select(x => x).ToList();
            }
            return allnews;
        }

        public void UnbanUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}