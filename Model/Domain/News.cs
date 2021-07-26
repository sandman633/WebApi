using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Domain
{
    public class News : BaseEntity
    {
        public User Author { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public ICollection<Сomment> Сomments { get; set; }

    }
}
