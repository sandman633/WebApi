using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using Model.Models.Dto;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.AdminLogic
{
    public class AdminService : IAdminService
    {
        private readonly AdminContext _adminContext;
        private readonly IMapper _mapper;
        private readonly IAdminRepository _repository;

        public AdminService(AdminContext adminContext, IMapper mapper, IAdminRepository repository)
        {
            _adminContext = adminContext;
            _mapper = mapper;
            _repository = repository;
        }
        public void BanUser(int userId)
        {
            _repository.BanUser(userId);
        }

        public Task<News> CreateNews()
        {
            return _repository.CreateNews();
        }

        public void DeleteComment(int commentId)
        {
            _repository.DeleteComment(commentId);
        }

        public void DeleteNews(int newsId)
        {
            //TODO: изменить метод создания и изменения новости
            _repository.DeleteNews(newsId);
        }

        public void EditNews(int newsId)
        {
            _repository.EditNews(newsId);
        }

        public async Task<IEnumerable<NewsResponse>> GetNews()
        {
            var news = await _repository.GetNews();
            var response =  _mapper.Map<IEnumerable<NewsResponse>>(news);
            return  response;
        }

        public void UnbanUser(int userId)
        {
            _repository.UnbanUser(userId);
        }
    }
}
