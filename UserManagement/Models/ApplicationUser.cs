using Microsoft.AspNetCore.Identity;

namespace UserManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public ApplicationUser(string firstName, string lastName, string userName, string email) : base()
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    UserName = userName;
        //    Email = email;

        //}
        public string FirstName { get; set; } = string.Empty;
        public override string Email { get => base.Email; set => base.Email = value; }
        public string LastName { get; set; } = string.Empty;
        public int UserNameChangeLimit { get; set; } = 5;
        public byte[]? ProfilePicture { get; set; }
    }
}
