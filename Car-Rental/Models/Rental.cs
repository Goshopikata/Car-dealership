using System;
namespace Car_Rental.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int StatusID { get; set; }
        public Status Status   { get; set; }
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
        public string ApplicationUserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
