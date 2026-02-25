using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMAENT_OOP03
{
    public class Ticket
    {
        private static int counter = 0;
        public int TicketId { get; }
        public string MovieName { get; set; }
        private decimal price;
        public decimal Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }
        public decimal PriceAfterTax
        {
            get { return Price * 1.14m; }
        }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;

            counter++;
            TicketId = counter;
        }
        public static int GetTotalTickets()
        {
            return counter;
        }
        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }
}
