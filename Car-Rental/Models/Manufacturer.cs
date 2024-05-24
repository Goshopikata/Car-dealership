using System.Collections.Generic;
namespace Car_Rental.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public IEnumerable<Rental> Rentals { get; set; }
    }
}
