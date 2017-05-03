using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourismAgency2.Models;

namespace TourismAgency2.Entities
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, CustomerDetails customerDetails);
    }
}
