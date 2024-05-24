using System.Collections.Generic;
namespace Car_Rental.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int TypeId { get; set; }
        public VehicleType Type { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Rental> Rentals { get; set; }
    }
}
