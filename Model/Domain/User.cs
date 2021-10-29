using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Domain
{
    public class User : BaseEntity
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Age.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Password.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// User roles.
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
