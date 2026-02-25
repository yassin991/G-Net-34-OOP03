using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMAENT_OOP03
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D {  get; set; }

        public IMAXTicket(string movie, decimal price, bool is3D) : base(movie, price)
        {
            Is3D = is3D;
            if (Is3D)
            {
                price += 30;
            }
        }
            public override string ToString()
        {
            return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
