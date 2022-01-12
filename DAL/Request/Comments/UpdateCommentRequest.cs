using System.ComponentModel.DataAnnotations;

namespace Models.Request.Comments
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
