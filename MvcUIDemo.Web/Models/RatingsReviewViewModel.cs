using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIDemo.Web.Models
{
    public class RatingsReviewViewModel
    {
        public IList<ReviewViewModel> CustomerReviewsList { get; set; }
    }
}
