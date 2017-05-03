using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourismAgency2.Entities;

namespace TourismAgency2.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }
    }
}