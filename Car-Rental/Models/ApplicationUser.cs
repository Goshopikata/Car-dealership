using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Car_Rental.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public IEnumerable<Rental> Rental { get; set; }

    }
}
