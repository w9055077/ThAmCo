using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class MenuFoodItemDto
    {
        public int MenuFoodItemId { get; set; }
        public int MenuId { get; set; }
        public int FoodItemId { get; set; }
    }
}
