using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TourismAgency2.Models
{
    public class OffersListViewModel
    {
        public IEnumerable<Offer> Offers { get; set; }

        public string CurrentDestinacion { get; set; }
    }
}