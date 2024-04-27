using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Bar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        [StringLength(64, ErrorMessage = "Name must be less than 64 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        [StringLength(255, ErrorMessage = "Description must be less than 255 characters.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        public string Photo { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public Bar()
        {
            Reviews = new List<Review>();
        }
    }
}
