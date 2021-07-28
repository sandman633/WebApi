namespace Models.Dto
{
    public class UserDto : BaseDto
    {
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Password.
        /// </summary>
        public string Password { get; set; }
    }
}