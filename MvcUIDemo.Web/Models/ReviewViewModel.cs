using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIDemo.Web.Models
{
    public class ReviewViewModel : AgentProfileViewModel
    {
        public string Date { get; set; }
        public string ReviewNote { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewHome { get; set; }
    }
}
