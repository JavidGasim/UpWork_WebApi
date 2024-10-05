using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UpWork.Entities
{
    public class CustomIdentityUser : IdentityUser
    {
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        public string? Country { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }

    }
}
