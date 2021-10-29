using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Request.News
{
    public class NewsRequest
    {
        public int UserId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}
