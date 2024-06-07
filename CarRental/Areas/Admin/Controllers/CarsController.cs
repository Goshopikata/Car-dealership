namespace CarRental.Areas.Admin.Controllers
{
    using CarRental.Services.Cars;
    using Microsoft.AspNetCore.Mvc;

    public class CarsController : AdminController
    {
        private readonly ICarService cars;

        public CarsController(ICarService cars) => this.cars = cars;

        public IActionResult All()
        {
            var cars = this.cars
                .All(publicOnly: false)
                .Cars;

            return View(cars);
        }

        public IActionResult ChangeVisibility(int id)
        {
            cars.ChangeVisility(id);

            return RedirectToAction(nameof(All));
        }
    }
}
