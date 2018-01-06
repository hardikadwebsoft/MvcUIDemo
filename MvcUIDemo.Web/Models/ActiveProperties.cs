using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIDemo.Web.Models
{
    public class ActiveProperties
    {
        public string PropertyImg { get; set; }
        public string PropertyAddress { get; set; }
        public string ImageCount { get; set; }
        public string Price { get; set; }
        public string PriceUpDown { get; set; }
        public bool IsPriceDown { get; set; }
        public bool IsFavorite { get; set; }
        public string NumOfBeds { get; set; }
        public string NumOfBaths { get; set; }
        public string Sqft { get; set; }
        public string Location { get; set; }
        public string SoldDate { get; set; }
    }
}
