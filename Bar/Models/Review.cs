using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        [StringLength(64, ErrorMessage = "Name must be less than 64 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "From field is required.")]
        [StringLength(255, ErrorMessage = "Name must be less than 255 characters.")]
        public string Description { get; set; }

       public virtual Bar Bar { get; set; }
        public virtual User User { get; set; }
    }
}
