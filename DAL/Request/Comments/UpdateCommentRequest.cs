using System.ComponentModel.DataAnnotations;

namespace DAL.Request.Comments
{
    /// <summary>
    /// Update request for Comment.
    /// </summary>
    public class UpdateCommentRequest : NewCommentRequest
    {
        /// <summary>
        /// Id.
        /// </summary>
        [Required]
        public int Id { get; set; }
    }
}
