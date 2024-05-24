using System.Collections.Generic;
namespace Car_Rental.Models
{
    public class Model
    {
        public int Id { get; set; }
        public decimal DailyHireRate { get; set; }
        public string Name { get; set; }
        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public IEnumerable<Rental> Rentals { get; set; }
    }
}
