using System.Collections.Generic;
namespace Car_Rental.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public IEnumerable<Rental> Rentals { get; set; }
    }
}
