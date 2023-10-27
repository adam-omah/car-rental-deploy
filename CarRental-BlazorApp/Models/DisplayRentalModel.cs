using System.ComponentModel.DataAnnotations;

namespace CarRental_BlazorApp.Models
{
    public class DisplayRentalModel
    {
        public string Rental_ID { get; set; }

        [Required]
       
        public DateTime StartDate { get; set; }
        
        [Required]
        public DateTime EndDate { get; set; }
       

        public DateTime PickUpDate { get; set; }
   
        
        public DateTime ReturnDate { get; set; }

        public char Status { get; set; }
        
        [Required]
        [StringLength(12, ErrorMessage = "Registration is too long")]
        [MinLength(2, ErrorMessage = "First name is too short")]
        public string CarRegistration { get; set; }

        [Required]
        public int Client_ID { get; set; }
    }
}
