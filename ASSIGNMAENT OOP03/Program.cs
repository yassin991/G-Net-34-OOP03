using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace ASSIGNMAENT_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1_Q01,02
            //Q1: Identify the type of relationship in each scenario below
            //        (Inheritance, Association, Aggregation, Composition, or Dependency):
            //    a) A University has Departments. If the university is closed, the departments no longer exist.
            //        Composition(HAS - A – Strong)
            //        b) A Driver uses a Car.The driver does not own the car.
            //        Association
            //        c) A Dog is an Animal. 
            //        Inheritance
            //        d) A Team has Players. If the team is deleted, the players still exist. 
            //        Aggregation(HAS - A – Weak)
            //        e) A method receives a Logger as a parameter and calls it inside the method only.
            //        Dependency


            //        Q2: Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field.Can a child class in a different assembly access it?
            //            What about through an object instance from outside?
            //            Child class in a different assembly:
            //Yes.A protected member can be accessed by derived classes, even if they are in a different assembly.
            //   Through an object instance from outside:
            //No. protected members cannot be accessed directly through an object from outside the class hierarchy.

            //   b) What is the difference between protected internal and private protected?
            //protected internal Same assembly OR derived classes in other assemblies
            //private protected Only derived classes within the same assembly

            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //When applied to a class
            //A sealed class cannot be inherited.
            //When applied to a method
            //A sealed method cannot be overridden again in further derived classes.
            //It is used when overriding a virtual method.

            //d) Can you create an object from a sealed class using new? Why or why not?
            //        d) Can you create an object from a sealed class using new?
            // Yes, you can create objects from a sealed class.
            //        sealed only prevents inheritance, not object creation.
            //        The class can still be instantiated normally; it just cannot be extended.

            #endregion
            #region the_Movie_Ticket_Booking_System
            Cinema cinema = new Cinema("Cinema Elsuez");

            cinema.OpenCinema();

            Ticket t1 = new StandardTicket("Inception", 120, "A-5");
            Ticket t2 = new VIPTicket("Avengers", 200, true);
            Ticket t3 = new IMAXTicket("Dune", 180, false);
            Ticket t4 = new IMAXTicket("Joker", 350, true);

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);
            cinema.AddTicket(t4);


            cinema.PrintAllTickets();

            Console.WriteLine("\n========= Statistics =========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

            cinema.CloseCinema();

            #endregion
        }
    }
}
