using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dto
{
    public class NewsDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        //public IEnumerable<CommentDto> Сomments { get; set; }
        //public NewsDto()
        //{
        //    Сomments = new List<CommentDto>();
        //}
    }
}
