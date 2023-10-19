using System.ComponentModel.DataAnnotations;

namespace CarRental_BlazorApp.Models
{
    public class DisplayClientModel
    {
        public int Client_id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name is too long")]
        [MinLength(2, ErrorMessage = "First name is too short")]
        public string Name { get; set; }
        

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "phone number is too long")]
        [MinLength(6, ErrorMessage = "phone number is too short")]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(75, ErrorMessage ="Email Too long")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "password is too long")]
        [MinLength(6, ErrorMessage = "password is too short")]
        public string Password { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Licence Type is too long")]
        [MinLength(6, ErrorMessage = "Licence Type is too short")]
        public string LicenceType { get; set; }

        [Required]
        public string Company { get; set; }
    }
}
