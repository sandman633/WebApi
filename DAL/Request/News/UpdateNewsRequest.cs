using System.ComponentModel.DataAnnotations;

namespace Models.Request.News
{
    /// <summary>
    /// Update request for News.
    /// </summary>
    public class UpdateNewsRequest : NewNewsRequest
    {
        /// <summary>
        /// Id.
        /// </summary>
        [Required]
        public int Id { get; set; }
    }
}
