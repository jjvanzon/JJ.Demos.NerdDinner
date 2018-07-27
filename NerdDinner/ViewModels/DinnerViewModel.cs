using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.ViewModels
{
    public class DinnerViewModel
    {
        public int DinnerID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public DateTime EventDate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public CountryViewModel Country { get; set; }
        public string HostedBy { get; set; }
    }
}