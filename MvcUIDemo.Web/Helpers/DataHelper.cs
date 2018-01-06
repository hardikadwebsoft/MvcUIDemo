using Microsoft.AspNetCore.Mvc.Rendering;
using MvcUIDemo.Web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIDemo.Web.Helpers
{
    public class DataHelper
    {
        public AgentProfileViewModel GetAgentProfile()
        {
            var agentProfile = new AgentProfileViewModel();

            agentProfile = new AgentProfileViewModel()
            {
                AgentLastname = "Melissa Crosby",
                AboutAgent = AboutAgent(),
                AgentObjectives = GetAgentObjective(),
                AgentProfPictPath = "img/agents/agent5.png",
                Brokerage = "Berkshire Hathaway HomeServices Elite Real Estate",
                Specialties = "Property Management, Buyer’s Agent, Listing Agent…",
                LicenseNumbers = "#5452129",
                Ratings = "4.5",
                ReviewCount = "16",
                LocalknowledgeRatings = "4.5",
                ProcessexpertiseRatings = "4.2",
                ResponsivenessRatings = "5.0",
                NegotiationskillsRatings = "4.1"
            };

            var ratings = decimal.Parse(agentProfile.Ratings, CultureInfo.InvariantCulture.NumberFormat);
            agentProfile.IntRatings = Convert.ToInt32(Math.Truncate(ratings));
            agentProfile.IsDecimal = true;
            return agentProfile;
        }

        public string AboutAgent()
        {
            return "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients.";
        }

        public string GetAgentObjective()
        {
            return "My objective is to establish relationships for life, not just for the current transaction. I enjoy assisting home buyers and sellers to get moved to a better place, one that is exciting.";
        }

        public IList<ActiveProperties> GetActiveProperties()
        {
            return new List<ActiveProperties>()
            {
                new ActiveProperties()
                {
                    ImageCount = "12",
                    IsFavorite = false,
                    NumOfBaths = "3.0",
                    NumOfBeds = "4",
                    PriceUpDown = "6,5",
                    IsPriceDown = true,
                    Price = "$345,000",
                    PropertyAddress = "472 Ponderosa Dr, Alpine",
                    PropertyImg = "img/property/home1.jpg",
                    Sqft = "2,785"
                },
                new ActiveProperties()
                {
                    ImageCount = "12",
                    IsFavorite = true,
                    NumOfBaths = "3.0",
                    NumOfBeds = "4",
                    PriceUpDown = "10",
                    IsPriceDown = false,
                    Price = "$345,000",
                    PropertyAddress = "472 Ponderosa Dr, Alpine",
                    PropertyImg = "img/property/home8.jpg",
                    Sqft = "2,785"
                },
                new ActiveProperties()
                {
                    ImageCount = "12",
                    IsFavorite = false,
                    NumOfBaths = "3.0",
                    NumOfBeds = "4",
                    PriceUpDown = null,
                    IsPriceDown = false,
                    Price = "$345,000",
                    PropertyAddress = "472 Ponderosa Dr, Alpine",
                    PropertyImg = "img/property/home11.jpg",
                    Sqft = "2,785"
                }
            };
        }

        public IList<SalesViewModel> GetPastSales()
        {
            return new List<SalesViewModel>()
            {
                new SalesViewModel()
                {
                    Details = new ActiveProperties()
                    {
                        Price = "$900,000",
                        Location = "Jamul, CA",
                        PropertyAddress = "3247 Greystone Dr • Jamul, CA 91935",
                        NumOfBeds = "7 bed",
                        NumOfBaths = "4 bath",
                        Sqft = "6,150 sqft",
                        SoldDate = "09/12/2017"
                    },
                    PropertyImg = "img/property/home5.jpg",
                    Represented = "Seller"
                },
                new SalesViewModel()
                {
                    Details = new ActiveProperties()
                    {
                        Price = "$490,000",
                        Location = "El Cajon, CA",
                        PropertyAddress = "9951 Watergum Trl • Santee, CA 92071",
                        NumOfBeds = "6 bed",
                        NumOfBaths = "5.5 bath",
                        Sqft = "5,505 sqft",
                        SoldDate = "07/21/2017"
                    },
                    PropertyImg = "img/property/home4.jpg",
                    Represented = "Buyer"
                },
                new SalesViewModel()
                {
                    Details = new ActiveProperties()
                    {
                        Price = "$529,000",
                        Location = "Santee, CA",
                        PropertyAddress = "627 Hawthorne Ave • El Cajon, CA 92020",
                        NumOfBeds = "6 bed",
                        NumOfBaths = "5.5 bath",
                        Sqft = "5,505 sqft",
                        SoldDate = "09/11/2017"
                    },
                    PropertyImg = "img/property/home12.jpg",
                    Represented = "Buyer"
                },
                new SalesViewModel()
                {
                    Details = new ActiveProperties()
                    {
                        Price = "$555,000",
                        Location = "La Mesa, CA",
                        PropertyAddress = "9565 Janfred Way • La Mesa, CA 91942",
                        NumOfBeds = "6 bed",
                        NumOfBaths = "5.5 bath",
                        Sqft = "5,505 sqft",
                        SoldDate = "07/11/2017"
                    },
                    PropertyImg = "img/property/home6.jpg",
                    Represented = "Buyer"
                },
                new SalesViewModel()
                {
                    Details = new ActiveProperties()
                    {
                        Price = "$1,265,000",
                        Location = "La Mesa, CA",
                        PropertyAddress = "5160 Alzeda Dr • La Mesa, CA 91941",
                        NumOfBeds = "6 bed",
                        NumOfBaths = "5.5 bath",
                        Sqft = "5,505 sqft",
                        SoldDate = "07/07/2017"
                    },
                    PropertyImg = "img/property/home7.jpg",
                    Represented = "Seller"
                }
            };
        }

        public RatingsReviewViewModel GetRatingsAndReviews()
        {
            var model = new RatingsReviewViewModel();
            var ratingsList = new List<ReviewViewModel>()
            {
                new ReviewViewModel()
                {
                    Date = "09/24/2017",
                    Ratings = "4.5",
                    ReviewedBy = "russroberts",
                    ReviewHome = "Bought a home in 2017 in El Cajon, CA",
                    LocalknowledgeRatings = "4.5",
                    ProcessexpertiseRatings = "4.2",
                    ResponsivenessRatings = "5.0",
                    NegotiationskillsRatings = "4.1",
                    ReviewNote = "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients."
                },
                new ReviewViewModel()
                {
                    Date = "09/24/2017",
                    Ratings = "4.5",
                    ReviewedBy = "russroberts",
                    ReviewHome = "Bought a home in 2017 in El Cajon, CA",
                    LocalknowledgeRatings = "4.5",
                    ProcessexpertiseRatings = "4.2",
                    ResponsivenessRatings = "5.0",
                    NegotiationskillsRatings = "4.1",
                    ReviewNote = "Most important to me was communication and Mark saw that every question or concern of ours we met with full and complete information. In most cases, Mark delivered information to us before we even had to ask. I look forward to working with Mark in the future because I know that I can trust him to"
                }
            };
            ratingsList.ForEach(e =>
            {
                var ratings = decimal.Parse(e.Ratings, CultureInfo.InvariantCulture.NumberFormat);
                e.IntRatings = Convert.ToInt32(Math.Truncate(ratings));
                e.IsDecimal = true;
            });
            model.CustomerReviewsList = ratingsList;
            return model;
        }
    }
}
