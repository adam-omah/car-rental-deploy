using System.ComponentModel.DataAnnotations;

namespace CarRental_BlazorApp.Models
{
    public class DisplayCarType
    {

        [Required]
        [StringLength(20, ErrorMessage = "Car Type is too long")]
        [MinLength(2, ErrorMessage = "Car Type is too short")]
        public string CarType { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Description is too long")]
        [MinLength(5, ErrorMessage = "Description is too short")]
        public string Description { get; set; }
    }
}
