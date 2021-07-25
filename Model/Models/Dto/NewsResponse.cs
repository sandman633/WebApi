using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Model.Models.Dto
{
    public class NewsResponse
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public IEnumerable<Сomment> Сomments { get; set; }
        public NewsResponse()
        {
            Сomments = new List<Сomment>();
        }

    }
}
