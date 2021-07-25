using Model.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public class AdminRepository : IAdminRepository
    {
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

        public Task<IEnumerable<News>> GetNews()
        {
            throw new NotImplementedException();
        }

        public void UnbanUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
