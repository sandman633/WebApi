﻿using System.Collections.Generic;

namespace Models.Dto
{
    public class RoleDto : BaseDto
    {
        /// <summary>
        /// User role in the system.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Employee roles.
        /// </summary>
        public ICollection<UserRoleDto> UserRoles { get; set; }
    }
}