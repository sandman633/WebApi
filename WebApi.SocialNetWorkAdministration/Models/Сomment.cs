using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.SocialNetWorkAdministration.Models
{
    public class Сomment : BaseEntity
    {
        public Guid Root { get; set; }
        [ForeignKey("User")]
        public Guid Author { get; set; }
        public string Text { get; set; }
        public int InvestmentLevel { get; set; } 

    }
}
