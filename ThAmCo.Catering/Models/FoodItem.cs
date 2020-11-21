using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class FoodItem
    {
        public FoodItem()
        {
        }

        public FoodItem(string description, float unitprice) : this()
        {
            Description = description;
            UnitPrice = unitprice;
        }

        public int FoodItemId { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public float UnitPrice { get; set; }
    }
}
