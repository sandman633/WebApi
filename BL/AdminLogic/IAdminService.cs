using DAL.Domain;
using Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.AdminLogic
{
    public interface IAdminService
    {
        public Task<IEnumerable<NewsResponse>> GetNews();
        public Task<News> CreateNews();
        public void EditNews(int newsId);
        public void DeleteNews(int newsId);
        public void DeleteComment(int commentId);
        public void BanUser(int userId);
        public void UnbanUser(int userId);

    }
}
