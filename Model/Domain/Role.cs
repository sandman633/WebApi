using System.Collections.Generic;

namespace DAL.Domain
{

    public class Role : BaseEntity
    {
        /// <summary>
        /// User role in the system.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Employee roles.
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }
    }

}
