using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class Menu
    {

        public Menu()
        {
        }

        public Menu(string menuname) : this()
        {
            MenuName = menuname;
        }
        public int MenuId { get; set; }

        [Required]
        public String MenuName { get; set; }
    }
}
