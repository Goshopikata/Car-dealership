namespace CarRental.Infrastructure.Extensions
{
    using CarRental.Services.Cars.Models;

    public static class ModelExtensions
    {
        public static string GetInformation(this ICarModel car)
            => car.Brand + "-" + car.Model + "-" + car.Year;
    }
}
