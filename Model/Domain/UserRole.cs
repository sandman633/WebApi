namespace DAL.Domain
{
     /// <summary>
     /// Link relationship between <see cref="User"/> and <see cref="Role"/>.
     /// </summary>
     public class UserRole : BaseEntity
     {
         /// <summary>
         /// User id.
         /// </summary>
         public int UserId { get; set; }

         /// <summary>
         /// User.
         /// </summary>
         public User User { get; set; }

         /// <summary>
         /// Role id.
         /// </summary>
         public int RoleId { get; set; }

         /// <summary>
         /// Role.
         /// </summary>
         public Role Role { get; set; }
     }
}
