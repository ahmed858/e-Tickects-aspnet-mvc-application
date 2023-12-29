using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Name bust Be 3 and 50 chars")]
        [RegularExpression("^[^0-9]+$", ErrorMessage = "Name should not contain numbers.")]
        public string FullName { get; set; }
        [Display(Name = "Profile Picture ")]
        [Required(ErrorMessage = "Profile Picture is Required")]

        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage = "Enter atleast one char")]

        [Display(Name = "Bio ")]

        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set;}
    }
}
