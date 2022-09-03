using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************** Hockey Tickets **************");
            Console.WriteLine("Please enter the quantity of tickets sold for each type of seat. ");
            Console.WriteLine();

            Console.WriteLine("Ticket Prices are: ");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Standing Room Only:\t\t$45.85 each\nUpper Bowl:\t\t\t$67.00 each " +
                "\nLower Bowl:\t\t\t$154.50 each");
            Console.WriteLine("___________________________________________");
            Console.WriteLine();

            Console.Write("# Standing Room only: ");
            int standingRoom = Convert.ToInt32(Console.ReadLine());
            Console.Write("# Upper bowl: ");
            int upperBowl = Convert.ToInt32(Console.ReadLine());
            Console.Write("# Lower Bowl: ");
            int lowerBowl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            const double priceofStanding = 45.85;
            const double priceofUpper = 67.00;
            const double priceofLower = 154.50;

            double revenueforStanding = (Convert.ToDouble(standingRoom)) * priceofStanding;
            double revenueforUpper = (Convert.ToDouble(upperBowl)) * priceofUpper;
            double revenueforLower = (Convert.ToDouble(lowerBowl)) * priceofLower;

            Console.WriteLine("Ticket Type\t\t\tQty Sold\t\tRevenue ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"Standing Room Only\t\t{standingRoom}\t\t\t{revenueforStanding.ToString("C")}");
            Console.WriteLine($"Upper Bowl\t\t\t{upperBowl}\t\t\t{revenueforUpper.ToString("C")}");
            Console.WriteLine($"Lower Bowl\t\t\t{lowerBowl}\t\t\t{revenueforLower.ToString("C")}");
            Console.WriteLine("------------------------------------------------------------------------");

            int totalQtySold = standingRoom + upperBowl + lowerBowl;
            double totalRevenue = revenueforStanding + revenueforUpper + revenueforLower;

            Console.WriteLine($"Totals\t\t\t\t{totalQtySold}\t\t\t{totalRevenue.ToString("C")}");
            
            Console.ReadLine();
        }
    }
}
