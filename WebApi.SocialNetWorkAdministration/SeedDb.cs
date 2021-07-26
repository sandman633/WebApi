using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DAL.Domain.User;

namespace WebApi.SocialNetWorkAdministration
{
    public  class SeedDb
    {
        //WebApiContext Context;
        //public SeedDb(WebApiContext context)
        //{
        //    Context = context;
        //}
        //public List<User> users = new List<User>()
        //{
        //    new User
        //    {
                
        //        Name = "user1",
        //        Email = "user1@mail.ru",
        //        Role =  new Roles[] { Roles.user },
        //        Password = "1234",
        //        State = false
        //    },
        //    new User
        //    {
                
        //        Name = "user2",
        //        Email = "user2@mail.ru",
        //        Role =  new Roles[] { Roles.user },
        //        Password = "12345",
        //        State = false
        //    },
        //    new User
        //    {
                
        //        Name = "user4",
        //        Email = "user4@mail.ru",
        //        Role =  new Roles[] { Roles.user },
        //        Password = "swag",
        //        State = true
        //    },
        //    new User
        //    {
                
        //        Name = "user3",
        //        Email = "user3@mail.ru",
        //        Role =  new Roles[] { Roles.admin },
        //        Password = "4321",
        //        State = false
        //    }
        //};
        //public List<News> news = new List<News>()
        //{
        //    new News
        //    {
                
        //        Body = "В Государственную думу внесён законопроект, предусматривающий введение ограничений для отдельных граждан на участие в избирательном процессе в качестве избирателя.",
        //        Header = "В Госдуму внесли законопроект о выборочном лишении граждан избирательных прав"
        //    },
        //    new News
        //    {
                
        //        Body = "Американский IT-гигант Google потерял более 10 % капитализации на утренних торгах в Нью-Йорке. После появления в СМИ информации о перезапуске в новом формате ведущей российской видеоплатформы RuTube стоимость акций компании опустилась до с 250 до 220 долларов, после сообщения о перезапуске ведущей российской видеоплатформы RuTube.",
        //        Header = "Акции Google рухнули после объявления о перезапуске RuTube"
        //    }
        //};
        //public List<Сomment> comments = new List<Сomment>()
        //{
        //    new Сomment
        //    {
        //        Author = 1,
        //        NewsId = 1,
        //        Root = 0,
        //        Text = "NOVOST-1 AUTHORID-1 ROOT-0 ID-1",
        //        InvestmentLevel = 0
        //    },
        //    new Сomment
        //    {
        //        Author = 2,
        //        NewsId = 1,
        //        Root = 1,
        //        Text = "NOVOST-1 AUTHORID-2 ROOT-1 ID-2",
        //        InvestmentLevel = 0
        //    },
        //    new Сomment
        //    {
        //        Author = 2,
        //        NewsId = 2,
        //        Root = 0,
        //        Text = "NOVOST-2 AUTHORID-2 ROOT-0 ID-3",
        //        InvestmentLevel = 0
        //    }

        //};
        //public void Seed()
        //{
        //    Context.Users.AddRange(users);
        //    Context.SaveChanges();
        //    news[0].AuthorId = users[0].Id;
        //    news[1].AuthorId = users[1].Id;
        //    Context.News.AddRange(news);
        //    Context.Comments.AddRange(comments);
        //    Context.SaveChanges();
        //}


    }
}
