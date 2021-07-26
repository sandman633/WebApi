using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Domain
{
    public class Сomment : BaseEntity
    {
        public int Root { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }
        public int InvestmentLevel { get; set; }
        public News News { get; set; }
        public ICollection<Сomment> Comments { get; set; }

    }
}
