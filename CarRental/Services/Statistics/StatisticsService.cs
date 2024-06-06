namespace CarRental.Services.Statistics
{
    using System.Linq;
    using CarRentingSystem.Data;

    public class StatisticsService : IStatisticsService
    {
        private readonly CarRentingDbContext data;

        public StatisticsService(CarRentingDbContext data)
            => this.data = data;

        public StatisticsServiceModel Total()
        {
            var totalCars = data.Cars.Count(c => c.IsPublic);
            var totalUsers = data.Users.Count();

            return new StatisticsServiceModel
            {
                TotalCars = totalCars,
                TotalUsers = totalUsers
            };
        }
    }
}
