using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Domain
{
    public class Сomment : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public int Root { get; set; }
        public string Text { get; set; }
        public News News { get; set; }
        public int NewsId { get; set; }
        public Сomment LinkedComment { get; set; }
        public int? LinkedCommentId { get; set; }
    }
}
