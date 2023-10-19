using System.ComponentModel.DataAnnotations;

namespace CarRental_BlazorApp.Models
{
    public class DisplayCarModel
    {
        [Required]
        [StringLength(12, ErrorMessage = "First name is too long")]
        [MinLength(2, ErrorMessage = "First name is too short")]
        public string Registration { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Fuel Type too Long")]
        [MinLength(2, ErrorMessage = "Fuel Type is too short")]
        public string FuelType { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Fuel Type too Long")]
        [MinLength(2, ErrorMessage = "Model is too short")]
        public string Model { get; set; }
        [Required]
        [Range(0, 8, ErrorMessage = "Please enter valid number of passengers")]
        public int NumberOfPassengers { get; set; }
        [Required]
        [Range(0, 1000.00, ErrorMessage = "Please enter valid cost per day")]
        public float CostPerDay { get; set; }

        public char Status { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Car Type too Long")]
        [MinLength(2, ErrorMessage = "Car Type is too short")]
        public string CarType { get; set; }
    }
}
