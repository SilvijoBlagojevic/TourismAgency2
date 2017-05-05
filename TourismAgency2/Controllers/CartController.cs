using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourismAgency2.Entities;
using TourismAgency2.Models;

namespace TourismAgency2.Controllers
{
    public class CartController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        private IOrderProcessor orderProcessor;

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel { Cart = GetCart(), ReturnUrl = returnUrl });
        }

        public RedirectToRouteResult AddToCart(int offerId, string returnUrl)
        {
            Offer offer = db.Offers.FirstOrDefault(x => x.OfferId == offerId);

            if (offer != null)
            {
                GetCart().AddToCart(offer, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            cart = GetCart();

            return PartialView(cart);
        }

        public ViewResult Checkout()
        {
            return View(new CustomerDetails());
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, CustomerDetails shippingDetails)
        {
            cart = GetCart();

            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                //orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }


        }

        public ActionResult RemoveFromCart (Cart cart, int offerId, string returnUrl)
        {
            cart = GetCart();

            Offer _offer = db.Offers.FirstOrDefault(x => x.OfferId == offerId);

            if (_offer != null)
            {
                cart.RemoveLine(_offer);
            }


            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}