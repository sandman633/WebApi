using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models
{
    public class Сomment : BaseEntity
    {
        public int Root { get; set; }
        [ForeignKey("User")]
        public int Author { get; set; }
        public string Text { get; set; }
        public int InvestmentLevel { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }

    }
}
