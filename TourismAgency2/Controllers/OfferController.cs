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
        public ActionResult List(string searchString, string sortSeasons)
        {
            

            if(searchString != null)
            {
                IEnumerable<Offer> searchOffers = db.Offers.Where(x => x.Destination.Contains(searchString)).AsEnumerable();
                ViewBag.Seasons = "Results for : " + searchString.ToString();
                return View("List", searchOffers);
            }
 
            if (sortSeasons == null)
            {
                ViewBag.Seasons = "All Offers";
                return View(db.Offers.AsEnumerable());
            }
            if (sortSeasons.Contains("summer"))
            {
                IEnumerable<Offer> summerOffers = db.Offers.Where(x => x.Seasons == Seasons.Summer);
                ViewBag.Seasons = "Summer Offers";
                return View("List", summerOffers);
            }
            if (sortSeasons.Contains("winter"))
            {
                IEnumerable<Offer> winterOffers = db.Offers.Where(x => x.Seasons == Seasons.Winter);
                ViewBag.Seasons = "Winter Offers";
                return View("List", winterOffers);
            }
            if (sortSeasons.Contains("autumn"))
            {
                IEnumerable<Offer> autumnOffers = db.Offers.Where(x => x.Seasons == Seasons.Autumn);
                ViewBag.Seasons = "Autumn Offers";
                return View("List", autumnOffers);
            }
            if (sortSeasons.Contains("spring"))
            {
                IEnumerable<Offer> springOffers = db.Offers.Where(x => x.Seasons == Seasons.Spring);
                ViewBag.Seasons = "Spring Offers";
                return View("List", springOffers);
            }
            else
            {
                return HttpNotFound();
            }


        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}