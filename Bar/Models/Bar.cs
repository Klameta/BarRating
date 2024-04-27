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
        //[Required(ErrorMessage = "From field is required.")]
        [MaxLength(2 * 1024 * 1024, ErrorMessage = "Data size exceeds the maximum allowed size of 2 MB.")]
        public byte[] Photo { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public Bar()
        {
            Reviews = new List<Review>();
        }
    }
}
