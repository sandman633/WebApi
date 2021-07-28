using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dto
{
    /// <summary>
    /// News Dto.
    /// </summary>
    public class NewsDto : BaseDto
    {
        /// <summary>
        /// Author.
        /// </summary>
        public UserDto  Author { get; set; }
        /// <summary>
        /// AuthorId.
        /// </summary>
        public int AuthorId { get; set; }
        /// <summary>
        /// News header. 
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// News body.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// News comments.
        /// </summary>
        public ICollection<CommentDto> Сomments { get; set; }
    }
}
