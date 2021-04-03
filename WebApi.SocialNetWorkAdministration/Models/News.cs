﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.SocialNetWorkAdministration.Models
{
    public class News : BaseEntity
    {
        [ForeignKey("User")]
        public int AuthorId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public ICollection<Сomment> Сomments { get; set; }
        public News()
        {
            Сomments = new List<Сomment>(); 
        }
    }
}
