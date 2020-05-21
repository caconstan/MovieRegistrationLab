using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieRegistrationLab21.Models
{
    public class MovieModel
    {
        [Required(ErrorMessage = "Please enter a unique identifier for this movie")]
        public string ID { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 10 characters")]
        public string Title { get; set; }
        [Required] 
        public string Genre { get; set; }

        [Range(1900, 2020, ErrorMessage = "Year must be between 1900 and 2020")]
        public int Year { get; set; }
        [Required] 
        public string Actors { get; set; }
        [Required] 
        public string Directors { get; set; }
    }
}
