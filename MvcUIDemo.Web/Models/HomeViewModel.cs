using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIDemo.Web.Models
{
    public class HomeViewModel
    {
        public AgentProfileViewModel AgentProfile { get; set; }
        public IList<ActiveProperties> PropertyList { get; set; }
        public IList<SalesViewModel> PastSalesList { get; set; }
        public RatingsReviewViewModel RatingsAndReviews { get; set; }
    }
}
