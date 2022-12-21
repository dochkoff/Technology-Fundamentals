using System.ComponentModel.DataAnnotations;

namespace ParkingSystem.Data.Models
{
    public class Car
    {
        [Required]
        public string CarMake { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        [Required]
        public string TimeAdd { get; set; }
    }
}

