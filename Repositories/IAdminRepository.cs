using Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAdminRepository
    {
        public Task<IEnumerable<News>> GetNews();
        public Task<News> CreateNews();
        public void EditNews(int newsId);
        public void DeleteNews(int newsId);
        public void DeleteComment(int commentId);
        public void BanUser(int userId);
        public void UnbanUser(int userId);
    }
}
