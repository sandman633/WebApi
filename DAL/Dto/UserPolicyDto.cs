using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class UserPolicyDto : BaseDto
    {
        /// <summary>
        /// User id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        public UserDto User { get; set; }

        /// <summary>
        /// Policy Type.
        /// </summary>
        public string PolicyType { get; set; }

        /// <summary>
        /// Policy Value.
        /// </summary>
        public short PolicyValue { get; set; }
    }
}
