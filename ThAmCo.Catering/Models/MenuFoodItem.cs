using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class MenuFoodItem
    {
        public int MenuFoodItemId { get; set; }

        public int MenuId { get; set; }

        public int FoodItemId { get; set; }

        [Required]
        public FoodItem FoodItem { get; set; }

        [Required]
        public Menu Menu { get; set; }


    }
}
