using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcUIDemo.Web.Helpers;
using MvcUIDemo.Web.Models;

namespace MvcUIDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var dataHelper = new DataHelper();
            var model = new HomeViewModel
            {
                AgentProfile = dataHelper.GetAgentProfile(),
                PropertyList = dataHelper.GetActiveProperties(),
                PastSalesList = dataHelper.GetPastSales(),
                RatingsAndReviews = dataHelper.GetRatingsAndReviews()
            };
            return View(model);
        }
    }
}