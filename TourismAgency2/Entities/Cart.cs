using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourismAgency2.Models;

namespace TourismAgency2.Entities
{

    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddToCart(Offer offer, int quantity)
        {
            CartLine line = lineCollection.FirstOrDefault(x => x.Offer.OfferId == offer.OfferId);

            if (line == null)
            {
                lineCollection.Add(new CartLine { Offer = offer, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
 
        }

        public void RemoveLine(Offer offer)
        {
            lineCollection.RemoveAll(x => x.Offer.OfferId == offer.OfferId);
        }

        public decimal ComputeTotalVaue()
        {
            return lineCollection.Sum(e => e.Offer.Price * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection;  }
        }

    }


    public class CartLine
    {
        public Offer Offer { get; set; }
        public int Quantity { get; set; }
    }

}