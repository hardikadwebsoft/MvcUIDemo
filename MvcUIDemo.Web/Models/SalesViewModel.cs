using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIDemo.Web.Models
{
    public class SalesViewModel
    {
        public string PropertyImg { get; set; }
        public ActiveProperties Details { get; set; }
        public string Represented { get; set; }
    }
}
