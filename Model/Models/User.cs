using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
        public Roles[] Role { get; set; }

        public enum Roles
        {
            user,
            admin
        }

    }
}
