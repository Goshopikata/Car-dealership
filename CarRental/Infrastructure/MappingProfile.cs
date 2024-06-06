﻿namespace CarRental.Infrastructure
{
    using AutoMapper;
    using CarRental.Services.Cars.Models;
    using CarRentingSystem.Data.Models;
    using CarRentingSystem.Models.Cars;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CarCategoryServiceModel>();

            CreateMap<Car, LatestCarServiceModel>();
            CreateMap<CarDetailsServiceModel, CarFormModel>();

            CreateMap<Car, CarServiceModel>()
                .ForMember(c => c.CategoryName, cfg => cfg.MapFrom(c => c.Category.Name));

            CreateMap<Car, CarDetailsServiceModel>()
                .ForMember(c => c.UserId, cfg => cfg.MapFrom(c => c.Dealer.UserId))
                .ForMember(c => c.CategoryName, cfg => cfg.MapFrom(c => c.Category.Name));
        }
    }
}
