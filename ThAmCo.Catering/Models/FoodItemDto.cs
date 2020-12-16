using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class FoodItemDto
    {
        public int FoodItemId { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
    }
}
