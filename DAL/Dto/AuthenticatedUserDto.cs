using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    /// <summary>
    /// DTO for authenticated User.
    /// </summary>
    public class AuthenticatedUserDto : BaseDto
    {
        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }
    }
}
