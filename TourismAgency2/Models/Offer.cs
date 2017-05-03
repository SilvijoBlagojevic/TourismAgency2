namespace TourismAgency2.Models
{
    public class Offer
    {
       
        public int OfferId { get; set; }
        public string OfferName { get; set; }
        public string Destination { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public Seasons? Seasons { get; set; }
    }

    public enum Seasons
    {
        Summer, Autumn, Winter, Spring
    }
}