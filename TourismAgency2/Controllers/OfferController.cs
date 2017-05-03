using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourismAgency2.Models;

namespace TourismAgency2.Controllers
{
    public class OfferController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Offer
        public ActionResult List()
        {
            return View(db.Offers.AsEnumerable());
        }

        //public ActionResult SummerOffers()
        //{
        //    IEnumerable <Offer> summerOffers = db.Offers.Where(x )
        //    return View("List", db.Offers.de)
        //} 
    }
}