using CarRental.Models;
using CarRental.Services.Cars;
using CarRental.Services.Cars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarService cars;
        private readonly IMemoryCache cache;

        public HomeController(
            ICarService cars,
            IMemoryCache cache)
        {
            this.cars = cars;
            this.cache = cache;
        }

        public IActionResult Index()
        {
            var latestCars = this.cache.Get<List<LatestCarServiceModel>>(WebConstants.LatestCarsCacheKey);

            if (latestCars == null)
            {
                latestCars = this.cars
                   .Latest()
                   .ToList();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromMinutes(15));

                this.cache.Set(WebConstants.LatestCarsCacheKey, latestCars, cacheOptions);
            }

            return View(latestCars);
        }

        public IActionResult Error() => View();
        public IActionResult Info() => View();
        public IActionResult ExtraInfo() => View();
    }
}