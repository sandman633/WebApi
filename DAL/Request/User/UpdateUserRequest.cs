using System.ComponentModel.DataAnnotations;

namespace DAL.Request.User
{
    /// <summary>
    /// Update request for user.
    /// </summary>
    public class UpdateUserRequest : NewUserRequest
    {
        /// <summary>
        /// Id.
        /// </summary>
        [Required]
        public int Id { get; set; }
    }
}
