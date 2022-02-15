using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Request.Authentificate
{
    /// <summary>
    /// Authentication request.
    /// </summary>
    public class AuthRequest
    {
        /// <summary>
        /// User email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }
    }
}
