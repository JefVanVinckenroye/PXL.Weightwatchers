using PXL.Weightwatchers.Model.Enums;
using System;
using System.Collections.Generic;

namespace PXL.Weightwatchers.Classes
{
    public class Gerecht
    {
        public int Id { get; set; }
        public Schotel Schotel { get; set; }
        public string Omschrijving { get; set; }
        public List<Menu> Menus { get; set; }
        public int Score { get; set; }
    }
}
