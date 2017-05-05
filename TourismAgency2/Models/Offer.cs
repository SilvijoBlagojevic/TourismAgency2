using System.ComponentModel.DataAnnotations;

namespace TourismAgency2.Models
{
    public class Offer
    {
       
        public int OfferId { get; set; }

        [Required]
        [Display(Name = "Offer Name")]
        public string OfferName { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }


        public Seasons? Seasons { get; set; }

        // **to do*********************************
        // public DateTime ValidUntil { get; set; }
        // public DateTime ValidFrom { get; set; }
        // public int NumberAvailable { get; set; }
        // public int NumberInStock { get; set; }
    }

    public enum Seasons
    {
        Summer, Autumn, Winter, Spring,
    }
}