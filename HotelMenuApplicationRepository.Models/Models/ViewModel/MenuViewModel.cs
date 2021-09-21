using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace HotelMenuApplicationRepository.Models.Models.ViewModel
{
    public class MenuViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the dish name")]
        [MaxLength(50, ErrorMessage = "Dish Name should be between 50 characters")]
        [Display(Name = "Dish Name")]
        public string DishName { get; set; }

        [Required(ErrorMessage = "Please enter the description")]
        [MaxLength(100, ErrorMessage = "Dish description should be between 100 characters")]
        [Display(Name = "Dish Description ")]
        public string DishDescription { get; set; }

        [Required(ErrorMessage = "Please select veg or non-veg")]
        [Display(Name = "Veg/Non-Veg")]
        public string VegOrNonVeg { get; set; }

        [Required(ErrorMessage = "Please select the category")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Enter the price")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]
        [Display(Name = "Dish Image")]
        public IFormFile DishImage { get; set; }
    }
}
