using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Bar
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        public byte[] Photo { get; set; }

        public virtual User User { get; set; }
    }
}
