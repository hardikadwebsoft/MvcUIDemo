using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcUIDemo.Web.Models
{
    public class AgentProfileViewModel
    {
        public string AgentFirstname { get; set; }
        public string AgentLastname { get; set; }
        public string AgentProfPictPath { get; set; }
        public string Ratings { get; set; }
        public int IntRatings { get; set; }
        public bool IsDecimal { get; set; }
        public string ReviewCount { get; set; }
        public string LocalknowledgeRatings { get; set; }
        public string ProcessexpertiseRatings { get; set; }
        public string ResponsivenessRatings { get; set; }
        public string NegotiationskillsRatings { get; set; }
        public string AboutAgent { get; set; }
        public string AgentObjectives { get; set; }
        public string Brokerage { get; set; }
        public string Specialties { get; set; }
        public string LicenseNumbers { get; set; }
    }
}
