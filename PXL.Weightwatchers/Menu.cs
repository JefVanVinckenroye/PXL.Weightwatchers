using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PXL.Weightwatchers.Classes
{
    public class Menu
    {
        public int Id { get; set; }
        public DayOfWeek Dag { get; set; }
        public DateTime Datum { get; set; }
        public List<Gerecht> Schotels { get; set; }
        [Required]
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}
