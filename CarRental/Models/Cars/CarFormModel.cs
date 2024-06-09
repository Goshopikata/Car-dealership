﻿namespace CarRental.Models.Cars
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using CarRental.Services.Cars.Models;

    using static Data.DataConstants.Car;

    public class CarFormModel : ICarModel
    {
        [Required(ErrorMessage = "Brand is mandatory.")]
        [StringLength(BrandMaxLength, MinimumLength = BrandMinLength, ErrorMessage = "Brand length should be between {2} and {1} characters.")]
        public string Brand { get; init; }

        [Required(ErrorMessage = "Model is mandatory.")]
        [StringLength(ModelMaxLength, MinimumLength = ModelMinLength, ErrorMessage = "Model length should be between {2} and {1} characters.")]
        public string Model { get; init; }

        [Required(ErrorMessage = "Description is mandatory.")]
        [StringLength(int.MaxValue, MinimumLength = DescriptionMinLength, ErrorMessage = "Description must be at least {2} characters long.")]
        public string Description { get; init; }

        [Required(ErrorMessage = "Image URL is mandatory.")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; }

        [Range(YearMinValue, YearMaxValue, ErrorMessage = "Year must be between {1} and {2}.")]
        public int Year { get; init; }

        public int CategoryId { get; init; }

        public IEnumerable<CarCategoryServiceModel> Categories { get; set; } = new List<CarCategoryServiceModel>();
    }
}
