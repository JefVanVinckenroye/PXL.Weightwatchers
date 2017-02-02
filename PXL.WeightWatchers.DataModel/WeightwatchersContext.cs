using System.Data.Entity;
using PXL.Weightwatchers.Classes;

namespace PXL.WeightWatchers.DataModel
{
    public class WeightwatchersContext:DbContext
    {
        public DbSet<Gerecht> Gerechten { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Product> Producten { get; set; }
    }
}
