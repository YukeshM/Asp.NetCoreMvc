using System.ComponentModel.DataAnnotations;

namespace HotelMenuRepository.Model.Models
{
    public class Menu
    {

        public int Id { get; set; }

        //public string Image { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Dish Name should be between 50 characters")]
        public string DishName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Dish description should be between 100 characters")]
        public string DishDescription { get; set; }

        [Required]
        public string VegOrNonVeg { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int Price { get; set; }

    }
}
