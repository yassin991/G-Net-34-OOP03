using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMAENT_OOP03
{
    public class StandardTicket:Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movie, decimal price, string seat)
            : base(movie, price)
        {
            SeatNumber = seat;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Seat: {SeatNumber}";
        }
    }
}
