using System.Collections.Generic;

namespace PXL.Weightwatchers.Classes
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
