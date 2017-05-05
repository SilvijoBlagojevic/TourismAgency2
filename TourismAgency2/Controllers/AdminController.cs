using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourismAgency2.Models;

namespace TourismAgency2.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Offers.AsEnumerable());
        }

        public ActionResult Edit(int OfferId)
        {
            Offer offerForEdit = db.Offers.FirstOrDefault(x => x.OfferId == OfferId);
            if (offerForEdit == null)
            {
                return View("Index");
            }
            return View("Save", offerForEdit);
        }

        [HttpPost]
        public ActionResult Save(Offer offer)
        {
            var offerDb = db.Offers.FirstOrDefault(x => x.OfferId == offer.OfferId);

            if (ModelState.IsValid)
            {
                offerDb.Destination = offer.Destination;
                offerDb.Description = offer.Description;
                offerDb.OfferName = offer.OfferName;
                offerDb.Price = offer.Price;
                offerDb.Seasons = offer.Seasons;

                TempData["message"] = string.Format("{0} has been changed", offerDb.OfferName);

            }
            else if (offer.OfferId == 0)
            {
                db.Offers.Add(offer);
                TempData["message"] = string.Format("{0} has been added", offer.OfferName);
            }
            else
            {
                return View(offer);
            }

            db.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }


        public ActionResult New()
        {
            return View("Save");
        }

        public ActionResult Delete(int offerId)
        {
            Offer offerDb = db.Offers.FirstOrDefault(x => x.OfferId == offerId);

            if (offerDb == null)
            {
                return HttpNotFound();
            }

            TempData["message"] = string.Format("{0} has been deleted", offerDb.OfferName);
            db.Offers.Remove(offerDb);
            db.SaveChanges();


            return RedirectToAction("Index");
        }


    }
}