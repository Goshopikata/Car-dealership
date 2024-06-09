namespace CarRental.Controllers
{
    using System.Linq;
    using CarRental.Data;
    using CarRental.Data.Models;
    using CarRental.Infrastructure.Extensions;
    using CarRental.Models.Dealers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static WebConstants;

    public class DealersController : Controller
    {
        private readonly RentalDbContext data;

        public DealersController(RentalDbContext data)
            => this.data = data;

        [Authorize]
        public IActionResult Become() => View();

        [HttpPost]
        [Authorize]
        public IActionResult Become(BecomeDealerFormModel dealer)
        {
            var userId = User.Id();

            var userIdAlreadyDealer = data
                .Dealers
                .Any(d => d.UserId == userId);

            if (userIdAlreadyDealer)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(dealer);
            }

            var dealerData = new Dealer
            {
                Name = dealer.Name,
                PhoneNumber = dealer.PhoneNumber,
                UserId = userId
            };

            data.Dealers.Add(dealerData);
            data.SaveChanges();

            TempData[GlobalMessageKey] = "Thank you for becomming a dealer!";

            return RedirectToAction(nameof(CarsController.All), "Cars");
        }
    }
}
