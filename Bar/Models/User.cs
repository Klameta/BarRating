using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;

namespace Data.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters.")]
        public string LastName { get; set; }

        public string Role { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public User()
        {
            Reviews = new List<Review>();
        }
    }
}
