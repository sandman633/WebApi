using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dto
{
    /// <summary>
    /// CommentDto.
    /// </summary>
    public class CommentDto : BaseDto
    {

        public UserDto User { get; set; }
        public int UserId { get; set; }
        public int Root { get; set; }
        public string Text { get; set; }
        public NewsDto News { get; set; }
        public int NewsId { get; set; }
        public CommentDto LinkedComment { get; set; }
        public int? LinkedCommentId { get; set; }
    }
}
