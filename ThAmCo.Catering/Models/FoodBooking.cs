using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class FoodBooking
    {
        public FoodBooking()
        {
        }

        public FoodBooking(int numberofguests) : this()
        {
            NumberOfGuests = numberofguests;
        }

        public int FoodBookingId { get; set; }

        public int ClientReferenceId { get; set; }

        public int NumberOfGuests { get; set; }

        public int MenuId { get; set; }

        [Required]
        public Menu Menu { get; set; }
    }
}
