using System.ComponentModel.DataAnnotations;

namespace Models.Request.User
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
